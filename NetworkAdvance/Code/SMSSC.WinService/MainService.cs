using System;
using System.Configuration;
using System.Data;
using System.ComponentModel;
using System.ServiceProcess;
using System.Threading;
using System.Timers;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using Logger;

using SMSSC.Data;
using SMSSC.Entities;


namespace SMSSC.WinService
{
    public partial class MainService : ServiceBase
    {
        private SMSSCConfig entConfig = null;
        private System.Timers.Timer aTimer = null;
        private GsmCommMain mainCom = null;
        private BackgroundWorker brgWorker = null;

        public MainService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            entConfig = SMSSCConfig.Init();

            Database_Connect();

            brgWorker = new BackgroundWorker();
            brgWorker.DoWork += new DoWorkEventHandler(brgWorker_DoWork);
            brgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(brgWorker_RunWorkerCompleted);

            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += new ElapsedEventHandler(aTimer_Elapsed);
            aTimer.Interval = 60000;
            aTimer.Start();

            WriteLog("OnStart", "SMS Smart Care start");
        }

        protected override void OnStop()
        {
            aTimer.Stop();
            GMS_DisConnect();
            WriteLog("OnStop", "SMS Smart Care stoped");
        }

        protected void aTimer_Elapsed(object source, ElapsedEventArgs e)
        {
            aTimer.Stop();
            brgWorker.RunWorkerAsync();
        }

        protected void brgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            TList<MessageHistory> lstMessageHistory = null;
            try
            {
                lstMessageHistory = DataRepository.MessageHistoryProvider.GetPaged("Status=0", "CreatedDate ASC");
            }
            catch (Exception ex)
            {
                WriteLog("brgWorker_DoWork", "Lỗi truy cập Database: " + ex.Message);
            }
            if (lstMessageHistory != null && lstMessageHistory.Count > 0)
            {
                if (GMS_Connect())
                {
                    byte dcs = DataCodingScheme.NoClass_7Bit;
                    SmsSubmitPdu smsPdu = null;

                    mainCom.EnableTemporarySmsBatchMode();

                    WriteLog("brgWorker_DoWork", "------ Bắt đầu nhắn tin ------");
                    foreach (var entMessageHistory in lstMessageHistory)
                    {
                        try
                        {

                            smsPdu = new SmsSubmitPdu(TextDataConverter.StringTo7Bit(entMessageHistory.ContentText), entMessageHistory.ToPhoneNumber, "", dcs);
                            mainCom.SendMessage(smsPdu);

                            WriteLog("brgWorker_DoWork", "Nhắn thành công đến: " + entMessageHistory.ToPhoneNumber);
                            entMessageHistory.Status = 1;
                            entMessageHistory.Note = string.Empty;
                        }
                        catch (Exception ex)
                        {
                            entMessageHistory.Status = -1;
                            entMessageHistory.Note = ex.Message;
                            WriteLog("brgWorker_DoWork", "Lỗi nhắn đến: " + entMessageHistory.ToPhoneNumber + "-->" + ex.Message);
                        }
                        entMessageHistory.EntityState = EntityState.Changed;
                        entMessageHistory.OriginalId = entMessageHistory.Id;
                        DataRepository.MessageHistoryProvider.Update(entMessageHistory);

                        Thread.Sleep(1000);
                    }
                    WriteLog("brgWorker_DoWork", "------ Kết thúc nhắn tin ------");
                }
            }
            if (GMS_Connect())
            {
                DecodedShortMessage[] messages = mainCom.ReadMessages(PhoneMessageStatus.All, PhoneStorageType.Sim);
                if (messages != null && messages.Length > 0)
                {
                    WriteLog("brgWorker_DoWork", "------ Bắt đầu nhận tin ------");

                    string fromPhoneNumber = string.Empty;
                    MessageHistory entMessageHistory = null;
                    lstMessageHistory = new TList<MessageHistory>();
                    foreach (DecodedShortMessage message in messages)
                    {
                        if (message.Data is SmsDeliverPdu pdu)
                        {
                            fromPhoneNumber = pdu.OriginatingAddress.Replace("+84", "0").Replace("+", "");
                            
                            entMessageHistory = new MessageHistory
                            {
                                Id = Guid.NewGuid(),
                                MessageType = 1,
                                FromPhoneNumber = fromPhoneNumber,
                                ToPhoneNumber = entConfig.FromPhoneNumber,
                                ContentText = MTString.GetText(pdu.UserDataText),
                                CreatedDate = pdu.SCTimestamp.ToDateTime(),
                                EntityState = EntityState.Added
                            };
                            lstMessageHistory.Add(entMessageHistory);

                            WriteLog("brgWorker_DoWork", "Nhận thành công từ: " + fromPhoneNumber);
                        }
                        DataRepository.MessageHistoryProvider.BulkInsert(lstMessageHistory);
                    }
                    mainCom.DeleteMessages(DeleteScope.All, PhoneStorageType.Sim);

                    WriteLog("brgWorker_DoWork", "------ Kết thúc nhận tin ------");
                }
            }
        }

        protected void brgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GMS_DisConnect();
            aTimer.Start();
        }

        private void Database_Connect()
        {
            try
            {
                SMSSC.Data.SqlClient.SqlNetTiersProvider provider = new SMSSC.Data.SqlClient.SqlNetTiersProvider();
                System.Collections.Specialized.NameValueCollection collection = new System.Collections.Specialized.NameValueCollection
                {
                    { "UseStoredProcedure", "true" },
                    { "EnableEntityTracking", "false" },
                    { "entityFactoryType", "SMSSC.Entities.EntityFactory" },
                    { "EnableMethodAuthorization", "false" },
                    { "ConnectionString", entConfig.ConnectionString },
                    { "connectionStringName", "SMSSCConnectionString" },
                    { "ProviderInvariantName", "System.Data.SqlClient" }
                };
                provider.Initialize("DynamicSqlNetTiersProvider", collection);
                DataRepository.LoadProvider(provider, true);
            }
            catch (Exception ex)
            {
                WriteLog("Database_Connect", ex.Message);
                return;
            }
        }

        protected bool GMS_Connect()
        {
            bool result = true;
            if (mainCom == null || !mainCom.IsConnected())
            {
                GMS_DisConnect();
                mainCom = new GsmCommMain(entConfig.PortName, entConfig.BoudRate, 500);
                try
                {
                    mainCom.Open();
                    result = true;
                }
                catch (Exception ex)
                {
                    WriteLog("GMS_Connect", "Lỗi kết nối: " + ex.Message);
                    result = false;
                }
            }
            return result;
        }

        protected void GMS_DisConnect()
        {
            try
            {
                bool flag = mainCom != null && mainCom.IsOpen();
                if (flag)
                {
                    mainCom.Close();
                }
                mainCom = null;
            }
            catch (Exception ex)
            {
                WriteLog("GMS_DisConnect", "Lỗi disconnect: " + ex.Message);
            }
        }

        private void WriteLog(string logFunction, string logMessage)
        {
            string logPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\LOG";
            if (!Directory.Exists(logPath)) Directory.CreateDirectory(logPath);

            CLogger cLogger = new CLogger();
            cLogger.Initialize(logPath, "SMSGateway.log", 2);
            cLogger.LogMessage(logFunction, logMessage);
            cLogger.Terminate();
        }
    }

    public class SMSSCConfig
    {
        public string ConnectionString { get; set; }

        public string PortName { get; set; }

        public int BoudRate { get; set; }

        public string FromPhoneNumber { get; set; }

        public static SMSSCConfig Init()
        {
            var entConfig = new SMSSCConfig
            {
                ConnectionString = "Data Source=103.77.167.138;Database=SMSSmartCare;UID=smssmartcare;PWD=#@abc123;Connection Timeout=100000000",
                PortName = "COM1",
                BoudRate = 9600,
                FromPhoneNumber = "0905080280"
            };
            return entConfig;
        }
    }

    public class MTString
    {
        public static string ClearSpaces(object text)
        {
            string result = text == null ? string.Empty : text.ToString();
            result = Regex.Replace(result, @"\s+", " ");
            return result.TrimStart().TrimEnd();
        }

        public static string GetText(object text)
        {
            string result = text == null ? string.Empty : text.ToString();
            result = ClearSpaces(result.Trim());
            return result;
        }

        public static string GetPhoneNumber(object phoneNumber)
        {
            string result = GetText(phoneNumber);
            result = result.Trim();
            result = result.Replace(" ", "");
            result = result.Replace(".", "");
            result = result.Replace("+84", "");
            result = result.Replace("+084", "");
            return result;
        }

        public static string RemoveVn(object text)
        {
            string result = GetText(text);
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            result = result.Normalize(NormalizationForm.FormD);
            result = regex.Replace(result, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
            return Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(result));
        }

        public static bool CheckPhoneNumber(object phoneNumber)
        {
            string phonePefix = ",086,096,097,098,086,032,033,034,035,036,037,038,039,";
            phonePefix += ",090,093,089,070,076,077,078,079,";
            phonePefix += ",091,094,088,081,082,083,084,085,";
            phonePefix += ",092,056,058,";
            phonePefix += ",099,059,";

            string result = GetPhoneNumber(phoneNumber);
            if (result.Length != 10) return false;
            if (!phonePefix.Contains("," + result.Substring(0, 3) + ",")) return false;
            return true;
        }
    }
}


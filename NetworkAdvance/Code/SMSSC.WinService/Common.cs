using System;
using System.Text;
using System.Text.RegularExpressions;

public class AppSetting
{
    public static string TenCongTy = string.Empty;
    public static string LogPath = string.Empty;

    public static Company Init()
    {
        Company objCompany = new Company();
        if (TenCongTy.Equals("QuocHung"))
        {
            objCompany.Server = "192.168.1.254";
            objCompany.DBName = "MT.MOBILE";
            objCompany.DBUser = "mt.mobile";
            objCompany.PortName = "COM1";
            objCompany.BoudRate = 9600;
        }
        else if (TenCongTy.Equals("LinhVu"))
        {
            objCompany.Server = "192.168.1.254";
            objCompany.DBName = "MT.MOBILE.WMS";
            objCompany.DBUser = "mt.mobile.wms";
            objCompany.PortName = "COM1";
            objCompany.BoudRate = 9600;
        }
        else if (TenCongTy.Equals("DangLe"))
        {
            objCompany.Server = "112.213.85.70";
            objCompany.DBName = "MT.MOBILE.WMS";
            objCompany.DBUser = "mt.mobile.wms";
            objCompany.PortName = "COM1";
            objCompany.BoudRate = 9600;
        }
        else if (TenCongTy.Equals("HungVuong"))
        {
            objCompany.Server = "112.213.88.112";
            objCompany.DBName = "MT.MOBILE.HV";
            objCompany.DBUser = "mt.mobile.hv";
            objCompany.PortName = "COM1";
            objCompany.BoudRate = 9600;
        }
        else if (TenCongTy.Equals("DungSi"))
        {
            objCompany.Server = "192.168.1.254";
            objCompany.DBName = "MT.MOBILE";
            objCompany.DBUser = "mt.mobile";
            objCompany.PortName = "COM1";
            objCompany.BoudRate = 115200;
        }
        else if (TenCongTy.Equals("ThanhLiem"))
        {
            objCompany.Server = "27.0.15.124";
            objCompany.DBName = "MT.MOBILE.TL";
            objCompany.DBUser = "mt.mobile.tl";
            objCompany.PortName = "COM1";
            objCompany.BoudRate = 9600;
        }
        else if (TenCongTy.Equals("VinhQuang"))
        {
            objCompany.Server = "27.0.15.124";
            objCompany.DBName = "MT.MOBILE.VQ";
            objCompany.DBUser = "mt.mobile.vq";
            objCompany.PortName = "COM1";
            objCompany.BoudRate = 9600;
        }
        else if (TenCongTy.Equals("QuangHung"))
        {
            objCompany.Server = "192.168.1.254";
            objCompany.DBName = "MT.MOBILE.WMS";
            objCompany.DBUser = "mt.mobile.wms";
            objCompany.PortName = "COM1";
            objCompany.BoudRate = 9600;
        }
        else if (TenCongTy.Equals("LongHung"))
        {
            objCompany.Server = "192.168.1.119";
            objCompany.DBName = "MT.MOBILE.WMS";
            objCompany.DBUser = "mt.mobile.wms";
            objCompany.PortName = "COM1";
            objCompany.BoudRate = 9600;
        }
        else if (TenCongTy.Equals("SonHai"))
        {
            objCompany.Server = "192.168.1.254";
            objCompany.DBName = "MT.MOBILE.SH";
            objCompany.DBUser = "mt.mobile.sh";
            objCompany.PortName = "COM1";
            objCompany.BoudRate = 9600;
        }
        else if (TenCongTy.Equals("TanVienTin"))
        {
            objCompany.Server = "192.168.1.254";
            objCompany.DBName = "MT.MOBILE.WMS";
            objCompany.DBUser = "mt.mobile.wms";
            objCompany.PortName = "COM1";
            objCompany.BoudRate = 9600;
        }
        return objCompany;
    }

    public static string ConnectString(string sServerName, string sDBName, string sDBUser)
    {
        return string.Format("Data Source={0};Database={1};UID={2};PWD={3};Connection Timeout=100000000", sServerName, sDBName, sDBUser, MTString.Encrypt(AppSetting.TenCongTy));
    }
}

public class Company
{
    private string _Server;
    private string _DBName;
    private string _DBUser;
    private string _PortName;
    private int _BoudRate;

    public string Server
    {
        get
        {
            return _Server;
        }
        set
        {
            _Server = value;
        }
    }

    public string DBName
    {
        get
        {
            return _DBName;
        }
        set
        {
            _DBName = value;
        }
    }

    public string DBUser
    {
        get
        {
            return _DBUser;
        }
        set
        {
            _DBUser = value;
        }
    }

    public string PortName
    {
        get
        {
            return _PortName;
        }
        set
        {
            _PortName = value;
        }
    }

    public int BoudRate
    {
        get
        {
            return _BoudRate;
        }
        set
        {
            _BoudRate = value;
        }
    }
}

public class MTString
{
    public static string RemoveHTML(object oContent)
    {
        string sContent = oContent == null ? string.Empty : oContent.ToString();
        sContent = sContent.Trim();
        char[] array = new char[sContent.Length];
        int arrayIndex = 0;
        bool inside = false;

        for (int i = 0; i < sContent.Length; i++)
        {
            char let = sContent[i];
            if (let == '<')
            {
                inside = true;
                continue;
            }
            if (let == '>')
            {
                inside = false;
                continue;
            }
            if (!inside)
            {
                array[arrayIndex] = let;
                arrayIndex++;
            }
        }

        return ClearSpaces(new string(array, 0, arrayIndex));
    }

    public static string ClearSpaces(object oContent)
    {
        string sContent = oContent == null ? string.Empty : oContent.ToString();
        while (sContent.IndexOf("  ") != -1)
        {
            sContent = sContent.Replace("  ", " ");
        }
        return sContent.TrimStart().TrimEnd(); 
    }

    public static string GetText(object oContent)
    {
        string sContent = oContent == null ? string.Empty : oContent.ToString();
        sContent = ClearSpaces(sContent.Trim());
        return sContent;
    }

    public static string GetPhoneNumber(object oContent)
    {
        string sContent = oContent == null ? string.Empty : oContent.ToString();
        sContent = sContent.Trim();
        sContent = sContent.Replace(" ", "");
        sContent = sContent.Replace(".", "");
        return sContent;
    }

    public static string RemoveVn(object oContent)
    {
        string sContent = GetText(oContent);
        Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
        sContent = sContent.Normalize(NormalizationForm.FormD);
        sContent = regex.Replace(sContent, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        return Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(sContent));
    }

    public static string Encrypt(string strToEncrypt)
    {
        if (strToEncrypt == null) return string.Empty;

        UTF8Encoding ue = new UTF8Encoding();
        byte[] bytes = ue.GetBytes(strToEncrypt);

        // encrypt bytes
        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] hashBytes = md5.ComputeHash(bytes);

        // Convert the encrypted bytes back to a string (base 16)
        string hashString = "";

        for (int i = 0; i < hashBytes.Length; i++)
        {
            hashString += Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
        }

        return hashString.PadLeft(32, '0');
    }
}


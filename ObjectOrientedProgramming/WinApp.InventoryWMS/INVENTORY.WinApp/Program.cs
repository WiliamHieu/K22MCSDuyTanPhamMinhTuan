using System;
using System.Windows.Forms;

namespace INVENTORY.WinApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Blue");
            #pragma warning disable CS0618 // 'CurrencyDataController.DisableThreadingProblemsDetection' is obsolete: 'Threading problems detection disabled'
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
            #pragma warning restore CS0618 // 'CurrencyDataController.DisableThreadingProblemsDetection' is obsolete: 'Threading problems detection disabled'

            string companyKey = "K22MCS";
            MTRegistry.CompanyName = companyKey;
            MTRegistry.ProductName = "Inventory WMS";
            MTRegistry.WriteWithEncrypt("CompanyName", companyKey);
            string companyName = MTRegistry.ReadWithDecrypt("CompanyName");
            if (companyName == null || companyName.Length == 0)
            {
                try
                {
                    MTRegistry.WriteWithEncrypt("CompanyName", companyKey);
                    MTRegistry.WriteWithEncrypt("Server", string.Empty);
                    MTRegistry.WriteWithEncrypt("Username", string.Empty);
                    MTRegistry.WriteWithEncrypt("Password", string.Empty);
                }
                catch (Exception)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Truy cập hệ thống thất bại!", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            AppSetting.TenCongTy = companyName;
            AppSetting.Company_Init();
            Application.Run(new frmLogin());
        }
    }
}

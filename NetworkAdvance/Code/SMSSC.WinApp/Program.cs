using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SMSSC.WinApp
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

            Application.Run(new frmMain());
        }
    }
}

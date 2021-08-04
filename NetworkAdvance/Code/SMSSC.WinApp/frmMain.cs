using System;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraBars;

namespace SMSSC.WinApp
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application_Exit(false);
        }

        private void MainBarManager_HighlightedLinkChanged(object sender, HighlightedLinkChangedEventArgs e)
        {
            if (e.Link != null && (e.Link.Item is BarButtonItem || e.Link.Item is BarSubItem))
            {
                Cursor = Cursors.Hand;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void MainBarManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = null;
            switch (e.Item.Name)
            {
                case "cmdThoat":
                    Application_Exit(false);
                    return;
                case "cmdTinMau":
                    frm = new frmMessageTemplate();
                    break;
                case "cmdTinNhatKy":
                    frm = new frmMessageHistory();
                    break;
                case "cmdTaoTin":
                    frm = new frmMessageAdd();
                    frm.ShowDialog();
                    return;
                case "cmdImportTin":
                    frm = new frmMessageImport();
                    frm.ShowDialog();
                    return;
            }
            if (frm == null) return;
            foreach (Form mdichild in this.MdiChildren)
            {
                if (frm.Name == mdichild.Name)
                {
                    mdichild.Activate();
                    return;
                }
            }
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void spCopyRight_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("http://www.mtsoftware.com");
        }

        private void Application_Exit(bool IsRestart)
        {
            try
            {
                Application.ExitThread();

                if (IsRestart) Application.Restart();
                else Application.Exit();
            }
            catch (Exception)
            {
            }
        }
    }
}
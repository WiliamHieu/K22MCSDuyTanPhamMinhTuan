using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.KHOHANG
{
    public partial class frmHangTon : DevExpress.XtraEditors.XtraForm
    {
        TutorialFormBase ba = new TutorialFormBase();
        private List<CustomKhSanPhamGetListResult> lstHangTon = null;

        public frmHangTon()
        {
            InitializeComponent();
        }

        private void frmHangTon_Load(object sender, EventArgs e)
        {
            ucNhomVatTu.LoadData(false);
        }

        private void frmHangTon_Activated(object sender, EventArgs e)
        {
            BindData();
        }

        private void frmHangTon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            if (ba != null) ba.Exit();
        }

        private void BindData()
        {
            if (!ucNhomVatTu.Loaded) return;
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ba.CreateWaitDialog();
            ba.SetWaitDialogCaption("Bắt đầu truy vấn dữ liệu");
            brgWorker.RunWorkerAsync("View");
        }

        private void ToolbarBc_Clicked(object sender, EventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (ToolbarBc.SenderName)
            {
                case INVENTORY.CONTROL.ToolbarBc.Action.Search:
                    BindData();
                    break;
                case INVENTORY.CONTROL.ToolbarBc.Action.Export:
                    oXtraGrid.ExportXLSX(gridMainView, "HangTon");
                    break;
                case INVENTORY.CONTROL.ToolbarBc.Action.Print:
                    oXtraGrid.Print(gridMain, this.Text);
                    break;
                case INVENTORY.CONTROL.ToolbarBc.Action.Close:
                    this.Close();
                    break;
            }
        }

        private void ucNhomVatTu_FocusedNodeChanged(object sender, EventArgs e)
        {
            BindData();
        }

        private void gridMainView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                int rowIndex = e.RowHandle;
                if (rowIndex >= 0)
                {
                    rowIndex++;
                    e.Info.DisplayText = rowIndex.ToString();
                }
            }
        }

        private void brgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var dbContext = new InventoryDbContext())
            {
                Guid? IdNhomVatTu = null;
                if (ucNhomVatTu.IdNhomVatTu != DBNull.Value) IdNhomVatTu = (Guid)ucNhomVatTu.IdNhomVatTu;
                lstHangTon = dbContext.CustomKhSanPhamGetList(AppSetting.entKhoHang.Id, IdNhomVatTu).ToList();
            }
        }

        private void brgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ba.SetWaitDialogCaption("Kết thúc truy vấn và Bắt đầu hiển thị dữ liệu");

            gridMain.DataSource = lstHangTon;

            ba.SetWaitDialogCaption("Kết thúc hiển thị dữ liệu");
            ba.Exit();
        }
    }
}
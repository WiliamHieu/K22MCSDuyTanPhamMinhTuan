using System;
using System.Data;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.BAOCAO.FORM
{
    public partial class frmHangTonTheoKho : XtraForm
    {
        readonly TutorialFormBase ba = new TutorialFormBase();

        private DateTime dtNgayHienTai = DateTime.Now;
        private List<CustomRpHangTonTheoKhoResult> lstHangTonTheoKho = null;
        private string lstIdNhomVatTu = string.Empty;

        public frmHangTonTheoKho()
        {
            InitializeComponent();
        }

        private void frmHangTonTheoKho_Load(object sender, EventArgs e)
        {
            dtNgayHienTai = AppSetting.DateTime_GetServer();
            BindCatalog.DmKhoHang_BindDropDown(cboKhoHang);
            ucNhomVatTu.LoadData(true);
        }

        private void frmHangTonTheoKho_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BrgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void BindData()
        {
            if (BrgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboKhoHang.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn Kho hàng để Tạo báo cáo", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKhoHang.Focus();
                return;
            }
            lstIdNhomVatTu = ucNhomVatTu.GetCheckedIds;
            if (lstIdNhomVatTu.Length == 0)
            {
                XtraMessageBox.Show("Chưa chọn Nhóm vật tư để Tạo báo cáo", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucNhomVatTu.Focus();
                return;
            }
            if (lstIdNhomVatTu.Length > 8000)
            {
                XtraMessageBox.Show("Số lượng Nhóm vật tư vượt quá Số lượng cho phép", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucNhomVatTu.Focus();
                return;
            }
            ba.CreateWaitDialog();
            ba.SetWaitDialogCaption("Bắt đầu truy vấn dữ liệu");
            BrgWorker.RunWorkerAsync("View");
        }

        private void FilterData(TextEdit txtKeySearch, string newValue)
        {
            if (txtKeySearch == null) 
            {
                gridMain.DataSource = lstHangTonTheoKho;
                return;
            }
            else
            {
                string TenNhomVatTu = MTString.TextClean(txtTenNhomVatTu.EditValue);
                string TenLoaiVatTu = MTString.TextClean(txtTenLoaiVatTu.EditValue);
                if (txtKeySearch.Name.Equals("txtTenNhomVatTu"))
                {
                    TenNhomVatTu = newValue;
                }
                else if (txtKeySearch.Name.Equals("txtTenLoaiVatTu"))
                {
                    TenLoaiVatTu = newValue;
                }
                gridMain.DataSource = (from tt in lstHangTonTheoKho
                                       where (TenNhomVatTu.Length == 0 || tt.TenNhomVatTu.Contains(TenNhomVatTu)) &&
                                             (TenLoaiVatTu.Length == 0 || tt.TenLoaiVatTu.Contains(TenLoaiVatTu))
                                       select tt).OrderBy(d => d.TenNhomVatTu).OrderBy(d => d.TenLoaiVatTu).ToList();
            }
        }

        private void ToolbarBc_Clicked(object sender, EventArgs e)
        {
            if (BrgWorker.IsBusy)
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
                    oXtraGrid.ExportXLSX(gridMain, "HangTonTheoKho");
                    break;
                case INVENTORY.CONTROL.ToolbarBc.Action.Print:
                    oXtraGrid.Print(gridMain);
                    break;
                case INVENTORY.CONTROL.ToolbarBc.Action.Close:
                    this.Close();
                    break;
            }
        }

        private void cboKhoHang_EditValueChanged(object sender, EventArgs e)
        {
            if (MTString.Length(cboKhoHang.EditValue) == 0)
            {
                cboKhoHang.EditValue = null;
            }
        }

        private void txtKeySearch_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            FilterData((TextEdit)sender, MTString.Text(e.NewValue));
        }

        private void gridMain_FieldValueDisplayText(object sender, DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs e)
        {
            if (e.ValueType == DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal)
            {
                e.DisplayText =  "Tổng tồn";
            }
            else if (e.ValueType == DevExpress.XtraPivotGrid.PivotGridValueType.Total)
            {
                e.DisplayText = "Tồn " + e.DisplayText.Replace(" Total","");
            }
        }

        private void BrgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var dbContext = new InventoryDbContext())
            {
                lstHangTonTheoKho = dbContext.CustomRpHangTonTheoKho(cboKhoHang.EditValue.ToString(), lstIdNhomVatTu).ToList();
            }
        }

        private void BrgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ba.SetWaitDialogCaption("Kết thúc truy vấn dữ liệu");
            ba.SetWaitDialogCaption("Bắt đầu hiển thị dữ liệu");

            FilterData(null, string.Empty);

            ba.SetWaitDialogCaption("Kết thúc truy vấn dữ liệu");
            ba.Exit();
        }
    }
}
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;
//using INVENTORY.WinApp.KHOHANG;

namespace INVENTORY.WinApp.BAOCAO.FORM
{
    public partial class frmNhapXuatTonDetail : DevExpress.XtraEditors.XtraForm
    {
        TutorialFormBase ba = new TutorialFormBase();
        public frmNhapXuatTon frmParent = null;

        public object lstIdKhoHang = DBNull.Value;
        public object lstTenKhoHang = DBNull.Value;
        public object oIdLoaiVatTu = DBNull.Value;
        public object oTenLoaiVatTu = DBNull.Value;
        public DateTime dtTuNgay = DateTime.Now;
        public DateTime dtDenNgay = DateTime.Now;

        private DataTable dtNhapXuatTonCt = null;

        public frmNhapXuatTonDetail(frmNhapXuatTon frm)
        {
            InitializeComponent();
            frmParent = frm;
        }

        private void frmNhapXuatTonDetail_Load(object sender, EventArgs e)
        {
            txtTenKhoHang.EditValue = lstTenKhoHang;
            txtTenLoaiVatTu.EditValue = oTenLoaiVatTu;
            txtTuNgay.EditValue = dtTuNgay.ToString("dd/MM/yyyy");
            txtDenNgay.EditValue = dtDenNgay.ToString("dd/MM/yyyy");

            ba.CreateWaitDialog();
            ba.SetWaitDialogCaption("Bắt đầu truy vấn dữ liệu");
            brgWorker.RunWorkerAsync("View");
        }

        private void frmNhapXuatTonDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            if (ba != null) ba.Exit();
        }

        private void EditData()
        {
            int LoaiPhieu = MTValue.Int32(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "LoaiPhieu"));
            //Guid IdPhieu = MTValue.Guid(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "IdPhieu"));
            //if (LoaiPhieu == 0)
            //{
            //    frmPhieuNhapEdit frm = new frmPhieuNhapEdit(null);
            //    frm.IdPhieuNhap = IdPhieu;
            //    frm.ShowDialog();
            //}
            //else if (LoaiPhieu == 1)
            //{
            //    frmPhieuXuatEdit frm = new frmPhieuXuatEdit(null);
            //    frm.IdPhieuXuat = IdPhieu;
            //    frm.ShowDialog();
            //}
            //else if (LoaiPhieu == 2)
            //{
            //    frmPhieuChuyenEdit frm = new frmPhieuChuyenEdit(null);
            //    frm.IdPhieuChuyen = IdPhieu;
            //    frm.ShowDialog();
            //}
        }

        private void ToolbarIn_Clicked(object sender, EventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (ToolbarIn.SenderName)
            {
                case INVENTORY.CONTROL.ToolbarIn.Action.Print:
                    oXtraGrid.Print(gridMain, this.Text);
                    break;
                case INVENTORY.CONTROL.ToolbarIn.Action.Close:
                    this.Close();
                    break;
            }
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

        private void gridMain_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gridMainView.IsDataRow(gridMainView.FocusedRowHandle))
                {
                    EditData();
                }
            }
        }

        private void gridMainView_DoubleClick(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo rowInfor = gridMainView.CalcHitInfo((e as MouseEventArgs).Location);
            if (rowInfor.InRowCell == true)
            {
                if (gridMainView.IsDataRow(gridMainView.FocusedRowHandle))
                {
                    EditData();
                }
            }
        }

        private void brgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //dtNhapXuatTonCt = DataRepository.Provider.ExecuteDataSet("dbo.Custom_RP_NhapXuatTonChiTiet", lstIdKhoHang, oIdLoaiVatTu, dtTuNgay, dtDenNgay).Tables[0];
        }

        private void brgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ba.SetWaitDialogCaption("Kết thúc truy vấn và Bắt đầu hiển thị dữ liệu");

            gridMain.DataSource = dtNhapXuatTonCt;

            ba.SetWaitDialogCaption("Kết thúc hiển thị dữ liệu");
            ba.Exit();
        }
    }
}
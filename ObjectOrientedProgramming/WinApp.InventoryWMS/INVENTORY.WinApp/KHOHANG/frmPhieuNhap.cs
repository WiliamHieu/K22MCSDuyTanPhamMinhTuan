using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.KHOHANG
{
    public partial class frmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        TutorialFormBase ba = new TutorialFormBase();

        private DateTime dtNgayHienTai = DateTime.Now;

        private List<CustomKhPhieuNhapGetListResult> lstPhieuNhap = null;

        private int firstLoad = 0;
        private string runType, saveResult = string.Empty;

        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dtNgayHienTai = AppSetting.DateTime_GetServer();
            Toolbar01.ThoiGian = dtNgayHienTai;
            Toolbar01.FormName = this.Name;
        }

        private void frmPhieuNhap_Activated(object sender, EventArgs e)
        {
            BindData();
        }

        private void frmPhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            if (ba != null) ba.Exit();
        }

        public void BindData()
        {
            if (brgWorker.IsBusy) 
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            firstLoad = 0;
            ba.CreateWaitDialog();
            ba.SetWaitDialogCaption("Bắt đầu truy vấn dữ liệu");
            brgWorker.RunWorkerAsync("View");
        }

        private void AddData()
        {
            frmPhieuNhapAdd frmAdd = new frmPhieuNhapAdd(this);
            DialogResult drResult = frmAdd.ShowDialog();
            if (drResult == DialogResult.OK) AddData();
            else if (drResult == DialogResult.Yes) PrintData();
        }

        private void EditData()
        {
            Guid IdPhieuNhap = new Guid(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id").ToString());
            frmPhieuNhapEdit frm = new frmPhieuNhapEdit(this);
            frm.IdPhieuNhap = IdPhieuNhap;
            DialogResult drResult = frm.ShowDialog();
            if (drResult == DialogResult.OK) AddData();
            else if (drResult == DialogResult.Yes) PrintData();
        }

        private void PrintData()
        {
            oReport.KH_PhieuNhap_Print(oReport.dtThongTinPhieu, oReport.dtThongTinSanPham);
        }

        private void FocusData()
        {
            if (gridMainView.IsDataRow(gridMainView.FocusedRowHandle))
            {       
                Guid IdPhieuNhap = new Guid(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id").ToString());
                int LoaiNhap = Convert.ToInt32(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "LoaiNhap"));
                gridChiTiet.DataSource = oFunction.KhNhapXuat_Get_ListChiTiet(LoaiNhap.Equals(0) ? "Nhap" : "NhapDn", null, IdPhieuNhap);

                DateTime dtNgayTao = Convert.ToDateTime(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "NgayTao"));
                if (MTDateTime.Days(dtNgayTao, dtNgayHienTai) > 0 && !AppSetting.entThietLap.XoaQuaNgay)
                    Toolbar01.DisableTool = INVENTORY.CONTROL.Toolbar01.Action.Delete;
                else
                    Toolbar01.EnableTool = INVENTORY.CONTROL.Toolbar01.Action.Delete;
            }
            else
            {
                gridChiTiet.DataSource = null;
            }
        }

        private void Toolbar01_Clicked(object sender, EventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (Toolbar01.SenderName)
            {
                case INVENTORY.CONTROL.Toolbar01.Action.Add:
                    AddData();
                    break;
                case INVENTORY.CONTROL.Toolbar01.Action.Edit:
                    try
                    {
                        if (gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                        {
                            XtraMessageBox.Show("Chưa chọn Phiếu nhập để Sửa đổi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        EditData();
                    }
                    catch (Exception)
                    {
                        XtraMessageBox.Show("Có lỗi xảy ra trong quá trình Sửa đổi bản ghi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case INVENTORY.CONTROL.Toolbar01.Action.Delete:
                    try
                    {
                        if (gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                        {
                            XtraMessageBox.Show("Chưa chọn Phiếu nhập để Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        int TrangThai = Convert.ToInt32(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "LoaiNhap"));
                        if (TrangThai != 0)
                        {
                            XtraMessageBox.Show("Chỉ được phép xóa Thông tin Phiếu nhập mới", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        Guid IdPhieuNhap = new Guid(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id").ToString());
                        if (oFunction.KhPhieuNhap_Check_Delete(null, IdPhieuNhap, null) > 0)
                        {
                            XtraMessageBox.Show("Sản phẩm trong Phiếu nhập đã được xuất nên không thể Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        DialogResult drResult = XtraMessageBox.Show("Bạn có muốn xóa những Phiếu nhập đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (drResult == DialogResult.No) return;

                        ba.CreateWaitDialog();
                        ba.SetWaitDialogCaption("Bắt đầu xóa bỏ dữ liệu");
                        brgWorker.RunWorkerAsync("Delete");
                    }
                    catch (Exception)
                    {
                        XtraMessageBox.Show("Có lỗi xảy ra trong quá trình Xóa bản ghi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case INVENTORY.CONTROL.Toolbar01.Action.Refresh:
                    BindData();
                    break;
                case INVENTORY.CONTROL.Toolbar01.Action.Export:
                    oXtraGrid.ExportXLSX(gridMainView, "PhieuNhap");
                    break;
                case INVENTORY.CONTROL.Toolbar01.Action.Print:
                    oXtraGrid.Print(gridMain, this.Text);
                    break;
                case INVENTORY.CONTROL.Toolbar01.Action.Close:
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

        private void gridMainView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (firstLoad == 0) return;
            FocusData();
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

        private void brgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            runType = e.Argument.ToString();
            if (runType.Equals("View"))
            {
                using (var dbContext = new InventoryDbContext())
                {
                    lstPhieuNhap = dbContext.CustomKhPhieuNhapGetList(AppSetting.entKhoHang.Id, Toolbar01.TuNgay, Toolbar01.DenNgay).ToList();
                }
            }
            else if (runType.Equals("Delete"))
            {
                using (var dbContext = new InventoryDbContext())
                {
                    dbContext.Connection.Open();
                    dbContext.Transaction = dbContext.Connection.BeginTransaction(IsolationLevel.Snapshot);
                    try
                    {
                        Guid IdPhieuNhap = new Guid(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id").ToString());
                        dbContext.CustomGenKhPhieuNhapDelete(AppSetting.entKhoHang.Id, IdPhieuNhap, true);

                        dbContext.Transaction.Commit();

                        saveResult = "ThanhCong";
                    }
                    catch (Exception)
                    {
                        dbContext.Transaction.Rollback();

                        saveResult = "ThatBai";
                    }
                }
            }
        }

        private void brgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (runType.Equals("View"))
            {
                ba.SetWaitDialogCaption("Kết thúc truy vấn và Bắt đầu hiển thị dữ liệu");

                gridMain.DataSource = lstPhieuNhap;

                ba.SetWaitDialogCaption("Kết thúc hiển thị dữ liệu");
                ba.Exit();

                firstLoad = 1;
                FocusData();
            }
            else if (runType.Equals("Delete"))
            {
                ba.SetWaitDialogCaption("Kết thúc xóa dữ liệu");
                ba.Exit();

                if (saveResult.Equals("ThatBai"))
                    XtraMessageBox.Show("Xóa Phiếu nhập Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    BindData();
            }
        }
    }
}
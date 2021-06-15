using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using Excel = NetOffice.ExcelApi;

using INVENTORY.Data;

namespace INVENTORY.WinApp.BAOCAO.FORM
{
    public partial class frmHangXuat : DevExpress.XtraEditors.XtraForm
    {
        TutorialFormBase ba = new TutorialFormBase();
        private DateTime dtNgayHienTai = DateTime.Now;

        private string lstIdNhomVatTu, excelFile, runType = string.Empty;
        private List<CustomRpHangXuatResult1> lstHangXuatTongHop = null;
        private List<CustomRpHangXuatResult2> lstHangXuatChiTiet = null;
        private DataTable dtHangXuatExport = null;
        private int LoaiBaoCao = 0;

        public frmHangXuat()
        {
            InitializeComponent();
        }

        private void frmHangXuat_Load(object sender, EventArgs e)
        {
            dtNgayHienTai = AppSetting.DateTime_GetServer();

            BindCatalog.DmKhoHang_BindDropDown(cboKhoHang);
            BindCatalog.LoaiBaoCao_BindDropDown(cboLoaiBaoCao);
            BindCatalog.DmBoPhan_BindDropDown(cboBoPhan);
            
            ucNhomVatTu.LoadData(true);
            ucThoiGian.ThoiGian = dtNgayHienTai;
        }

        public void BindData()
        {
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            brgWorker.RunWorkerAsync("View");
        }

        private void EditData()
        {
            if (cboLoaiBaoCao.EditValue.ToString().Equals("1"))
            {
                Guid IdPhieuXuat = new Guid(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id").ToString());
                KHOHANG.frmPhieuXuatEdit frm = new KHOHANG.frmPhieuXuatEdit(null);
                frm.IdPhieuXuat = IdPhieuXuat;
                frm.ShowDialog();
            }
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
                    if (LoaiBaoCao == 0)
                    {
                        dtHangXuatExport = oFunction.ToDataTable(lstHangXuatTongHop);
                    }
                    else
                    {
                        dtHangXuatExport = oFunction.ToDataTable(lstHangXuatChiTiet);
                    }
                    if (dtHangXuatExport == null || dtHangXuatExport.Rows.Count == 0)
                    {
                        XtraMessageBox.Show("Không tồn tại Dữ liệu để Xuất Excel", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    ba.CreateWaitDialog();
                    ba.SetWaitDialogCaption("Bắt đầu kết xuất dữ liệu");
                    brgWorker.RunWorkerAsync("Export");
                    break;
                case INVENTORY.CONTROL.ToolbarBc.Action.Print:
                    oXtraGrid.Print(gridMain, this.Text);
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

        private void cboBoPhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (cboBoPhan.SelectionLength == cboBoPhan.Text.Length && (e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
            {
                cboBoPhan.EditValue = null;
                e.Handled = true;
            }
        }

        private void cboLoaiBaoCao_EditValueChanged(object sender, EventArgs e)
        {
            if (cboLoaiBaoCao.EditValue.ToString().Equals("0"))
            {
                gridMainView.Columns["TenBoPhan"].Visible = false;
                gridMainView.Columns["TenBoPhan"].VisibleIndex = -1;
                gridMainView.Columns["SoPhieu"].Visible = false;
                gridMainView.Columns["SoPhieu"].VisibleIndex = -1;
                gridMainView.Columns["TenNguoiNhan"].Visible = false;
                gridMainView.Columns["TenNguoiNhan"].VisibleIndex = -1;
                gridMainView.Columns["TenNguoiTao"].Visible = false;
                gridMainView.Columns["TenNguoiTao"].VisibleIndex = -1;
                gridMainView.Columns["NgayTao"].Visible = false;
                gridMainView.Columns["NgayTao"].VisibleIndex = -1;
            }
            else if (cboLoaiBaoCao.EditValue.ToString().Equals("1"))
            {
                gridMainView.Columns["TenBoPhan"].Visible = true;
                gridMainView.Columns["TenBoPhan"].VisibleIndex = 0;
                gridMainView.Columns["SoPhieu"].Visible = true;
                gridMainView.Columns["SoPhieu"].VisibleIndex = 1;
                gridMainView.Columns["TenNguoiNhan"].Visible = true;
                gridMainView.Columns["TenNguoiNhan"].VisibleIndex = 2;
                gridMainView.Columns["TenNguoiTao"].Visible = true;
                gridMainView.Columns["TenNguoiTao"].VisibleIndex = 3;
                gridMainView.Columns["NgayTao"].Visible = true;
                gridMainView.Columns["NgayTao"].VisibleIndex = 4;
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

        private void gridMainView_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            ArrayList items = oXtraGrid.ExtractSummaryItems(gridMainView);
            if (items.Count == 0) return;
            oXtraGrid.DrawBackground(e, gridMainView);
            oXtraGrid.DrawSummaryValues(e, gridMainView, items);
            e.Handled = true;
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
                LoaiBaoCao = Convert.ToInt32(cboLoaiBaoCao.EditValue);

                Guid? IdBoPhan = null;
                if (cboBoPhan.EditValue != null) IdBoPhan = MTValue.Guid(cboBoPhan.EditValue);
                using (var dbContext = new InventoryDbContext())
                {
                    if (LoaiBaoCao == 0)
                        lstHangXuatTongHop = dbContext.CustomRpHangXuat(cboKhoHang.EditValue.ToString(), IdBoPhan, lstIdNhomVatTu, ucThoiGian.TuNgay, ucThoiGian.DenNgay, LoaiBaoCao).GetResult<CustomRpHangXuatResult1>().ToList();
                    else
                        lstHangXuatChiTiet = dbContext.CustomRpHangXuat(cboKhoHang.EditValue.ToString(), IdBoPhan, lstIdNhomVatTu, ucThoiGian.TuNgay, ucThoiGian.DenNgay, LoaiBaoCao).GetResult<CustomRpHangXuatResult2>().ToList();
                }
            }
            else
            {
                Excel.Application objExcel = null;
                try
                {
                    int LoaiBaoCao = Convert.ToInt32(cboLoaiBaoCao.EditValue);
                    string tempFile = LoaiBaoCao == 0 ? "BM_NhapXuatTongHop.xlsx" : "BM_NhapXuatChiTiet.xlsx";
                    string sourceFile = Application.StartupPath + "\\BAOCAO\\EXCEL\\" + tempFile;

                    excelFile = System.IO.Path.GetTempPath() + "\\" + Guid.NewGuid() + ".xlsx";
                    if (!System.IO.File.Exists(excelFile))
                    {
                        System.IO.File.Copy(sourceFile, excelFile);
                    }
                    objExcel = new Excel.Application();
                    objExcel.DisplayAlerts = false;

                    Excel.Workbook workBook = objExcel.Workbooks.Open(excelFile);
                    Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Worksheets[1];
                    workSheet.Name = "HangXuat";

                    workSheet.Range("A1").Value = AppSetting.entChiNhanh.Ten.ToUpper();
                    workSheet.Range("A2").Value = AppSetting.entChiNhanh.DiaChi;
                    workSheet.Range("A3").Value = AppSetting.entChiNhanh.LienHe;
                    workSheet.Range("A6").Value = "(Tên kho: " + cboKhoHang.Text + " )";
                    workSheet.Range("A7").Value = "TỪ NGÀY: " + MTDateTime.VnDate(ucThoiGian.TuNgay) + " - ĐẾN NGÀY: " + MTDateTime.VnDate(ucThoiGian.DenNgay);

                    int RowIndex = 10; int STT = 1;
                    if (LoaiBaoCao == 0)
                    {
                        workSheet.Range("A5").Value = "TỔNG HỢP HÀNG XUẤT KHO";
                        foreach (DataRow row in dtHangXuatExport.Rows)
                        {
                            workSheet.Rows[RowIndex + 1].Insert();
                            workSheet.Range("A" + RowIndex).Value = STT;
                            workSheet.Range("B" + RowIndex).Value = row["TenLoaiVatTu"];
                            workSheet.Range("C" + RowIndex).Value = row["QuyCach"];
                            workSheet.Range("D" + RowIndex).Value = row["TenDonViTinh"];
                            workSheet.Range("E" + RowIndex).Value = row["SoLuong"];
                            RowIndex++;
                            STT++;
                        }
                        workSheet.Rows[RowIndex].Delete();
                        workSheet.Rows[RowIndex].Delete();

                        workSheet.Range("E" + RowIndex).Value = MTDataTable.SumD(dtHangXuatExport, "SoLuong");
                    }
                    else if (LoaiBaoCao == 1)
                    {
                        workSheet.Range("A5").Value = "CHI TIẾT HÀNG XUẤT KHO";

                        foreach (DataRow row in dtHangXuatExport.Rows)
                        {
                            workSheet.Rows[RowIndex + 1].Insert();
                            workSheet.Range("A" + RowIndex).Value = STT;
                            workSheet.Range("B" + RowIndex).Value = row["TenBoPhan"];
                            workSheet.Range("C" + RowIndex).Value = row["SoPhieu"];
                            workSheet.Range("D" + RowIndex).Value = row["TenNguoiNhan"];
                            workSheet.Range("E" + RowIndex).Value = row["TenNguoiTao"];
                            workSheet.Range("F" + RowIndex).Value = MTDateTime.VnDateTime(row["NgayTao"]);
                            workSheet.Range("G" + RowIndex).Value = row["TenLoaiVatTu"];
                            workSheet.Range("H" + RowIndex).Value = row["QuyCach"];
                            workSheet.Range("I" + RowIndex).Value = row["TenDonViTinh"];
                            workSheet.Range("J" + RowIndex).Value = row["SoLuong"];
                            RowIndex++;
                            STT++;
                        }
                        workSheet.Rows[RowIndex].Delete();
                        workSheet.Rows[RowIndex].Delete();

                        workSheet.Range("J" + RowIndex).Value = MTDataTable.SumD(dtHangXuatExport, "SoLuong");
                    }

                    workBook.Save();
                    objExcel.Quit();
                    objExcel.Dispose();
                }
                catch (Exception)
                {
                    if (objExcel != null)
                    {
                        objExcel.Quit();
                        objExcel.Dispose();
                    }
                }
            }
        }

        private void brgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (runType.Equals("View"))
            {
                ba.SetWaitDialogCaption("Kết thúc truy vấn và Bắt đầu hiển thị dữ liệu");

                if (LoaiBaoCao == 0)
                    gridMain.DataSource = lstHangXuatTongHop;
                else
                    gridMain.DataSource = lstHangXuatChiTiet;

                ba.SetWaitDialogCaption("Kết thúc hiển thị dữ liệu");
                ba.Exit();
            }
            else
            {
                ba.SetWaitDialogCaption("Kết thúc kết xuất và bắt đầu hiển thị dữ liệu");
                ba.Exit();
                try
                {
                    System.Diagnostics.Process.Start(excelFile);
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
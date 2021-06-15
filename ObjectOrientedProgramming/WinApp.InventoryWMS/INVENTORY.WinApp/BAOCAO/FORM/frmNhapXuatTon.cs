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
    public partial class frmNhapXuatTon : DevExpress.XtraEditors.XtraForm
    {
        TutorialFormBase ba = new TutorialFormBase();
        private DateTime dtNgayHienTai = DateTime.Now;

        private string lstIdNhomVatTu, excelFile, runType = string.Empty;
        private List<CustomRpNhapXuatTonResult> lstNhapXuatTon = null;
        private DataTable dtNhapXuatTonExport = null;

        public frmNhapXuatTon()
        {
            InitializeComponent();
        }

        private void frmNhapXuatTon_Load(object sender, EventArgs e)
        {
            dtNgayHienTai = AppSetting.DateTime_GetServer();
            BindCatalog.DmKhoHang_BindDropDown(cboKhoHang);

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
            frmNhapXuatTonDetail frm = new frmNhapXuatTonDetail(this)
            {
                lstIdKhoHang = cboKhoHang.EditValue,
                lstTenKhoHang = cboKhoHang.Text,
                oIdLoaiVatTu = gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "IdLoaiVatTu"),
                oTenLoaiVatTu = gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "TenLoaiVatTu"),
                dtTuNgay = ucThoiGian.TuNgay,
                dtDenNgay = ucThoiGian.DenNgay
            };
            frm.ShowDialog();
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
                    dtNhapXuatTonExport = oFunction.ToDataTable(lstNhapXuatTon);
                    if (dtNhapXuatTonExport == null || dtNhapXuatTonExport.Rows.Count == 0)
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
            runType = e.Argument.ToString();
            if (runType.Equals("View"))
            {
                using (var dbContext = new InventoryDbContext())
                {
                    lstNhapXuatTon = dbContext.CustomRpNhapXuatTon(cboKhoHang.EditValue.ToString(), lstIdNhomVatTu, ucThoiGian.TuNgay, ucThoiGian.DenNgay).ToList();
                }
            }
            else
            {
                Excel.Application objExcel = null;
                try
                {
                    string sourceFile = Application.StartupPath + "\\BAOCAO\\EXCEL\\BM_NhapXuatTon.xlsx";
                    excelFile = System.IO.Path.GetTempPath() + "\\" + Guid.NewGuid() + ".xlsx";
                    if (!System.IO.File.Exists(excelFile))
                    {
                        System.IO.File.Copy(sourceFile, excelFile);
                    }
                    objExcel = new Excel.Application();
                    objExcel.DisplayAlerts = false;

                    Excel.Workbook workBook = objExcel.Workbooks.Open(excelFile);
                    Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Worksheets[1];

                    workSheet.Range("A1").Value = AppSetting.entChiNhanh.Ten.ToUpper();
                    workSheet.Range("A2").Value = AppSetting.entChiNhanh.DiaChi;
                    workSheet.Range("A3").Value = AppSetting.entChiNhanh.LienHe;

                    workSheet.Range("A5").Value = "NHẬP XUẤT TỒN";
                    workSheet.Range("A6").Value = "(Tên kho: " + cboKhoHang.Text + " )";
                    workSheet.Range("A7").Value = "TỪ NGÀY: " + MTDateTime.VnDate(ucThoiGian.TuNgay) + " - ĐẾN NGÀY: " + MTDateTime.VnDate(ucThoiGian.DenNgay);

                    int RowIndex = 10; int STT = 1; 
                    foreach (DataRow row in dtNhapXuatTonExport.Rows)
                    {
                        workSheet.Rows[RowIndex + 1].Insert();
                        workSheet.Range("A" + RowIndex).Value = STT;
                        workSheet.Range("B" + RowIndex).Value = row["TenLoaiVatTu"];
                        workSheet.Range("C" + RowIndex).Value = row["QuyCach"];
                        workSheet.Range("D" + RowIndex).Value = row["TenDonViTinh"];
                        workSheet.Range("E" + RowIndex).Value = row["TonDau"];
                        workSheet.Range("F" + RowIndex).Value = row["Nhap"];
                        workSheet.Range("G" + RowIndex).Value = row["Xuat"];
                        workSheet.Range("H" + RowIndex).Value = row["Chuyen"];
                        workSheet.Range("I" + RowIndex).Value = row["TonCuoi"];
                        RowIndex++;
                        STT++;
                    }
                    workSheet.Rows[RowIndex].Delete();
                    workSheet.Rows[RowIndex].Delete();

                    workSheet.Range("E" + RowIndex).Value = MTDataTable.SumD(dtNhapXuatTonExport, "TonDau");
                    workSheet.Range("F" + RowIndex).Value = MTDataTable.SumD(dtNhapXuatTonExport, "Nhap");
                    workSheet.Range("G" + RowIndex).Value = MTDataTable.SumD(dtNhapXuatTonExport, "Xuat");
                    workSheet.Range("H" + RowIndex).Value = MTDataTable.SumD(dtNhapXuatTonExport, "Chuyen");
                    workSheet.Range("I" + RowIndex).Value = MTDataTable.SumD(dtNhapXuatTonExport, "TonCuoi");

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

                gridMain.DataSource = lstNhapXuatTon;

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
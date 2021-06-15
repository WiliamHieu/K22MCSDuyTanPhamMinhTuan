using System;
using System.Data;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using Excel = NetOffice.ExcelApi;

using INVENTORY.Data;

namespace INVENTORY.WinApp.BAOCAO.FORM
{
    public partial class frmHangLuuKho : DevExpress.XtraEditors.XtraForm
    {
        TutorialFormBase ba = new TutorialFormBase();

        private string lstIdNhomVatTu, excelFile, runType = string.Empty;
        private List<CustomRpHangLuuKhoResult> lstHangLuuKho = null;
        private DataTable dtHangLuuKhoExport = null;

        public frmHangLuuKho()
        {
            InitializeComponent();
        }

        private void frmHangLuuKho_Load(object sender, EventArgs e)
        {
            BindCatalog.DmKhoHang_BindDropDown(cboKhoHang);
            ucNhomVatTu.LoadData(true);
        }

        private void frmHangLuuKho_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        public void BindData()
        {
            if (brgWorker.IsBusy)
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
                return;
            }
            if (lstIdNhomVatTu.Length > 8000)
            {
                XtraMessageBox.Show("Danh sách Nhóm vật tư đã chọn vượt quá Số lượng cho phép", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    dtHangLuuKhoExport = oFunction.ToDataTable(lstHangLuuKho);
                    if (dtHangLuuKhoExport == null || dtHangLuuKhoExport.Rows.Count == 0)
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

        private void brgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            runType = e.Argument.ToString();
            if (runType.Equals("View"))
            {
                using (var dbContext = new InventoryDbContext())
                {
                    lstHangLuuKho = dbContext.CustomRpHangLuuKho(cboKhoHang.EditValue.ToString(), lstIdNhomVatTu, Convert.ToInt32(txtNgayTonKho.EditValue)).ToList();
                }
            }
            else if (runType.Equals("Export"))
            {
                Excel.Application objExcel = null;
                try
                {
                    string pathFile = Application.StartupPath + "\\BAOCAO\\EXCEL\\BM_HangLuuKho.xlsx";
                    excelFile = System.IO.Path.GetTempPath() + "\\" + Guid.NewGuid() + ".xlsx";
                    if (!System.IO.File.Exists(excelFile))
                    {
                        System.IO.File.Copy(pathFile, excelFile);
                    }
                    objExcel = new Excel.Application
                    {
                        DisplayAlerts = false
                    };

                    Excel.Workbook workBook = objExcel.Workbooks.Open(excelFile);
                    Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Worksheets[1];
                    workSheet.Name = "HangGiu";

                    workSheet.Range("A1").Value = AppSetting.entChiNhanh.Ten.ToUpper();
                    workSheet.Range("A2").Value = AppSetting.entChiNhanh.DiaChi;
                    workSheet.Range("A3").Value = AppSetting.entChiNhanh.LienHe;
                    workSheet.Range("A6").Value = "(Tên kho: " + cboKhoHang.Text + " )";
                    workSheet.Range("A7").Value = "NGÀY: " + MTDateTime.VnDate(AppSetting.DateTime_GetServer());

                    workSheet.Range("A5").Value = "HÀNG LƯU KHO";

                    int RowIndex = 10; int STT = 1; 
                    foreach (DataRow row in dtHangLuuKhoExport.Rows)
                    {
                        workSheet.Rows[RowIndex + 1].Insert();
                        workSheet.Range("A" + RowIndex).Value = STT;
                        workSheet.Range("B" + RowIndex).Value = row["TenLoaiVatTu"];
                        workSheet.Range("C" + RowIndex).Value = row["QuyCach"];
                        workSheet.Range("D" + RowIndex).Value = row["TenDonViTinh"];
                        workSheet.Range("E" + RowIndex).Value = row["SoLuong"];
                        workSheet.Range("F" + RowIndex).Value = MTDateTime.VnDate(row["NgayTao"]);
                        workSheet.Range("G" + RowIndex).Value = row["NgayTon"];
                        RowIndex++;
                        STT++;
                    }
                    workSheet.Rows[RowIndex].Delete();
                    workSheet.Rows[RowIndex].Delete();

                    workSheet.Range("E" + RowIndex).Value = MTDataTable.SumD(dtHangLuuKhoExport, "SoLuong");

                    workBook.Save();
                    objExcel.Quit();
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

                gridMain.DataSource = lstHangLuuKho;

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
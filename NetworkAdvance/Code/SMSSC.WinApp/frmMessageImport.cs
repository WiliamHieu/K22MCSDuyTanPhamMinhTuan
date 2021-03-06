using System;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections.Generic;

using SMSSC.Entities;
using SMSSC.Data;

namespace SMSSC.WinApp
{
    public partial class frmMessageImport : XtraForm
    {
        private DateTime dtNgayHienTai = DateTime.Now;

        private DataTable dtImportData = null;
        private string saveResult = string.Empty;

        public frmMessageImport()
        {
            InitializeComponent();
        }

        private void frmMessageImport_Load(object sender, EventArgs e)
        {
            cmdImport.Enabled = false;
        }

        private void txtFilePath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (BrgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dGetFile = ExcelFileDialog.ShowDialog();
            if (dGetFile == DialogResult.OK)
            {
                txtFilePath.Text = ExcelFileDialog.FileName;
                cmdImport.Enabled = true;
            }
        }

        private void cmdImport_Click(object sender, EventArgs e)
        {
            if (BrgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string filePath = MTString.Text(txtFilePath.EditValue);
                if (filePath.Length == 0)
                {
                    XtraMessageBox.Show("Chưa chọn Tập tin để Trích dữ liệu", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFilePath.Focus();
                    return;
                }
                dtImportData = oExcelImport.GetDataTable(filePath, out string sMessage);
                if (dtImportData == null)
                {
                    XtraMessageBox.Show(sMessage, AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFilePath.Focus();
                    return;
                }
                if (!dtImportData.Columns.Contains("FromPhoneNumber"))
                {
                    XtraMessageBox.Show("Tập tin không tồn tại cột: FromPhoneNumber", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFilePath.Focus();
                    return;
                }
                if (!dtImportData.Columns.Contains("ToPhoneNumber"))
                {
                    XtraMessageBox.Show("Tập tin không tồn tại cột: ToPhoneNumber", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFilePath.Focus();
                    return;
                }
                if (!dtImportData.Columns.Contains("ContentText"))
                {
                    XtraMessageBox.Show("Tập tin không tồn tại cột: ContentText", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFilePath.Focus();
                    return;
                }
                gridMain.DataSource = dtImportData;
                cmdImport.Enabled = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void cmdTapTinMau_Click(object sender, EventArgs e)
        {
            string sourceFile = Application.StartupPath + "\\Resources\\Message.xlsx";
            string excelFile = System.IO.Path.GetTempPath() + "\\" + Guid.NewGuid() + ".xlsx";
            if (!System.IO.File.Exists(excelFile))
            {
                System.IO.File.Copy(sourceFile, excelFile);
            }
            try
            {
                System.Diagnostics.Process.Start(excelFile);
            }
            catch (Exception)
            {
            }
        }

        private void ToolbarLd_Clicked(object sender, EventArgs e)
        {
            if (BrgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (ToolbarLd.SenderName)
            {
                case CONTROL.ToolbarLd.Action.SaveClose:
                    if (dtImportData == null || dtImportData.Rows.Count == 0)
                    {
                        XtraMessageBox.Show("Không tồn tại dữ liệu Import để tạo tin nhắn", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    ToolbarLd.DisableTool = CONTROL.ToolbarLd.Action.SaveClose;
                    BrgWorker.RunWorkerAsync("Save");
                    break;
                case SMSSC.CONTROL.ToolbarLd.Action.Close:
                    this.Close();
                    break;
            }
        }

        private void MainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (BrgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                {
                    XtraMessageBox.Show("Chưa chọn Danh sách tin nhắn để Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult bCheckDel = XtraMessageBox.Show("Bạn có muốn xóa Danh sách tin nhắn đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (bCheckDel == DialogResult.No) return;

                List<DataRow> lstRowsSelected = oXtraGrid.Get_SelectedRows(gridMainView);
                foreach (DataRow rowDel in lstRowsSelected)
                {
                    rowDel.Delete();
                }
                dtImportData.AcceptChanges();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Có lỗi xảy ra trong quá trình Xóa bản ghi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BrgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                dtNgayHienTai = AppSetting.DateTime_GetServer();

                MessageHistory entMessageHistory = null;
                TList<MessageHistory> lstMessageHistory = new TList<MessageHistory>();
                foreach (DataRow row in dtImportData.Rows)
                {
                    entMessageHistory = new MessageHistory
                    {
                        Id = Guid.NewGuid(),
                        MessageType = 0,
                        FromPhoneNumber = MTString.TextPhoneNumber(row["FromPhoneNumber"]),
                        ToPhoneNumber = MTString.TextPhoneNumber(row["ToPhoneNumber"]),
                        ContentText = MTString.Text(row["ContentText"]),
                        CreatedDate = dtNgayHienTai,
                        EntityState = EntityState.Added
                    };
                    lstMessageHistory.Add(entMessageHistory);
                    dtNgayHienTai = dtNgayHienTai.AddMilliseconds(1);
                }

                DataRepository.MessageHistoryProvider.BulkInsert(lstMessageHistory);

                saveResult = "ThanhCong";
            }
            catch (Exception)
            {
                saveResult = "ThatBai";
            }
        }

        private void BrgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (saveResult.Equals("ThanhCong"))
            {
                XtraMessageBox.Show("Import tin nhắn thành công", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToolbarLd.SenderName = CONTROL.ToolbarLd.Action.Close;
                ToolbarLd_Clicked(sender, e);
            }
            else
            {
                XtraMessageBox.Show("Import tin nhắn đi Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                ToolbarLd.EnableTool = CONTROL.ToolbarLd.Action.SaveClose;
            }
        }
    }
}
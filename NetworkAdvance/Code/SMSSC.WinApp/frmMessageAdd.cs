using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using SMSSC.Data;
using SMSSC.Entities;

namespace SMSSC.WinApp
{
    public partial class frmMessageAdd : XtraForm
    {
        TutorialFormBase ba = new TutorialFormBase();

        private DateTime dtNgayHienTai = DateTime.Now;

        private DataTable dtSourceData = null;

        private string runType, saveResult = string.Empty;

        public frmMessageAdd()
        {
            InitializeComponent();
        }

        private void frmMessageAdd_Load(object sender, EventArgs e)
        {
            dtNgayHienTai = AppSetting.DateTime_GetServer();
            cboTuNgay.EditValue = dtNgayHienTai;
            cboDenNgay.EditValue = dtNgayHienTai;

            BindData.MessageTemplate_BindDropDown(cboTinMau);
            BindData.Brand_BindDropDown(cboHangSanXuat);
            BindData.MobileNetwork_BindDropDown(cboMang);
        }

        private void ToolbarNhap_Clicked(object sender, EventArgs e)
        {
            if (BrgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (ToolbarNhap.SenderName)
            {
                case CONTROL.ToolbarNhap.Action.Add:
                    ToolbarNhap.DisableTool = CONTROL.ToolbarNhap.Action.Add;

                    ba.CreateWaitDialog();
                    ba.SetWaitDialogCaption("Bắt đầu truy vấn dữ liệu");
                    BrgWorker.RunWorkerAsync("Add");
                    break;
                case CONTROL.ToolbarNhap.Action.Delete:
                    DeleteData();
                    break;
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
                case SMSSC.CONTROL.ToolbarLd.Action.SaveClose:
                    if (!SaveRecord_Check()) return;
                    ToolbarLd.DisableTool = SMSSC.CONTROL.ToolbarLd.Action.SaveClose;
                    BrgWorker.RunWorkerAsync();
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
                DeleteData();
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

        private void DeleteData()
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
            dtSourceData.AcceptChanges();
        }

        private bool SaveRecord_Check()
        {
            if (cboTinMau.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn Tin mẫu", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTinMau.Focus();
                return false;
            }
            if (cboTuNgay.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn Ngày bắt đầu", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTuNgay.Focus();
                return false;
            }
            if (cboDenNgay.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn Ngày kết thúc", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDenNgay.Focus();
                return false;
            }
            return true;
        }

        private void BrgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            runType = e.Argument.ToString();
            if (runType.Equals("Add"))
            {
                DateTime fromDate = Convert.ToDateTime(cboTuNgay.EditValue);
                DateTime toDate = Convert.ToDateTime(cboTuNgay.EditValue);

                long fromPrice = Convert.ToInt64(txtGiaDau.EditValue);
                long toPrice = Convert.ToInt64(txtGiaCuoi.EditValue);

                dtSourceData = DataRepository.Provider.ExecuteDataSet("dbo.Custom_MessageHistory_Create", fromDate, toDate, fromPrice, toPrice, cboHangSanXuat.EditValue, cboMang.EditValue).Tables[0];
            }
            else
            {
                try
                {
                    dtNgayHienTai = AppSetting.DateTime_GetServer();

                    MessageHistory entMessageHistory = null;
                    TList<MessageHistory> lstMessageHistory = new TList<MessageHistory>();
                    foreach (DataRow row in dtSourceData.Rows)
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
        }

        private void BrgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (runType.Equals("Add"))
            {
                gridMain.DataSource = dtSourceData;

                ba.SetWaitDialogCaption("Kết thúc truy vấn dữ liệu");
                ba.Exit();
            }
            else
            {
                ba.SetWaitDialogCaption("Kết thúc thay đổi dữ liệu");
                ba.Exit();

                if (saveResult.Equals("ThanhCong"))
                {
                    XtraMessageBox.Show("Tạo mới tin nhắn Thành công", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ToolbarLd.SenderName = CONTROL.ToolbarLd.Action.Close;
                    ToolbarLd_Clicked(sender, e);
                }
                else
                {
                    XtraMessageBox.Show("Tạo mới tin nhắn Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ToolbarLd.EnableTool = SMSSC.CONTROL.ToolbarLd.Action.SaveClose;
                }
            }
        }
    }
}
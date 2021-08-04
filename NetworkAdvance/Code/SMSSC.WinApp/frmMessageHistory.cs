using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;

using SMSSC.Entities;
using SMSSC.Data;

namespace SMSSC.WinApp
{
    public partial class frmMessageHistory : XtraForm
    {
        TutorialFormBase ba = new TutorialFormBase();
        private DateTime dtNgayHienTai = DateTime.Now;

        private int MessageType = 0;
        private DataTable dtMessage = null;

        private string runType = string.Empty;

        public frmMessageHistory()
        {
            InitializeComponent();
        }

        private void frmMessageHistory_Activated(object sender, EventArgs e)
        {
            BindData();
        }

        private void frmMessageHistory_Load(object sender, EventArgs e)
        {
            dtNgayHienTai = AppSetting.DateTime_GetServer();
            Toolbar01.ThoiGian = dtNgayHienTai;
        }

        public void BindData()
        {
            if (BrgWorker.IsBusy)
            {
                XtraMessageBox.Show("Hệ thống đang xử lý, xin chờ trong giây lát", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ba.CreateWaitDialog();
            ba.SetWaitDialogCaption("Bắt đầu truy vấn dữ liệu");
            BrgWorker.RunWorkerAsync("View");
        }

        private void Toolbar01_Clicked(object sender, EventArgs e)
        {
            if (BrgWorker.IsBusy)
            {
                XtraMessageBox.Show("Hệ thống đang xử lý, xin chờ trong giây lát", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            switch (Toolbar01.SenderName)
            {
                case CONTROL.Toolbar01.Action.Send:
                    if (BrgWorker.IsBusy)
                    {
                        XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    ba.CreateWaitDialog();
                    ba.SetWaitDialogCaption("Bắt đầu nhận tin nhắn");
                    BrgWorker.RunWorkerAsync("Send");
                    break;
                case SMSSC.CONTROL.Toolbar01.Action.Delete:
                    if (gridMainView.GetSelectedRows().Length == 0)
                    {
                        XtraMessageBox.Show("Chưa chọn Tin nhắn để Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult bCheckDel = XtraMessageBox.Show("Bạn có muốn xóa những Tin nhắn đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (bCheckDel == DialogResult.No) return;

                    ba.CreateWaitDialog();
                    ba.SetWaitDialogCaption("Bắt đầu thay đổi dữ liệu");
                    BrgWorker.RunWorkerAsync("Delete");
                    break;
                case CONTROL.Toolbar01.Action.Refresh:
                    BindData();
                    break;
                case CONTROL.Toolbar01.Action.Export:
                    oXtraGrid.ExportXLSX(gridMainView, "MessageHistory");
                    break;
                case CONTROL.Toolbar01.Action.Print:
                    oXtraGrid.Print(gridMain);
                    break;
                case CONTROL.Toolbar01.Action.Close:
                    this.Close();
                    break;
            }
        }

        private void MainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.Equals("mnuGuiTin"))
            {
                if (gridMainView.GetSelectedRows().Length == 0)
                {
                    XtraMessageBox.Show("Chưa chọn Tin nhắn để Gửi lại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ba.CreateWaitDialog();
                ba.SetWaitDialogCaption("Bắt đầu gửi tin dữ liệu");
                BrgWorker.RunWorkerAsync("Send");
            }
            else if (e.ClickedItem.Name.Equals("mnuXoa"))
            {
                if (gridMainView.GetSelectedRows().Length == 0)
                {
                    XtraMessageBox.Show("Chưa chọn Tin nhắn để Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ba.CreateWaitDialog();
                ba.SetWaitDialogCaption("Bắt đầu xóa dữ liệu");
                BrgWorker.RunWorkerAsync("Delete");
            }
        }

        private void TabMain_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (BrgWorker.IsBusy)
            {
                XtraMessageBox.Show("Hệ thống đang xử lý, xin chờ trong giây lát", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void TabMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            XtraTabPage TabSelected = TabMain.SelectedTabPage;
            if (!TabSelected.Controls.Contains(gridMain))
                TabSelected.Controls.Add(gridMain);
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

        private void BrgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            runType = e.Argument.ToString();
            MessageType = Convert.ToInt32(TabMain.SelectedTabPage.Name.Replace("Tab_", ""));
            if (runType.Equals("View"))
            {
                DateTime fromDate = Toolbar01.TuNgay;
                fromDate = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day, 0, 0, 0, 0);
                DateTime toDate = Toolbar01.DenNgay;
                toDate = new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59, 999);
                dtMessage = DataRepository.Provider.ExecuteDataSet("dbo.Custom_MessageHistory_Get_List", MessageType, fromDate, toDate).Tables[0];
            }
            else if (runType.Equals("Delete"))
            {
                List<DataRow> lstRowsSelected = oXtraGrid.Get_SelectedRows(gridMainView);
                foreach (DataRow row in lstRowsSelected)
                {
                    Guid MessageHistoryId = new Guid(row["Id"].ToString());
                    DataRepository.MessageHistoryProvider.Delete(MessageHistoryId);
                }
            }
            else if (runType.Equals("Send"))
            {
                List<DataRow> lstRowsSelected = oXtraGrid.Get_SelectedRows(gridMainView);
                foreach (DataRow row in lstRowsSelected)
                {
                    Guid MessageHistoryId = new Guid(row["Id"].ToString());
                    MessageHistory entMessageHistory = DataRepository.MessageHistoryProvider.GetById(MessageHistoryId);
                    entMessageHistory.Status = 0;
                    entMessageHistory.MessageType = 0;
                    entMessageHistory.EntityState = EntityState.Changed;
                    entMessageHistory.OriginalId = entMessageHistory.Id;
                    DataRepository.MessageHistoryProvider.Update(entMessageHistory);
                }
            }
        }

        private void BrgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (runType.Equals("View"))
            {
                ba.SetWaitDialogCaption("Kết thúc truy vấn và Bắt đầu hiển thị dữ liệu");

                gridMain.DataSource = dtMessage;

                if (MessageType == 0)
                {
                    Toolbar01.EnableTool = CONTROL.Toolbar01.Action.Send;
                    Toolbar01.EnableTool = CONTROL.Toolbar01.Action.Delete;

                    gridMainView.Columns["SentDate"].Visible = false;
                    gridMainView.Columns["SentDate"].VisibleIndex = -1;

                    gridMainView.Columns["StatusName"].Visible = false;
                    gridMainView.Columns["StatusName"].VisibleIndex = -1;
                }
                else if (MessageType == 1)
                {
                    Toolbar01.DisableTool = CONTROL.Toolbar01.Action.Send;
                    Toolbar01.DisableTool = CONTROL.Toolbar01.Action.Delete;

                    gridMainView.Columns["StatusName"].Visible = true;
                    gridMainView.Columns["StatusName"].VisibleIndex = 4;

                    gridMainView.Columns["SentDate"].Visible = true;
                    gridMainView.Columns["SentDate"].VisibleIndex = 3;
                }
                else if (MessageType == 2)
                {
                    Toolbar01.DisableTool = CONTROL.Toolbar01.Action.Send;
                    Toolbar01.EnableTool = CONTROL.Toolbar01.Action.Delete;

                    gridMainView.Columns["StatusName"].Visible = false;
                    gridMainView.Columns["StatusName"].VisibleIndex = -1;

                    gridMainView.Columns["SentDate"].Visible = false;
                    gridMainView.Columns["SentDate"].VisibleIndex = -1;
                }
                ba.SetWaitDialogCaption("Kết thúc hiển thị dữ liệu");
                ba.Exit();
            }
            else if (runType.Equals("Delete"))
            {
                ba.SetWaitDialogCaption("Kết thúc thay đổi dữ liệu");
                ba.Exit();

                BindData();
            }
            else if (runType.Equals("Send"))
            {
                ba.SetWaitDialogCaption("Kết thúc thay đổi dữ liệu");
                ba.Exit();

                BindData();
            }
        }
    }
}
using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using SMSSC.Entities;
using SMSSC.Data;

namespace SMSSC.WinApp
{
    public partial class frmMessageTemplate : XtraForm
    {
        public frmMessageTemplate()
        {
            InitializeComponent();
        }

        private void frmMessageTemplate_Load(object sender, EventArgs e)
        {
            gridMain_cboTrangThai.DataSource = oInitData.TrangThai_InitTable();
            BindData();
        }

        public void BindData()
        {
            var lstMessageTemplate = DataRepository.MessageTemplateProvider.GetPaged(Toolbar.TrangThai == 0 ? "Status<>-1" : "Status=-1", "CreatedDate DESC");
            gridMain.DataSource = lstMessageTemplate;
        }

        private void EditData()
        {
            MessageTemplate entMessageTemplate = (MessageTemplate)gridMainView.GetRow(gridMainView.FocusedRowHandle);
            frmMessageTemplateAdd frm = new frmMessageTemplateAdd(this);
            frm.entMessageTemplateOld = entMessageTemplate;
            frm.ShowDialog();
        }

        private void Toolbar_Clicked(object sender, EventArgs e)
        {
            switch (Toolbar.SenderName)
            {
                case CONTROL.Toolbar.Action.Add:
                    frmMessageTemplateAdd frm = new frmMessageTemplateAdd(this);
                    frm.ShowDialog();
                    break;
                case SMSSC.CONTROL.Toolbar.Action.Edit:
                    if(gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                    {
                        XtraMessageBox.Show("Chưa chọn Tin nhắn mẫu để Sửa đổi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    EditData();
                    break;
                case CONTROL.Toolbar.Action.Delete:
                    if (gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                    {
                        XtraMessageBox.Show("Chưa chọn Tin nhắn mẫu để Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DialogResult drResult = XtraMessageBox.Show("Bạn có muốn xóa những Tin nhắn mẫu đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drResult == DialogResult.No) return;

                    var entMessageTemplate = gridMainView.GetRow(gridMainView.FocusedRowHandle) as MessageTemplate;
                    try
                    {
                        DataRepository.MessageTemplateProvider.Delete(entMessageTemplate);

                        BindData();
                    }
                    catch (Exception)
                    {
                        XtraMessageBox.Show("Xóa Tin nhắn mẫu Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case CONTROL.Toolbar.Action.Hide:
                    if (gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                    {
                        XtraMessageBox.Show("Chưa chọn Tin nhắn mẫu để Ẩn", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DialogResult drCheckHide = XtraMessageBox.Show("Bạn có muốn ẩn Tin nhắn mẫu đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drCheckHide == DialogResult.No) return;

                    try
                    {
                        var entMessageTemplateHide = gridMainView.GetRow(gridMainView.FocusedRowHandle) as MessageTemplate;
                        entMessageTemplateHide.Status = -1;
                        entMessageTemplateHide.EntityState = EntityState.Changed;
                        DataRepository.MessageTemplateProvider.Update(entMessageTemplateHide);

                        BindData();
                    }
                    catch (Exception)
                    {
                        XtraMessageBox.Show("Ẩn Tin nhắn mẫu Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case CONTROL.Toolbar.Action.Refresh:
                    BindData();
                    break;
                case CONTROL.Toolbar.Action.Export:
                    oXtraGrid.ExportXLSX(gridMainView, "MessageTemplate");
                    break;
                case CONTROL.Toolbar.Action.Print:
                    oXtraGrid.Print(gridMain);
                    break;
                case CONTROL.Toolbar.Action.Close:
                    this.Close();
                    break;
            }
        }

        private void Toolbar_Changed(object sender, EventArgs e)
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
    }
}
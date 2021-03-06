using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using SMSSC.Entities;
using SMSSC.Data;

namespace SMSSC.WinApp
{
    public partial class frmMessageTemplateAdd : XtraForm
    {
        public frmMessageTemplate frmParent = null;

        public MessageTemplate entMessageTemplateOld = null;

        public frmMessageTemplateAdd(frmMessageTemplate frm)
        {
            InitializeComponent();
            frmParent = frm;
        }

        private void frmMessageTemplateAdd_Load(object sender, EventArgs e)
        {
            if (entMessageTemplateOld != null)
            {
                txtTitle.EditValue = entMessageTemplateOld.Title;
                txtContentText.EditValue = entMessageTemplateOld.ContentText;
                txtNote.EditValue = entMessageTemplateOld.Note;
                chkStatus.Items[0].CheckState = MTCheckbox.State(entMessageTemplateOld.Status);
            }
        }

        private void chkStatus_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            e.Appearance.BackColor = System.Drawing.Color.White;
            e.Appearance.ForeColor = System.Drawing.Color.Black;
        }

        private void ToolbarDm_Clicked(object sender, EventArgs e)
        {
            switch (ToolbarDm.SenderName)
            {
                case SMSSC.CONTROL.ToolbarDm.Action.Save:
                    if (!SaveRecord()) return;
                    break;
                case SMSSC.CONTROL.ToolbarDm.Action.SaveAdd:
                    if (!SaveRecord()) return;
                    break;
                case SMSSC.CONTROL.ToolbarDm.Action.SaveClose:
                    if (!SaveRecord()) return;
                    this.Close();
                    break;
                case SMSSC.CONTROL.ToolbarDm.Action.Close:
                    this.Close();
                    break;
            }
        }

        private void txtContentText_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                txtCountLetter.Text = e.NewValue.ToString().Length + " ký tự";
            }
            catch (Exception)
            {
            }
        }

        private bool SaveRecord()
        {
            string title = MTString.TextClean(txtTitle.EditValue);
            if (title.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Tiêu đề", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }
            string contentText = MTString.TextClean(txtContentText.EditValue);
            if (contentText.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Nội dung", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContentText.Focus();
                return false;
            }
            if ((entMessageTemplateOld != null && entMessageTemplateOld.Title.ToLower() != title.ToLower()) || (entMessageTemplateOld == null))
            {
                string whereClause = string.Format("Title=N'{0}'", title);
                if (entMessageTemplateOld != null) whereClause += " AND Id<>" + entMessageTemplateOld.Id;
                if (DataRepository.Provider.MessageTemplateProvider.GetTotalItems(whereClause) > 0)
                {
                    XtraMessageBox.Show("Tiêu đề tin đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTitle.Focus();
                    return false;
                }
            }

            bool updateStatus = false;
            TransactionManager transactionManager = null;
            try
            {
                var entMessageTemplate = new MessageTemplate
                {
                    Title = title,
                    ContentText = MTString.TextRemoveVn(contentText),
                    Status = MTCheckbox.Int32Value(chkStatus.Items[0].CheckState),
                    Note = MTString.TextClean(txtNote.EditValue)
                };
                if (entMessageTemplateOld == null)
                {
                    entMessageTemplate.CreatedDate = AppSetting.DateTime_GetServer();
                    DataRepository.MessageTemplateProvider.Insert(transactionManager, entMessageTemplate);
                }
                else
                {
                    entMessageTemplate.Id = entMessageTemplateOld.Id;
                    entMessageTemplate.CreatedDate = entMessageTemplateOld.CreatedDate;
                    entMessageTemplate.EntityState = EntityState.Changed;
                    DataRepository.MessageTemplateProvider.Update(transactionManager, entMessageTemplate);
                }

                updateStatus = true;
            }
            catch (Exception)
            {
                updateStatus = false;
            }

            if (updateStatus)
            {
                frmParent.BindData();

                if (ToolbarDm.SenderName == SMSSC.CONTROL.ToolbarDm.Action.Save)
                {
                    ToolbarDm.DisableTool = SMSSC.CONTROL.ToolbarDm.Action.Save;
                }
                else if (ToolbarDm.SenderName == SMSSC.CONTROL.ToolbarDm.Action.SaveAdd)
                {
                    entMessageTemplateOld = null;

                    txtTitle.EditValue = null;
                    txtContentText.EditValue = null;
                    txtCountLetter.EditValue = null;
                    txtNote.EditValue = null;
                    chkStatus.Items[0].CheckState = CheckState.Checked;
                    txtTitle.Focus();
                }
                return true;
            }
            else
            {
                XtraMessageBox.Show("Cập nhật Tin nhắn mẫu Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
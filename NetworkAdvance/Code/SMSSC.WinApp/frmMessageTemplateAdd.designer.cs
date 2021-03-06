namespace SMSSC.WinApp
{
    partial class frmMessageTemplateAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.chkStatus = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.txtContentText = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCountLetter = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNote = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BrgWorker = new System.ComponentModel.BackgroundWorker();
            this.ToolbarDm = new SMSSC.CONTROL.ToolbarDm();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContentText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountLetter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.chkStatus);
            this.groupControl3.Controls.Add(this.txtContentText);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.txtCountLetter);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.txtNote);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.txtTitle);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(404, 247);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Thông tin";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 189);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "Trạng thái";
            // 
            // chkStatus
            // 
            this.chkStatus.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkStatus.Appearance.Options.UseForeColor = true;
            this.chkStatus.CheckOnClick = true;
            this.chkStatus.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Standard;
            this.chkStatus.HorizontalScrollbar = true;
            this.chkStatus.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(true, "Đánh dấu nếu còn sử dụng", System.Windows.Forms.CheckState.Checked)});
            this.chkStatus.Location = new System.Drawing.Point(61, 186);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(300, 20);
            this.chkStatus.TabIndex = 3;
            this.chkStatus.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(this.chkStatus_DrawItem);
            // 
            // txtContentText
            // 
            this.txtContentText.Location = new System.Drawing.Point(61, 58);
            this.txtContentText.Name = "txtContentText";
            this.txtContentText.Properties.MaxLength = 165;
            this.txtContentText.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContentText.Size = new System.Drawing.Size(300, 96);
            this.txtContentText.TabIndex = 1;
            this.txtContentText.UseOptimizedRendering = true;
            this.txtContentText.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtContentText_EditValueChanging);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Nội dung";
            // 
            // txtCountLetter
            // 
            this.txtCountLetter.EditValue = "";
            this.txtCountLetter.EnterMoveNextControl = true;
            this.txtCountLetter.Location = new System.Drawing.Point(61, 160);
            this.txtCountLetter.Name = "txtCountLetter";
            this.txtCountLetter.Properties.MaxLength = 100;
            this.txtCountLetter.Properties.ReadOnly = true;
            this.txtCountLetter.Size = new System.Drawing.Size(300, 20);
            this.txtCountLetter.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 163);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Số ký tự";
            // 
            // txtNote
            // 
            this.txtNote.EditValue = "";
            this.txtNote.EnterMoveNextControl = true;
            this.txtNote.Location = new System.Drawing.Point(61, 212);
            this.txtNote.Name = "txtNote";
            this.txtNote.Properties.MaxLength = 100;
            this.txtNote.Size = new System.Drawing.Size(300, 20);
            this.txtNote.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 215);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Chú thích";
            // 
            // txtTitle
            // 
            this.txtTitle.EditValue = "";
            this.txtTitle.EnterMoveNextControl = true;
            this.txtTitle.Location = new System.Drawing.Point(61, 32);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Properties.MaxLength = 100;
            this.txtTitle.Size = new System.Drawing.Size(300, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Tiêu đề";
            // 
            // ToolbarDm
            // 
            this.ToolbarDm.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarDm.Appearance.Options.UseBackColor = true;
            this.ToolbarDm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolbarDm.Location = new System.Drawing.Point(0, 247);
            this.ToolbarDm.Name = "ToolbarDm";
            this.ToolbarDm.SenderName = SMSSC.CONTROL.ToolbarDm.Action.None;
            this.ToolbarDm.Size = new System.Drawing.Size(404, 28);
            this.ToolbarDm.TabIndex = 1;
            this.ToolbarDm.Clicked += new System.EventHandler(this.ToolbarDm_Clicked);
            // 
            // frmMessageTemplateAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 275);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.ToolbarDm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMessageTemplateAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật Tin nhắn mẫu";
            this.Load += new System.EventHandler(this.frmMessageTemplateAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContentText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountLetter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.ComponentModel.BackgroundWorker BrgWorker;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit txtContentText;
        private SMSSC.CONTROL.ToolbarDm ToolbarDm;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckedListBoxControl chkStatus;
        private DevExpress.XtraEditors.TextEdit txtCountLetter;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNote;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
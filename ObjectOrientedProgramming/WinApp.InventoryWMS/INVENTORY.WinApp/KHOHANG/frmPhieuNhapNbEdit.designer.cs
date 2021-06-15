namespace INVENTORY.WinApp.KHOHANG
{
    partial class frmPhieuNhapNbEdit
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
            this.brgWorker = new System.ComponentModel.BackgroundWorker();
            this.ToolbarLd = new INVENTORY.CONTROL.ToolbarLd();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboKhoNhan = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoNhan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // brgWorker
            // 
            this.brgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.brgWorker_DoWork);
            this.brgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.brgWorker_RunWorkerCompleted);
            // 
            // ToolbarLd
            // 
            this.ToolbarLd.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarLd.Appearance.Options.UseBackColor = true;
            this.ToolbarLd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolbarLd.Location = new System.Drawing.Point(0, 61);
            this.ToolbarLd.Name = "ToolbarLd";
            this.ToolbarLd.SenderName = INVENTORY.CONTROL.ToolbarLd.Action.None;
            this.ToolbarLd.Size = new System.Drawing.Size(384, 28);
            this.ToolbarLd.TabIndex = 1;
            this.ToolbarLd.Clicked += new System.EventHandler(this.ToolbarLd_Clicked);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cboKhoNhan);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(384, 61);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // cboKhoNhan
            // 
            this.cboKhoNhan.Location = new System.Drawing.Point(70, 30);
            this.cboKhoNhan.Name = "cboKhoNhan";
            this.cboKhoNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhoNhan.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MatHang", "MatHang", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.cboKhoNhan.Properties.DropDownRows = 10;
            this.cboKhoNhan.Properties.NullText = " -- Kho nhận --";
            this.cboKhoNhan.Properties.PopupFormMinSize = new System.Drawing.Size(263, 0);
            this.cboKhoNhan.Properties.PopupWidth = 263;
            this.cboKhoNhan.Properties.ShowFooter = false;
            this.cboKhoNhan.Properties.ShowHeader = false;
            this.cboKhoNhan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboKhoNhan.Size = new System.Drawing.Size(280, 20);
            this.cboKhoNhan.TabIndex = 0;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(19, 33);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(45, 13);
            this.labelControl12.TabIndex = 27;
            this.labelControl12.Text = "Kho nhận";
            // 
            // frmPhieuNhapNbEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 89);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ToolbarLd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhieuNhapNbEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thay đổi Kho nhận";
            this.Load += new System.EventHandler(this.frmPhieuNhapNbChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoNhan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker brgWorker;
        private INVENTORY.CONTROL.ToolbarLd ToolbarLd;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit cboKhoNhan;
        private DevExpress.XtraEditors.LabelControl labelControl12;
    }
}
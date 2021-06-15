namespace INVENTORY.WinApp.HETHONG
{
    partial class frmNguoiDungEdit
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
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTruyCap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.ToolbarLd = new INVENTORY.CONTROL.ToolbarLd();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTruyCap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.EditValue = "";
            this.txtTen.EnterMoveNextControl = true;
            this.txtTen.Location = new System.Drawing.Point(73, 30);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.MaxLength = 50;
            this.txtTen.Size = new System.Drawing.Size(282, 20);
            this.txtTen.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtMatKhau);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Controls.Add(this.txtTenTruyCap);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(397, 114);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 33);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Họ tên (*)";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.EditValue = "";
            this.txtMatKhau.EnterMoveNextControl = true;
            this.txtMatKhau.Location = new System.Drawing.Point(73, 82);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.MaxLength = 50;
            this.txtMatKhau.Size = new System.Drawing.Size(282, 20);
            this.txtMatKhau.TabIndex = 2;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(21, 85);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(46, 13);
            this.labelControl16.TabIndex = 6;
            this.labelControl16.Text = "Password";
            // 
            // txtTenTruyCap
            // 
            this.txtTenTruyCap.EditValue = "";
            this.txtTenTruyCap.EnterMoveNextControl = true;
            this.txtTenTruyCap.Location = new System.Drawing.Point(73, 56);
            this.txtTenTruyCap.Name = "txtTenTruyCap";
            this.txtTenTruyCap.Properties.MaxLength = 50;
            this.txtTenTruyCap.Properties.ReadOnly = true;
            this.txtTenTruyCap.Size = new System.Drawing.Size(282, 20);
            this.txtTenTruyCap.TabIndex = 1;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(19, 59);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(48, 13);
            this.labelControl14.TabIndex = 6;
            this.labelControl14.Text = "Username";
            // 
            // ToolbarLd
            // 
            this.ToolbarLd.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarLd.Appearance.Options.UseBackColor = true;
            this.ToolbarLd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolbarLd.Location = new System.Drawing.Point(0, 114);
            this.ToolbarLd.Name = "ToolbarLd";
            this.ToolbarLd.SenderName = INVENTORY.CONTROL.ToolbarLd.Action.None;
            this.ToolbarLd.Size = new System.Drawing.Size(397, 28);
            this.ToolbarLd.TabIndex = 1;
            this.ToolbarLd.Clicked += new System.EventHandler(this.ToolbarLd_Clicked);
            // 
            // frmNguoiDungEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 142);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ToolbarLd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNguoiDungEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật Người dùng";
            this.Load += new System.EventHandler(this.frmNguoiDungEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTruyCap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTenTruyCap;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private INVENTORY.CONTROL.ToolbarLd ToolbarLd;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
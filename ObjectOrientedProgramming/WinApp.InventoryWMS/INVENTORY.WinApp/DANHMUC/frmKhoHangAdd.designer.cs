namespace INVENTORY.WinApp.DANHMUC
{
    partial class frmKhoHangAdd
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboChiNhanh = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtThuTu = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtChuThich = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ToolbarLd = new INVENTORY.CONTROL.ToolbarLd();
            this.chkTrangThai = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboChiNhanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThuTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkTrangThai);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cboChiNhanh);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtThuTu);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtChuThich);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(384, 166);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Chi nhánh";
            // 
            // cboChiNhanh
            // 
            this.cboChiNhanh.EnterMoveNextControl = true;
            this.cboChiNhanh.Location = new System.Drawing.Point(67, 30);
            this.cboChiNhanh.Name = "cboChiNhanh";
            this.cboChiNhanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboChiNhanh.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên")});
            this.cboChiNhanh.Properties.NullText = "-- Chi nhánh --";
            this.cboChiNhanh.Properties.PopupFormMinSize = new System.Drawing.Size(263, 0);
            this.cboChiNhanh.Properties.PopupWidth = 263;
            this.cboChiNhanh.Properties.ShowFooter = false;
            this.cboChiNhanh.Properties.ShowHeader = false;
            this.cboChiNhanh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboChiNhanh.Size = new System.Drawing.Size(280, 20);
            this.cboChiNhanh.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 137);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Trạng thái";
            // 
            // txtThuTu
            // 
            this.txtThuTu.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtThuTu.EnterMoveNextControl = true;
            this.txtThuTu.Location = new System.Drawing.Point(67, 82);
            this.txtThuTu.Name = "txtThuTu";
            this.txtThuTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtThuTu.Properties.IsFloatValue = false;
            this.txtThuTu.Properties.Mask.EditMask = "N00";
            this.txtThuTu.Properties.MaxValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.txtThuTu.Size = new System.Drawing.Size(280, 20);
            this.txtThuTu.TabIndex = 2;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(28, 85);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 13);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "Thứ tự";
            // 
            // txtChuThich
            // 
            this.txtChuThich.EditValue = "";
            this.txtChuThich.EnterMoveNextControl = true;
            this.txtChuThich.Location = new System.Drawing.Point(67, 108);
            this.txtChuThich.Name = "txtChuThich";
            this.txtChuThich.Properties.MaxLength = 300;
            this.txtChuThich.Size = new System.Drawing.Size(280, 20);
            this.txtChuThich.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.EnterMoveNextControl = true;
            this.txtTen.Location = new System.Drawing.Point(67, 56);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(280, 20);
            this.txtTen.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Chú thích";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên (*)";
            // 
            // ToolbarLd
            // 
            this.ToolbarLd.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarLd.Appearance.Options.UseBackColor = true;
            this.ToolbarLd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolbarLd.Location = new System.Drawing.Point(0, 166);
            this.ToolbarLd.Name = "ToolbarLd";
            this.ToolbarLd.SenderName = INVENTORY.CONTROL.ToolbarLd.Action.None;
            this.ToolbarLd.Size = new System.Drawing.Size(384, 28);
            this.ToolbarLd.TabIndex = 1;
            this.ToolbarLd.Clicked += new System.EventHandler(this.ToolbarLd_Clicked);
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.EditValue = true;
            this.chkTrangThai.EnterMoveNextControl = true;
            this.chkTrangThai.Location = new System.Drawing.Point(67, 134);
            this.chkTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.chkTrangThai.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(222)))));
            this.chkTrangThai.Properties.Appearance.Options.UseBackColor = true;
            this.chkTrangThai.Properties.Appearance.Options.UseBorderColor = true;
            this.chkTrangThai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.chkTrangThai.Properties.Caption = "Đánh dấu nếu còn sử dụng";
            this.chkTrangThai.Size = new System.Drawing.Size(280, 21);
            this.chkTrangThai.TabIndex = 4;
            // 
            // frmKhoHangAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 194);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ToolbarLd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKhoHangAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật Kho hàng";
            this.Load += new System.EventHandler(this.frmKhoHangAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboChiNhanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThuTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThai.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtChuThich;
        private DevExpress.XtraEditors.SpinEdit txtThuTu;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private INVENTORY.CONTROL.ToolbarLd ToolbarLd;
        private DevExpress.XtraEditors.LookUpEdit cboChiNhanh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chkTrangThai;
    }
}
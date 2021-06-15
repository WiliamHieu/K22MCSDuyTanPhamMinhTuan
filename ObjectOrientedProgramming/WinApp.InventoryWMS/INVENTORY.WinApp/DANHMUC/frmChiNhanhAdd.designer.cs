namespace INVENTORY.WinApp.DANHMUC
{
    partial class frmChiNhanhAdd
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
            this.ToolbarDm = new INVENTORY.CONTROL.ToolbarDm();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtChuThich = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtThuTu = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenVietTat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.chkTrangThai = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtLienHe = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThuTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenVietTat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLienHe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolbarDm
            // 
            this.ToolbarDm.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarDm.Appearance.Options.UseBackColor = true;
            this.ToolbarDm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolbarDm.Location = new System.Drawing.Point(0, 219);
            this.ToolbarDm.Name = "ToolbarDm";
            this.ToolbarDm.SenderName = INVENTORY.CONTROL.ToolbarDm.Action.None;
            this.ToolbarDm.Size = new System.Drawing.Size(384, 28);
            this.ToolbarDm.TabIndex = 1;
            this.ToolbarDm.Clicked += new System.EventHandler(this.ToolbarDm_Clicked);
            // 
            // txtTen
            // 
            this.txtTen.EditValue = "";
            this.txtTen.EnterMoveNextControl = true;
            this.txtTen.Location = new System.Drawing.Point(67, 30);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.MaxLength = 100;
            this.txtTen.Size = new System.Drawing.Size(280, 20);
            this.txtTen.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 85);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Địa chỉ (*)";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.EditValue = "";
            this.txtDiaChi.EnterMoveNextControl = true;
            this.txtDiaChi.Location = new System.Drawing.Point(67, 82);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.MaxLength = 200;
            this.txtDiaChi.Size = new System.Drawing.Size(280, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 163);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Chú thích";
            // 
            // txtChuThich
            // 
            this.txtChuThich.EditValue = "";
            this.txtChuThich.EnterMoveNextControl = true;
            this.txtChuThich.Location = new System.Drawing.Point(67, 160);
            this.txtChuThich.Name = "txtChuThich";
            this.txtChuThich.Properties.MaxLength = 300;
            this.txtChuThich.Size = new System.Drawing.Size(280, 20);
            this.txtChuThich.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Tên (*)";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(28, 137);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(33, 13);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "Thứ tự";
            // 
            // txtThuTu
            // 
            this.txtThuTu.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtThuTu.EnterMoveNextControl = true;
            this.txtThuTu.Location = new System.Drawing.Point(67, 134);
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
            this.txtThuTu.TabIndex = 4;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(9, 59);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(52, 13);
            this.labelControl11.TabIndex = 25;
            this.labelControl11.Text = "Viết tắt (*)";
            // 
            // txtTenVietTat
            // 
            this.txtTenVietTat.EnterMoveNextControl = true;
            this.txtTenVietTat.Location = new System.Drawing.Point(67, 56);
            this.txtTenVietTat.Name = "txtTenVietTat";
            this.txtTenVietTat.Properties.MaxLength = 20;
            this.txtTenVietTat.Size = new System.Drawing.Size(280, 20);
            this.txtTenVietTat.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 189);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Trạng thái";
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.EditValue = true;
            this.chkTrangThai.EnterMoveNextControl = true;
            this.chkTrangThai.Location = new System.Drawing.Point(67, 186);
            this.chkTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.chkTrangThai.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(222)))));
            this.chkTrangThai.Properties.Appearance.Options.UseBackColor = true;
            this.chkTrangThai.Properties.Appearance.Options.UseBorderColor = true;
            this.chkTrangThai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.chkTrangThai.Properties.Caption = "Đánh dấu nếu còn sử dụng";
            this.chkTrangThai.Size = new System.Drawing.Size(280, 21);
            this.chkTrangThai.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkTrangThai);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtTenVietTat);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.txtThuTu);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtChuThich);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.txtLienHe);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(384, 219);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 111);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Liên hệ (*)";
            // 
            // txtLienHe
            // 
            this.txtLienHe.EditValue = "";
            this.txtLienHe.EnterMoveNextControl = true;
            this.txtLienHe.Location = new System.Drawing.Point(67, 108);
            this.txtLienHe.Name = "txtLienHe";
            this.txtLienHe.Properties.MaxLength = 200;
            this.txtLienHe.Size = new System.Drawing.Size(280, 20);
            this.txtLienHe.TabIndex = 3;
            // 
            // frmChiNhanhAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 247);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ToolbarDm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChiNhanhAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật Chi nhánh";
            this.Load += new System.EventHandler(this.frmChiNhanhAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThuTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenVietTat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLienHe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private INVENTORY.CONTROL.ToolbarDm ToolbarDm;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtChuThich;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SpinEdit txtThuTu;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtTenVietTat;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit chkTrangThai;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtLienHe;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
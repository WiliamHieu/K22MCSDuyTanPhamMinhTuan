namespace INVENTORY.WinApp.DANHMUC
{
    partial class frmBoPhanAdd
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtThuTu = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtChuThich = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ToolbarDm = new INVENTORY.CONTROL.ToolbarDm();
            this.chkTrangThai = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThuTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkTrangThai);
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
            this.groupControl1.Size = new System.Drawing.Size(384, 140);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 111);
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
            this.txtThuTu.Location = new System.Drawing.Point(67, 56);
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
            this.txtThuTu.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(28, 59);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 13);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "Thứ tự";
            // 
            // txtChuThich
            // 
            this.txtChuThich.EditValue = "";
            this.txtChuThich.EnterMoveNextControl = true;
            this.txtChuThich.Location = new System.Drawing.Point(67, 82);
            this.txtChuThich.Name = "txtChuThich";
            this.txtChuThich.Properties.MaxLength = 300;
            this.txtChuThich.Size = new System.Drawing.Size(280, 20);
            this.txtChuThich.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.EnterMoveNextControl = true;
            this.txtTen.Location = new System.Drawing.Point(67, 30);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(280, 20);
            this.txtTen.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 85);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Chú thích";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên (*)";
            // 
            // ToolbarDm
            // 
            this.ToolbarDm.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarDm.Appearance.Options.UseBackColor = true;
            this.ToolbarDm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolbarDm.Location = new System.Drawing.Point(0, 140);
            this.ToolbarDm.Name = "ToolbarDm";
            this.ToolbarDm.SenderName = INVENTORY.CONTROL.ToolbarDm.Action.None;
            this.ToolbarDm.Size = new System.Drawing.Size(384, 28);
            this.ToolbarDm.TabIndex = 1;
            this.ToolbarDm.Clicked += new System.EventHandler(this.ToolbarDm_Clicked);
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.EditValue = true;
            this.chkTrangThai.EnterMoveNextControl = true;
            this.chkTrangThai.Location = new System.Drawing.Point(67, 108);
            this.chkTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.chkTrangThai.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(222)))));
            this.chkTrangThai.Properties.Appearance.Options.UseBackColor = true;
            this.chkTrangThai.Properties.Appearance.Options.UseBorderColor = true;
            this.chkTrangThai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.chkTrangThai.Properties.Caption = "Đánh dấu nếu còn sử dụng";
            this.chkTrangThai.Size = new System.Drawing.Size(280, 21);
            this.chkTrangThai.TabIndex = 3;
            // 
            // frmBoPhanAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 168);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ToolbarDm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBoPhanAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật Bộ phận";
            this.Load += new System.EventHandler(this.frmBoPhanAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
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
        private INVENTORY.CONTROL.ToolbarDm ToolbarDm;
        private DevExpress.XtraEditors.CheckEdit chkTrangThai;
    }
}
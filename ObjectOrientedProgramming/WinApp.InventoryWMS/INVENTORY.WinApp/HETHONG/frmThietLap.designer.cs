namespace INVENTORY.WinApp.HETHONG
{
    partial class frmThietLap
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
            this.ImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenPhanMem = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkXoaQuaNgay = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.cboKieuKhoa = new DevExpress.XtraEditors.LookUpEdit();
            this.spSoGioKhoa = new DevExpress.XtraEditors.SpinEdit();
            this.spSoNgayDuLieu = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ToolbarLd = new INVENTORY.CONTROL.ToolbarLd();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPhanMem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkXoaQuaNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKieuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoGioKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoNgayDuLieu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 33);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Phần mềm";
            // 
            // txtTenPhanMem
            // 
            this.txtTenPhanMem.EditValue = "";
            this.txtTenPhanMem.EnterMoveNextControl = true;
            this.txtTenPhanMem.Location = new System.Drawing.Point(73, 30);
            this.txtTenPhanMem.Name = "txtTenPhanMem";
            this.txtTenPhanMem.Properties.MaxLength = 100;
            this.txtTenPhanMem.Size = new System.Drawing.Size(280, 20);
            this.txtTenPhanMem.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkXoaQuaNgay);
            this.groupControl1.Controls.Add(this.cboKieuKhoa);
            this.groupControl1.Controls.Add(this.spSoGioKhoa);
            this.groupControl1.Controls.Add(this.spSoNgayDuLieu);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtTenPhanMem);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(384, 139);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // chkXoaQuaNgay
            // 
            this.chkXoaQuaNgay.CheckOnClick = true;
            this.chkXoaQuaNgay.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Standard;
            this.chkXoaQuaNgay.HorizontalScrollbar = true;
            this.chkXoaQuaNgay.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(true, "Đánh dấu nếu cho phép xóa")});
            this.chkXoaQuaNgay.Location = new System.Drawing.Point(73, 108);
            this.chkXoaQuaNgay.Name = "chkXoaQuaNgay";
            this.chkXoaQuaNgay.Size = new System.Drawing.Size(280, 20);
            this.chkXoaQuaNgay.TabIndex = 5;
            // 
            // cboKieuKhoa
            // 
            this.cboKieuKhoa.Location = new System.Drawing.Point(73, 82);
            this.cboKieuKhoa.Name = "cboKieuKhoa";
            this.cboKieuKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKieuKhoa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên")});
            this.cboKieuKhoa.Properties.DropDownRows = 4;
            this.cboKieuKhoa.Properties.ImmediatePopup = true;
            this.cboKieuKhoa.Properties.NullText = " -- Kiểu khóa --";
            this.cboKieuKhoa.Properties.PopupFormMinSize = new System.Drawing.Size(83, 0);
            this.cboKieuKhoa.Properties.ShowFooter = false;
            this.cboKieuKhoa.Properties.ShowHeader = false;
            this.cboKieuKhoa.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboKieuKhoa.Size = new System.Drawing.Size(100, 20);
            this.cboKieuKhoa.TabIndex = 3;
            // 
            // spSoGioKhoa
            // 
            this.spSoGioKhoa.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spSoGioKhoa.Location = new System.Drawing.Point(253, 82);
            this.spSoGioKhoa.Name = "spSoGioKhoa";
            this.spSoGioKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spSoGioKhoa.Properties.IsFloatValue = false;
            this.spSoGioKhoa.Properties.Mask.EditMask = "N00";
            this.spSoGioKhoa.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spSoGioKhoa.Size = new System.Drawing.Size(100, 20);
            this.spSoGioKhoa.TabIndex = 4;
            // 
            // spSoNgayDuLieu
            // 
            this.spSoNgayDuLieu.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spSoNgayDuLieu.Location = new System.Drawing.Point(73, 56);
            this.spSoNgayDuLieu.Name = "spSoNgayDuLieu";
            this.spSoNgayDuLieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spSoNgayDuLieu.Properties.IsFloatValue = false;
            this.spSoNgayDuLieu.Properties.Mask.EditMask = "N00";
            this.spSoNgayDuLieu.Properties.MaxValue = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.spSoNgayDuLieu.Size = new System.Drawing.Size(280, 20);
            this.spSoNgayDuLieu.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(21, 85);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Kiểu khóa";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(192, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Số giờ khóa";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(20, 111);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Qua ngày";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Ngày dữ liệu";
            // 
            // ToolbarLd
            // 
            this.ToolbarLd.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarLd.Appearance.Options.UseBackColor = true;
            this.ToolbarLd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolbarLd.Location = new System.Drawing.Point(0, 139);
            this.ToolbarLd.Name = "ToolbarLd";
            this.ToolbarLd.SenderName = INVENTORY.CONTROL.ToolbarLd.Action.None;
            this.ToolbarLd.Size = new System.Drawing.Size(384, 28);
            this.ToolbarLd.TabIndex = 2;
            this.ToolbarLd.Clicked += new System.EventHandler(this.ToolbarLd_Clicked);
            // 
            // frmThietLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 167);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ToolbarLd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThietLap";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin hệ thống";
            this.Load += new System.EventHandler(this.frmThietLap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPhanMem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkXoaQuaNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKieuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoGioKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoNgayDuLieu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ImageFileDialog;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTenPhanMem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit spSoNgayDuLieu;
        private DevExpress.XtraEditors.SpinEdit spSoGioKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cboKieuKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private INVENTORY.CONTROL.ToolbarLd ToolbarLd;
        private DevExpress.XtraEditors.CheckedListBoxControl chkXoaQuaNgay;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}
namespace INVENTORY.WinApp.HETHONG
{
    partial class frmNguoiDungAdd
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtChuThich = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkThuocTinh = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.chkTrangThai = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTruyCap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMain_TenKhoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_IdVaiTro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_cboVaiTro = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridMain_MacDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_chkMacDinh = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ToolbarDm = new INVENTORY.CONTROL.ToolbarDm();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkThuocTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTruyCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_cboVaiTro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_chkMacDinh)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(32, 33);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Tên (*)";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Chú thích";
            // 
            // txtTen
            // 
            this.txtTen.EditValue = "";
            this.txtTen.EnterMoveNextControl = true;
            this.txtTen.Location = new System.Drawing.Point(73, 30);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.MaxLength = 100;
            this.txtTen.Size = new System.Drawing.Size(282, 20);
            this.txtTen.TabIndex = 0;
            // 
            // txtChuThich
            // 
            this.txtChuThich.EditValue = "";
            this.txtChuThich.EnterMoveNextControl = true;
            this.txtChuThich.Location = new System.Drawing.Point(73, 108);
            this.txtChuThich.Name = "txtChuThich";
            this.txtChuThich.Properties.MaxLength = 100;
            this.txtChuThich.Size = new System.Drawing.Size(282, 20);
            this.txtChuThich.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkThuocTinh);
            this.groupControl1.Controls.Add(this.chkTrangThai);
            this.groupControl1.Controls.Add(this.txtMatKhau);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Controls.Add(this.txtTenTruyCap);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtChuThich);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(403, 165);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin Người dùng";
            // 
            // chkThuocTinh
            // 
            this.chkThuocTinh.CheckOnClick = true;
            this.chkThuocTinh.HorizontalScrollbar = true;
            this.chkThuocTinh.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(true, "Đánh dấu nếu sử dụng phần mềm", System.Windows.Forms.CheckState.Checked)});
            this.chkThuocTinh.Location = new System.Drawing.Point(73, 82);
            this.chkThuocTinh.Name = "chkThuocTinh";
            this.chkThuocTinh.Size = new System.Drawing.Size(282, 20);
            this.chkThuocTinh.TabIndex = 4;
            this.chkThuocTinh.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(this.chkTrangThai_DrawItem);
            this.chkThuocTinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkTrangThai_KeyDown);
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.CheckOnClick = true;
            this.chkTrangThai.HorizontalScrollbar = true;
            this.chkTrangThai.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(true, "Đánh dấu nếu còn hoạt động", System.Windows.Forms.CheckState.Checked)});
            this.chkTrangThai.Location = new System.Drawing.Point(73, 134);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(282, 20);
            this.chkTrangThai.TabIndex = 6;
            this.chkTrangThai.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(this.chkTrangThai_DrawItem);
            this.chkTrangThai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkTrangThai_KeyDown);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.EditValue = "";
            this.txtMatKhau.EnterMoveNextControl = true;
            this.txtMatKhau.Location = new System.Drawing.Point(245, 56);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.MaxLength = 50;
            this.txtMatKhau.Size = new System.Drawing.Size(110, 20);
            this.txtMatKhau.TabIndex = 2;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(193, 59);
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
            this.txtTenTruyCap.Size = new System.Drawing.Size(110, 20);
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
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Thuộc tính";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 137);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Trạng thái";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridMain);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 165);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(403, 166);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông tin Quyền hạn";
            // 
            // gridMain
            // 
            this.gridMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(2, 21);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gridMain_cboVaiTro,
            this.gridMain_chkMacDinh});
            this.gridMain.Size = new System.Drawing.Size(399, 143);
            this.gridMain.TabIndex = 0;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
            // 
            // gridMainView
            // 
            this.gridMainView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridMain_TenKhoHang,
            this.gridMain_IdVaiTro,
            this.gridMain_MacDinh});
            this.gridMainView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.GroupPanelText = "Kéo cột tương ứng thả vào đây để nhóm dữ liệu";
            this.gridMainView.Name = "gridMainView";
            this.gridMainView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridMainView.OptionsView.ShowDetailButtons = false;
            this.gridMainView.OptionsView.ShowGroupPanel = false;
            // 
            // gridMain_TenKhoHang
            // 
            this.gridMain_TenKhoHang.Caption = "Kho hàng";
            this.gridMain_TenKhoHang.FieldName = "TenKhoHang";
            this.gridMain_TenKhoHang.Name = "gridMain_TenKhoHang";
            this.gridMain_TenKhoHang.OptionsColumn.AllowEdit = false;
            this.gridMain_TenKhoHang.OptionsFilter.AllowFilter = false;
            this.gridMain_TenKhoHang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.gridMain_TenKhoHang.Visible = true;
            this.gridMain_TenKhoHang.VisibleIndex = 0;
            this.gridMain_TenKhoHang.Width = 166;
            // 
            // gridMain_IdVaiTro
            // 
            this.gridMain_IdVaiTro.Caption = "Vai trò";
            this.gridMain_IdVaiTro.ColumnEdit = this.gridMain_cboVaiTro;
            this.gridMain_IdVaiTro.FieldName = "IdVaiTro";
            this.gridMain_IdVaiTro.Name = "gridMain_IdVaiTro";
            this.gridMain_IdVaiTro.OptionsColumn.FixedWidth = true;
            this.gridMain_IdVaiTro.OptionsFilter.AllowFilter = false;
            this.gridMain_IdVaiTro.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.gridMain_IdVaiTro.Visible = true;
            this.gridMain_IdVaiTro.VisibleIndex = 1;
            this.gridMain_IdVaiTro.Width = 150;
            // 
            // gridMain_cboVaiTro
            // 
            this.gridMain_cboVaiTro.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.gridMain_cboVaiTro.AutoHeight = false;
            this.gridMain_cboVaiTro.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.gridMain_cboVaiTro.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên")});
            this.gridMain_cboVaiTro.DisplayMember = "Ten";
            this.gridMain_cboVaiTro.Name = "gridMain_cboVaiTro";
            this.gridMain_cboVaiTro.NullText = "";
            this.gridMain_cboVaiTro.PopupFormMinSize = new System.Drawing.Size(133, 0);
            this.gridMain_cboVaiTro.PopupWidth = 133;
            this.gridMain_cboVaiTro.ShowFooter = false;
            this.gridMain_cboVaiTro.ShowHeader = false;
            this.gridMain_cboVaiTro.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gridMain_cboVaiTro.ValueMember = "Id";
            this.gridMain_cboVaiTro.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.gridMain_cboVaiTro_ButtonClick);
            // 
            // gridMain_MacDinh
            // 
            this.gridMain_MacDinh.AppearanceCell.Options.UseTextOptions = true;
            this.gridMain_MacDinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridMain_MacDinh.AppearanceHeader.Options.UseTextOptions = true;
            this.gridMain_MacDinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridMain_MacDinh.Caption = "Mặc định";
            this.gridMain_MacDinh.ColumnEdit = this.gridMain_chkMacDinh;
            this.gridMain_MacDinh.FieldName = "MacDinh";
            this.gridMain_MacDinh.Name = "gridMain_MacDinh";
            this.gridMain_MacDinh.OptionsColumn.FixedWidth = true;
            this.gridMain_MacDinh.OptionsFilter.AllowFilter = false;
            this.gridMain_MacDinh.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.gridMain_MacDinh.Visible = true;
            this.gridMain_MacDinh.VisibleIndex = 2;
            this.gridMain_MacDinh.Width = 60;
            // 
            // gridMain_chkMacDinh
            // 
            this.gridMain_chkMacDinh.AutoHeight = false;
            this.gridMain_chkMacDinh.Caption = "Check";
            this.gridMain_chkMacDinh.Name = "gridMain_chkMacDinh";
            this.gridMain_chkMacDinh.CheckedChanged += new System.EventHandler(this.gridMain_chkMacDinh_CheckedChanged);
            // 
            // ToolbarDm
            // 
            this.ToolbarDm.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarDm.Appearance.Options.UseBackColor = true;
            this.ToolbarDm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolbarDm.Location = new System.Drawing.Point(0, 331);
            this.ToolbarDm.Name = "ToolbarDm";
            this.ToolbarDm.SenderName = INVENTORY.CONTROL.ToolbarDm.Action.None;
            this.ToolbarDm.Size = new System.Drawing.Size(403, 28);
            this.ToolbarDm.TabIndex = 2;
            this.ToolbarDm.Clicked += new System.EventHandler(this.ToolbarDm_Clicked);
            // 
            // frmNguoiDungAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 359);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.ToolbarDm);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNguoiDungAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật Người dùng";
            this.Load += new System.EventHandler(this.frmNguoiDungAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkThuocTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTruyCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_cboVaiTro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_chkMacDinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtChuThich;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTenTruyCap;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn gridMain_TenKhoHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridMain_MacDinh;
        private DevExpress.XtraGrid.Columns.GridColumn gridMain_IdVaiTro;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gridMain_cboVaiTro;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit gridMain_chkMacDinh;
        private INVENTORY.CONTROL.ToolbarDm ToolbarDm;
        private DevExpress.XtraEditors.CheckedListBoxControl chkTrangThai;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckedListBoxControl chkThuocTinh;
    }
}
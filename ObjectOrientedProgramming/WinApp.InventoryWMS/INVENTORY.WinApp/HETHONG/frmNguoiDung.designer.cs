namespace INVENTORY.WinApp.HETHONG
{
    partial class frmNguoiDung
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
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTruyCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChuThich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_cboTrangThai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.splitMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ucKhoHang = new INVENTORY.WinApp.CONTROL.ucKhoHang();
            this.Toolbar = new INVENTORY.CONTROL.Toolbar();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_cboTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridMain
            // 
            this.gridMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(0, 0);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gridMain_cboTrangThai});
            this.gridMain.Size = new System.Drawing.Size(1093, 633);
            this.gridMain.TabIndex = 6;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
            this.gridMain.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridMain_ProcessGridKey);
            // 
            // gridMainView
            // 
            this.gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Ten,
            this.TenTruyCap,
            this.DangNhap,
            this.ChuThich,
            this.TrangThai});
            this.gridMainView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.GroupPanelText = "Kéo cột tương ứng thả vào đây để nhóm dữ liệu";
            this.gridMainView.IndicatorWidth = 30;
            this.gridMainView.Name = "gridMainView";
            this.gridMainView.OptionsBehavior.Editable = false;
            this.gridMainView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridMainView.OptionsView.ShowAutoFilterRow = true;
            this.gridMainView.OptionsView.ShowDetailButtons = false;
            this.gridMainView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridMainView_CustomDrawRowIndicator);
            this.gridMainView.DoubleClick += new System.EventHandler(this.gridMainView_DoubleClick);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.OptionsFilter.AllowFilter = false;
            this.Id.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // Ten
            // 
            this.Ten.Caption = "Tên";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.OptionsColumn.FixedWidth = true;
            this.Ten.OptionsFilter.AllowFilter = false;
            this.Ten.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 0;
            this.Ten.Width = 300;
            // 
            // TenTruyCap
            // 
            this.TenTruyCap.AppearanceCell.Options.UseTextOptions = true;
            this.TenTruyCap.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.TenTruyCap.Caption = "Tên truy cập";
            this.TenTruyCap.FieldName = "TenTruyCap";
            this.TenTruyCap.Name = "TenTruyCap";
            this.TenTruyCap.OptionsColumn.FixedWidth = true;
            this.TenTruyCap.OptionsFilter.AllowFilter = false;
            this.TenTruyCap.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenTruyCap.Visible = true;
            this.TenTruyCap.VisibleIndex = 1;
            this.TenTruyCap.Width = 100;
            // 
            // DangNhap
            // 
            this.DangNhap.AppearanceCell.Options.UseTextOptions = true;
            this.DangNhap.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DangNhap.AppearanceHeader.Options.UseTextOptions = true;
            this.DangNhap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DangNhap.Caption = "Đăng nhập";
            this.DangNhap.FieldName = "DangNhap";
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.OptionsColumn.FixedWidth = true;
            this.DangNhap.OptionsFilter.AllowFilter = false;
            this.DangNhap.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.DangNhap.Visible = true;
            this.DangNhap.VisibleIndex = 2;
            this.DangNhap.Width = 70;
            // 
            // ChuThich
            // 
            this.ChuThich.Caption = "Chú thích";
            this.ChuThich.FieldName = "ChuThich";
            this.ChuThich.Name = "ChuThich";
            this.ChuThich.OptionsFilter.AllowFilter = false;
            this.ChuThich.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ChuThich.Visible = true;
            this.ChuThich.VisibleIndex = 3;
            this.ChuThich.Width = 272;
            // 
            // TrangThai
            // 
            this.TrangThai.AppearanceHeader.Options.UseTextOptions = true;
            this.TrangThai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TrangThai.Caption = "Trạng thái";
            this.TrangThai.ColumnEdit = this.gridMain_cboTrangThai;
            this.TrangThai.FieldName = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.OptionsColumn.FixedWidth = true;
            this.TrangThai.OptionsFilter.AllowFilter = false;
            this.TrangThai.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 4;
            this.TrangThai.Width = 80;
            // 
            // gridMain_cboTrangThai
            // 
            this.gridMain_cboTrangThai.AutoHeight = false;
            this.gridMain_cboTrangThai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridMain_cboTrangThai.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên")});
            this.gridMain_cboTrangThai.DisplayMember = "Ten";
            this.gridMain_cboTrangThai.DropDownRows = 4;
            this.gridMain_cboTrangThai.ImmediatePopup = true;
            this.gridMain_cboTrangThai.Name = "gridMain_cboTrangThai";
            this.gridMain_cboTrangThai.NullText = "";
            this.gridMain_cboTrangThai.PopupFormMinSize = new System.Drawing.Size(63, 0);
            this.gridMain_cboTrangThai.PopupWidth = 63;
            this.gridMain_cboTrangThai.ShowFooter = false;
            this.gridMain_cboTrangThai.ShowHeader = false;
            this.gridMain_cboTrangThai.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gridMain_cboTrangThai.ValueMember = "Id";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 28);
            this.splitMain.Name = "splitMain";
            this.splitMain.Panel1.Controls.Add(this.groupControl1);
            this.splitMain.Panel1.Text = "Panel1";
            this.splitMain.Panel2.Controls.Add(this.gridMain);
            this.splitMain.Panel2.Text = "Panel2";
            this.splitMain.Size = new System.Drawing.Size(1284, 633);
            this.splitMain.SplitterPosition = 185;
            this.splitMain.TabIndex = 7;
            this.splitMain.Text = "splitMain";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ucKhoHang);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(185, 633);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Kho hàng";
            // 
            // ucKhoHang
            // 
            this.ucKhoHang.Appearance.BackColor = System.Drawing.Color.White;
            this.ucKhoHang.Appearance.Options.UseBackColor = true;
            this.ucKhoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKhoHang.Loaded = false;
            this.ucKhoHang.Location = new System.Drawing.Point(2, 21);
            this.ucKhoHang.Name = "ucKhoHang";
            this.ucKhoHang.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ucKhoHang.Size = new System.Drawing.Size(181, 610);
            this.ucKhoHang.TabIndex = 0;
            this.ucKhoHang.FocusedNodeChanged += new System.EventHandler(this.ucKhoHang_FocusedNodeChanged);
            // 
            // Toolbar
            // 
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.SenderName = INVENTORY.CONTROL.Toolbar.Action.None;
            this.Toolbar.Size = new System.Drawing.Size(1284, 28);
            this.Toolbar.TabIndex = 5;
            this.Toolbar.Clicked += new System.EventHandler(this.Toolbar_Clicked);
            this.Toolbar.Changed += new System.EventHandler(this.Toolbar_Changed);
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.Toolbar);
            this.Name = "frmNguoiDung";
            this.Text = "Quản lý Người dùng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmNguoiDung_Activated);
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_cboTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn ChuThich;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gridMain_cboTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn TenTruyCap;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraEditors.SplitContainerControl splitMain;
        private INVENTORY.CONTROL.Toolbar Toolbar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn DangNhap;
        private CONTROL.ucKhoHang ucKhoHang;
    }
}
namespace INVENTORY.WinApp.BAOCAO.FORM
{
    partial class frmHangChuyen
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
            this.TenNhomVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKhoNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNguoiGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNguoiTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToolbarBc = new INVENTORY.CONTROL.ToolbarBc();
            this.brgWorker = new System.ComponentModel.BackgroundWorker();
            this.splitMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ucNhomVatTu = new INVENTORY.WinApp.CONTROL.ucNhomVatTu();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ucThoiGian = new INVENTORY.WinApp.CONTROL.ucThoiGian();
            this.cboKhoNhan = new DevExpress.XtraEditors.LookUpEdit();
            this.cboLoaiBaoCao = new DevExpress.XtraEditors.LookUpEdit();
            this.cboKhoHang = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiBaoCao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridMain
            // 
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(2, 21);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(1184, 617);
            this.gridMain.TabIndex = 0;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
            this.gridMain.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridMain_ProcessGridKey);
            // 
            // gridMainView
            // 
            this.gridMainView.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridMainView.Appearance.GroupRow.Options.UseFont = true;
            this.gridMainView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenNhomVatTu,
            this.TenKhoNhan,
            this.SoPhieu,
            this.TenNguoiGiao,
            this.TenNguoiTao,
            this.NgayTao,
            this.TenLoaiVatTu,
            this.QuyCach,
            this.TenDonViTinh,
            this.SoLuong});
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.GroupCount = 1;
            this.gridMainView.GroupFormat = "{1} {2}";
            this.gridMainView.GroupPanelText = "Kéo cột tương ứng thả vào đây để nhóm dữ liệu";
            this.gridMainView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuong", null, "{0:N0}")});
            this.gridMainView.IndicatorWidth = 37;
            this.gridMainView.LevelIndent = 0;
            this.gridMainView.Name = "gridMainView";
            this.gridMainView.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridMainView.OptionsBehavior.Editable = false;
            this.gridMainView.OptionsDetail.ShowDetailTabs = false;
            this.gridMainView.OptionsPrint.PrintDetails = true;
            this.gridMainView.OptionsPrint.PrintFilterInfo = true;
            this.gridMainView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridMainView.OptionsView.ShowAutoFilterRow = true;
            this.gridMainView.OptionsView.ShowFooter = true;
            this.gridMainView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TenNhomVatTu, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridMainView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridMainView_CustomDrawRowIndicator);
            this.gridMainView.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridMainView_CustomDrawGroupRow);
            this.gridMainView.DoubleClick += new System.EventHandler(this.gridMainView_DoubleClick);
            // 
            // TenNhomVatTu
            // 
            this.TenNhomVatTu.Caption = "Nhóm vật tư";
            this.TenNhomVatTu.FieldName = "TenNhomVatTu";
            this.TenNhomVatTu.Name = "TenNhomVatTu";
            this.TenNhomVatTu.OptionsFilter.AllowFilter = false;
            this.TenNhomVatTu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // TenKhoNhan
            // 
            this.TenKhoNhan.Caption = "Kho nhận";
            this.TenKhoNhan.FieldName = "TenKhoNhan";
            this.TenKhoNhan.Name = "TenKhoNhan";
            this.TenKhoNhan.OptionsColumn.FixedWidth = true;
            this.TenKhoNhan.OptionsFilter.AllowFilter = false;
            this.TenKhoNhan.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenKhoNhan.Visible = true;
            this.TenKhoNhan.VisibleIndex = 0;
            this.TenKhoNhan.Width = 200;
            // 
            // SoPhieu
            // 
            this.SoPhieu.AppearanceHeader.Options.UseTextOptions = true;
            this.SoPhieu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoPhieu.Caption = "Số phiếu";
            this.SoPhieu.FieldName = "SoPhieu";
            this.SoPhieu.Name = "SoPhieu";
            this.SoPhieu.OptionsColumn.FixedWidth = true;
            this.SoPhieu.OptionsFilter.AllowFilter = false;
            this.SoPhieu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.SoPhieu.Visible = true;
            this.SoPhieu.VisibleIndex = 1;
            this.SoPhieu.Width = 80;
            // 
            // TenNguoiGiao
            // 
            this.TenNguoiGiao.Caption = "Người giao";
            this.TenNguoiGiao.FieldName = "TenNguoiGiao";
            this.TenNguoiGiao.Name = "TenNguoiGiao";
            this.TenNguoiGiao.OptionsColumn.FixedWidth = true;
            this.TenNguoiGiao.OptionsFilter.AllowFilter = false;
            this.TenNguoiGiao.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenNguoiGiao.Visible = true;
            this.TenNguoiGiao.VisibleIndex = 2;
            this.TenNguoiGiao.Width = 130;
            // 
            // TenNguoiTao
            // 
            this.TenNguoiTao.Caption = "Người tạo";
            this.TenNguoiTao.FieldName = "TenNguoiTao";
            this.TenNguoiTao.Name = "TenNguoiTao";
            this.TenNguoiTao.OptionsColumn.FixedWidth = true;
            this.TenNguoiTao.OptionsFilter.AllowFilter = false;
            this.TenNguoiTao.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenNguoiTao.Visible = true;
            this.TenNguoiTao.VisibleIndex = 3;
            this.TenNguoiTao.Width = 130;
            // 
            // NgayTao
            // 
            this.NgayTao.AppearanceCell.Options.UseTextOptions = true;
            this.NgayTao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NgayTao.AppearanceHeader.Options.UseTextOptions = true;
            this.NgayTao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayTao.Caption = "Ngày tạo";
            this.NgayTao.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.NgayTao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayTao.FieldName = "NgayTao";
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.OptionsColumn.FixedWidth = true;
            this.NgayTao.OptionsFilter.AllowFilter = false;
            this.NgayTao.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NgayTao.Visible = true;
            this.NgayTao.VisibleIndex = 4;
            this.NgayTao.Width = 95;
            // 
            // TenLoaiVatTu
            // 
            this.TenLoaiVatTu.Caption = "Loại vật tư";
            this.TenLoaiVatTu.FieldName = "TenLoaiVatTu";
            this.TenLoaiVatTu.Name = "TenLoaiVatTu";
            this.TenLoaiVatTu.OptionsFilter.AllowFilter = false;
            this.TenLoaiVatTu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenLoaiVatTu.Visible = true;
            this.TenLoaiVatTu.VisibleIndex = 5;
            this.TenLoaiVatTu.Width = 327;
            // 
            // QuyCach
            // 
            this.QuyCach.Caption = "Quy cách";
            this.QuyCach.FieldName = "QuyCach";
            this.QuyCach.Name = "QuyCach";
            this.QuyCach.OptionsColumn.FixedWidth = true;
            this.QuyCach.OptionsFilter.AllowFilter = false;
            this.QuyCach.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.QuyCach.Visible = true;
            this.QuyCach.VisibleIndex = 6;
            this.QuyCach.Width = 150;
            // 
            // TenDonViTinh
            // 
            this.TenDonViTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.TenDonViTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenDonViTinh.Caption = "ĐVT";
            this.TenDonViTinh.FieldName = "TenDonViTinh";
            this.TenDonViTinh.Name = "TenDonViTinh";
            this.TenDonViTinh.OptionsColumn.FixedWidth = true;
            this.TenDonViTinh.OptionsFilter.AllowFilter = false;
            this.TenDonViTinh.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenDonViTinh.Visible = true;
            this.TenDonViTinh.VisibleIndex = 7;
            this.TenDonViTinh.Width = 50;
            // 
            // SoLuong
            // 
            this.SoLuong.AppearanceCell.Options.UseTextOptions = true;
            this.SoLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SoLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.SoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.DisplayFormat.FormatString = "N0";
            this.SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.OptionsColumn.FixedWidth = true;
            this.SoLuong.OptionsFilter.AllowFilter = false;
            this.SoLuong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.SoLuong.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuong", "{0:N0}")});
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 8;
            this.SoLuong.Width = 60;
            // 
            // ToolbarBc
            // 
            this.ToolbarBc.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolbarBc.Location = new System.Drawing.Point(0, 0);
            this.ToolbarBc.Name = "ToolbarBc";
            this.ToolbarBc.SenderName = INVENTORY.CONTROL.ToolbarBc.Action.None;
            this.ToolbarBc.Size = new System.Drawing.Size(1394, 28);
            this.ToolbarBc.TabIndex = 0;
            this.ToolbarBc.Clicked += new System.EventHandler(this.ToolbarBc_Clicked);
            // 
            // brgWorker
            // 
            this.brgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.brgWorker_DoWork);
            this.brgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.brgWorker_RunWorkerCompleted);
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 28);
            this.splitMain.Name = "splitMain";
            this.splitMain.Panel1.Controls.Add(this.groupControl2);
            this.splitMain.Panel1.Controls.Add(this.groupControl1);
            this.splitMain.Panel1.Text = "Panel1";
            this.splitMain.Panel2.Controls.Add(this.groupControl3);
            this.splitMain.Panel2.Text = "Panel2";
            this.splitMain.Size = new System.Drawing.Size(1394, 640);
            this.splitMain.SplitterPosition = 200;
            this.splitMain.TabIndex = 1;
            this.splitMain.Text = "splitMain";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ucNhomVatTu);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 138);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(200, 502);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Nhóm vật tư";
            // 
            // ucNhomVatTu
            // 
            this.ucNhomVatTu.Appearance.BackColor = System.Drawing.Color.White;
            this.ucNhomVatTu.Appearance.Options.UseBackColor = true;
            this.ucNhomVatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNhomVatTu.Location = new System.Drawing.Point(2, 21);
            this.ucNhomVatTu.Name = "ucNhomVatTu";
            this.ucNhomVatTu.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ucNhomVatTu.Size = new System.Drawing.Size(196, 479);
            this.ucNhomVatTu.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ucThoiGian);
            this.groupControl1.Controls.Add(this.cboKhoNhan);
            this.groupControl1.Controls.Add(this.cboLoaiBaoCao);
            this.groupControl1.Controls.Add(this.cboKhoHang);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 138);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // ucThoiGian
            // 
            this.ucThoiGian.DenNgay = new System.DateTime(((long)(0)));
            this.ucThoiGian.Location = new System.Drawing.Point(12, 82);
            this.ucThoiGian.Name = "ucThoiGian";
            this.ucThoiGian.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ucThoiGian.Size = new System.Drawing.Size(178, 20);
            this.ucThoiGian.TabIndex = 2;
            this.ucThoiGian.TuNgay = new System.DateTime(((long)(0)));
            // 
            // cboKhoNhan
            // 
            this.cboKhoNhan.EnterMoveNextControl = true;
            this.cboKhoNhan.Location = new System.Drawing.Point(12, 56);
            this.cboKhoNhan.Name = "cboKhoNhan";
            this.cboKhoNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhoNhan.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MatHang", "MatHang", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.cboKhoNhan.Properties.DropDownRows = 15;
            this.cboKhoNhan.Properties.NullText = " -- Kho nhận --";
            this.cboKhoNhan.Properties.PopupFormMinSize = new System.Drawing.Size(161, 0);
            this.cboKhoNhan.Properties.PopupWidth = 161;
            this.cboKhoNhan.Properties.ShowFooter = false;
            this.cboKhoNhan.Properties.ShowHeader = false;
            this.cboKhoNhan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboKhoNhan.Size = new System.Drawing.Size(178, 20);
            this.cboKhoNhan.TabIndex = 1;
            // 
            // cboLoaiBaoCao
            // 
            this.cboLoaiBaoCao.Location = new System.Drawing.Point(12, 108);
            this.cboLoaiBaoCao.Name = "cboLoaiBaoCao";
            this.cboLoaiBaoCao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiBaoCao.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên")});
            this.cboLoaiBaoCao.Properties.DropDownRows = 3;
            this.cboLoaiBaoCao.Properties.NullText = " -- Loại báo cáo --";
            this.cboLoaiBaoCao.Properties.PopupFormMinSize = new System.Drawing.Size(161, 0);
            this.cboLoaiBaoCao.Properties.PopupWidth = 161;
            this.cboLoaiBaoCao.Properties.ShowFooter = false;
            this.cboLoaiBaoCao.Properties.ShowHeader = false;
            this.cboLoaiBaoCao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboLoaiBaoCao.Size = new System.Drawing.Size(178, 20);
            this.cboLoaiBaoCao.TabIndex = 3;
            this.cboLoaiBaoCao.EditValueChanged += new System.EventHandler(this.cboLoaiBaoCao_EditValueChanged);
            // 
            // cboKhoHang
            // 
            this.cboKhoHang.Location = new System.Drawing.Point(12, 30);
            this.cboKhoHang.Name = "cboKhoHang";
            this.cboKhoHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhoHang.Properties.DropDownRows = 12;
            this.cboKhoHang.Properties.NullText = " -- Kho hàng --";
            this.cboKhoHang.Properties.PopupFormMinSize = new System.Drawing.Size(178, 150);
            this.cboKhoHang.Properties.PopupFormSize = new System.Drawing.Size(178, 150);
            this.cboKhoHang.Properties.PopupSizeable = false;
            this.cboKhoHang.Properties.SelectAllItemCaption = "(Chọn tất cả)";
            this.cboKhoHang.Properties.ShowButtons = false;
            this.cboKhoHang.Properties.ShowPopupCloseButton = false;
            this.cboKhoHang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboKhoHang.Size = new System.Drawing.Size(178, 20);
            this.cboKhoHang.TabIndex = 0;
            this.cboKhoHang.EditValueChanged += new System.EventHandler(this.cboKhoHang_EditValueChanged);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridMain);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1188, 640);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Thông tin Hàng chuyển";
            // 
            // frmHangChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 668);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.ToolbarBc);
            this.Name = "frmHangChuyen";
            this.Text = "Hàng chuyển";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHangChuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiBaoCao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private INVENTORY.CONTROL.ToolbarBc ToolbarBc;
        private System.ComponentModel.BackgroundWorker brgWorker;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhomVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiVatTu;
        private DevExpress.XtraEditors.SplitContainerControl splitMain;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cboKhoHang;
        private DevExpress.XtraEditors.LookUpEdit cboLoaiBaoCao;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn TenKhoNhan;
        private DevExpress.XtraGrid.Columns.GridColumn SoPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn TenNguoiTao;
        private DevExpress.XtraEditors.LookUpEdit cboKhoNhan;
        private CONTROL.ucNhomVatTu ucNhomVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn TenDonViTinh;
        private CONTROL.ucThoiGian ucThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn TenNguoiGiao;
        private DevExpress.XtraGrid.Columns.GridColumn QuyCach;
    }
}
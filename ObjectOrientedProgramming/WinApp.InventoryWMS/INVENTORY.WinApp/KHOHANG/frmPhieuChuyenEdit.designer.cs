namespace INVENTORY.WinApp.KHOHANG
{
    partial class frmPhieuChuyenEdit
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
            this.components = new System.ComponentModel.Container();
            this.brgWorker = new System.ComponentModel.BackgroundWorker();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChuThich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_txtChuThich = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cboLoaiVatTu = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cboLoaiVatTuView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboLoaiVatTu_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboLoaiVatTu_QuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboLoaiVatTu_TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboLoaiVatTu_SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.cmdXoa = new DevExpress.XtraEditors.SimpleButton();
            this.cmdChon = new DevExpress.XtraEditors.SimpleButton();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelThongTin = new DevExpress.XtraEditors.PanelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.cboKhoNhan = new DevExpress.XtraEditors.LookUpEdit();
            this.txtChuThich = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.cboNguoiGiao = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cboNguoiGiaoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboNguoiGiao_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtNgayTao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoPhieu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ToolbarMv = new INVENTORY.CONTROL.ToolbarMv();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_txtChuThich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatTuView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelThongTin)).BeginInit();
            this.PanelThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguoiGiao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguoiGiaoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // brgWorker
            // 
            this.brgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.brgWorker_DoWork);
            this.brgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.brgWorker_RunWorkerCompleted);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridMain);
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 83);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(884, 490);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông tin Sản phẩm";
            // 
            // gridMain
            // 
            this.gridMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(2, 53);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gridMain_txtChuThich});
            this.gridMain.Size = new System.Drawing.Size(880, 435);
            this.gridMain.TabIndex = 1;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
            this.gridMain.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridMain_ProcessGridKey);
            // 
            // gridMainView
            // 
            this.gridMainView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Status,
            this.TenLoaiVatTu,
            this.QuyCach,
            this.TenDonViTinh,
            this.SoLuong,
            this.ChuThich});
            this.gridMainView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.GroupFormat = "[#image]{1} {2}";
            this.gridMainView.GroupPanelText = "Kéo cột tương ứng thả vào đây để nhóm dữ liệu";
            this.gridMainView.IndicatorWidth = 30;
            this.gridMainView.Name = "gridMainView";
            this.gridMainView.OptionsNavigation.AutoFocusNewRow = true;
            this.gridMainView.OptionsSelection.MultiSelect = true;
            this.gridMainView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridMainView.OptionsView.ShowAutoFilterRow = true;
            this.gridMainView.OptionsView.ShowFooter = true;
            this.gridMainView.OptionsView.ShowGroupPanel = false;
            this.gridMainView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridMainView_CustomDrawRowIndicator);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.OptionsColumn.AllowEdit = false;
            // 
            // Status
            // 
            this.Status.Caption = "Status";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.OptionsColumn.AllowEdit = false;
            this.Status.OptionsFilter.AllowFilter = false;
            this.Status.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // TenLoaiVatTu
            // 
            this.TenLoaiVatTu.Caption = "Loại vật tư";
            this.TenLoaiVatTu.FieldName = "TenLoaiVatTu";
            this.TenLoaiVatTu.Name = "TenLoaiVatTu";
            this.TenLoaiVatTu.OptionsColumn.AllowEdit = false;
            this.TenLoaiVatTu.OptionsFilter.AllowFilter = false;
            this.TenLoaiVatTu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenLoaiVatTu.Visible = true;
            this.TenLoaiVatTu.VisibleIndex = 0;
            this.TenLoaiVatTu.Width = 460;
            // 
            // QuyCach
            // 
            this.QuyCach.Caption = "Quy cách";
            this.QuyCach.FieldName = "QuyCach";
            this.QuyCach.Name = "QuyCach";
            this.QuyCach.OptionsColumn.AllowEdit = false;
            this.QuyCach.OptionsColumn.FixedWidth = true;
            this.QuyCach.OptionsFilter.AllowFilter = false;
            this.QuyCach.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.QuyCach.Visible = true;
            this.QuyCach.VisibleIndex = 1;
            this.QuyCach.Width = 200;
            // 
            // TenDonViTinh
            // 
            this.TenDonViTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.TenDonViTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenDonViTinh.Caption = "ĐVT";
            this.TenDonViTinh.FieldName = "TenDonViTinh";
            this.TenDonViTinh.Name = "TenDonViTinh";
            this.TenDonViTinh.OptionsColumn.AllowEdit = false;
            this.TenDonViTinh.OptionsColumn.FixedWidth = true;
            this.TenDonViTinh.OptionsFilter.AllowFilter = false;
            this.TenDonViTinh.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenDonViTinh.Visible = true;
            this.TenDonViTinh.VisibleIndex = 2;
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
            this.SoLuong.OptionsColumn.AllowEdit = false;
            this.SoLuong.OptionsColumn.FixedWidth = true;
            this.SoLuong.OptionsFilter.AllowFilter = false;
            this.SoLuong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.SoLuong.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuong", "{0:N0}")});
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            this.SoLuong.Width = 60;
            // 
            // ChuThich
            // 
            this.ChuThich.Caption = "Chú thích";
            this.ChuThich.ColumnEdit = this.gridMain_txtChuThich;
            this.ChuThich.FieldName = "ChuThich";
            this.ChuThich.Name = "ChuThich";
            this.ChuThich.OptionsColumn.FixedWidth = true;
            this.ChuThich.OptionsFilter.AllowFilter = false;
            this.ChuThich.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ChuThich.Visible = true;
            this.ChuThich.VisibleIndex = 4;
            this.ChuThich.Width = 200;
            // 
            // gridMain_txtChuThich
            // 
            this.gridMain_txtChuThich.AutoHeight = false;
            this.gridMain_txtChuThich.MaxLength = 300;
            this.gridMain_txtChuThich.Name = "gridMain_txtChuThich";
            this.gridMain_txtChuThich.ValidateOnEnterKey = true;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.cboLoaiVatTu);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.txtSoLuong);
            this.panelControl1.Controls.Add(this.cmdXoa);
            this.panelControl1.Controls.Add(this.cmdChon);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(880, 32);
            this.panelControl1.TabIndex = 0;
            // 
            // cboLoaiVatTu
            // 
            this.cboLoaiVatTu.EnterMoveNextControl = true;
            this.cboLoaiVatTu.Location = new System.Drawing.Point(71, 6);
            this.cboLoaiVatTu.Name = "cboLoaiVatTu";
            this.cboLoaiVatTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiVatTu.Properties.ImmediatePopup = true;
            this.cboLoaiVatTu.Properties.NullText = " -- Loại vật tư --";
            this.cboLoaiVatTu.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboLoaiVatTu.Properties.PopupFormMinSize = new System.Drawing.Size(786, 0);
            this.cboLoaiVatTu.Properties.PopupFormSize = new System.Drawing.Size(786, 0);
            this.cboLoaiVatTu.Properties.ShowFooter = false;
            this.cboLoaiVatTu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboLoaiVatTu.Properties.ValidateOnEnterKey = true;
            this.cboLoaiVatTu.Properties.View = this.cboLoaiVatTuView;
            this.cboLoaiVatTu.Size = new System.Drawing.Size(512, 20);
            this.cboLoaiVatTu.TabIndex = 0;
            // 
            // cboLoaiVatTuView
            // 
            this.cboLoaiVatTuView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cboLoaiVatTuView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cboLoaiVatTu_Ten,
            this.cboLoaiVatTu_QuyCach,
            this.cboLoaiVatTu_TenDonViTinh,
            this.cboLoaiVatTu_SoLuong});
            this.cboLoaiVatTuView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboLoaiVatTuView.FooterPanelHeight = 5;
            this.cboLoaiVatTuView.IndicatorWidth = 10;
            this.cboLoaiVatTuView.Name = "cboLoaiVatTuView";
            this.cboLoaiVatTuView.OptionsBehavior.Editable = false;
            this.cboLoaiVatTuView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboLoaiVatTuView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboLoaiVatTuView.OptionsView.ShowDetailButtons = false;
            this.cboLoaiVatTuView.OptionsView.ShowGroupPanel = false;
            // 
            // cboLoaiVatTu_Ten
            // 
            this.cboLoaiVatTu_Ten.Caption = "Tên";
            this.cboLoaiVatTu_Ten.FieldName = "Ten";
            this.cboLoaiVatTu_Ten.Name = "cboLoaiVatTu_Ten";
            this.cboLoaiVatTu_Ten.OptionsFilter.AllowFilter = false;
            this.cboLoaiVatTu_Ten.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.cboLoaiVatTu_Ten.Visible = true;
            this.cboLoaiVatTu_Ten.VisibleIndex = 0;
            this.cboLoaiVatTu_Ten.Width = 20;
            // 
            // cboLoaiVatTu_QuyCach
            // 
            this.cboLoaiVatTu_QuyCach.Caption = "Quy cách";
            this.cboLoaiVatTu_QuyCach.FieldName = "QuyCach";
            this.cboLoaiVatTu_QuyCach.Name = "cboLoaiVatTu_QuyCach";
            this.cboLoaiVatTu_QuyCach.OptionsColumn.FixedWidth = true;
            this.cboLoaiVatTu_QuyCach.OptionsFilter.AllowFilter = false;
            this.cboLoaiVatTu_QuyCach.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.cboLoaiVatTu_QuyCach.Visible = true;
            this.cboLoaiVatTu_QuyCach.VisibleIndex = 1;
            this.cboLoaiVatTu_QuyCach.Width = 200;
            // 
            // cboLoaiVatTu_TenDonViTinh
            // 
            this.cboLoaiVatTu_TenDonViTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.cboLoaiVatTu_TenDonViTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cboLoaiVatTu_TenDonViTinh.Caption = "ĐVT";
            this.cboLoaiVatTu_TenDonViTinh.FieldName = "TenDonViTinh";
            this.cboLoaiVatTu_TenDonViTinh.Name = "cboLoaiVatTu_TenDonViTinh";
            this.cboLoaiVatTu_TenDonViTinh.OptionsColumn.FixedWidth = true;
            this.cboLoaiVatTu_TenDonViTinh.OptionsFilter.AllowFilter = false;
            this.cboLoaiVatTu_TenDonViTinh.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.cboLoaiVatTu_TenDonViTinh.Visible = true;
            this.cboLoaiVatTu_TenDonViTinh.VisibleIndex = 2;
            this.cboLoaiVatTu_TenDonViTinh.Width = 50;
            // 
            // cboLoaiVatTu_SoLuong
            // 
            this.cboLoaiVatTu_SoLuong.AppearanceCell.Options.UseTextOptions = true;
            this.cboLoaiVatTu_SoLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cboLoaiVatTu_SoLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.cboLoaiVatTu_SoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cboLoaiVatTu_SoLuong.Caption = "Tồn";
            this.cboLoaiVatTu_SoLuong.DisplayFormat.FormatString = "N0";
            this.cboLoaiVatTu_SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cboLoaiVatTu_SoLuong.FieldName = "SoLuong";
            this.cboLoaiVatTu_SoLuong.Name = "cboLoaiVatTu_SoLuong";
            this.cboLoaiVatTu_SoLuong.OptionsColumn.FixedWidth = true;
            this.cboLoaiVatTu_SoLuong.OptionsFilter.AllowFilter = false;
            this.cboLoaiVatTu_SoLuong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.cboLoaiVatTu_SoLuong.Visible = true;
            this.cboLoaiVatTu_SoLuong.VisibleIndex = 3;
            this.cboLoaiVatTu_SoLuong.Width = 60;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 9);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 13);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "Loại vật tư";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoLuong.Location = new System.Drawing.Point(589, 6);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtSoLuong.Properties.IsFloatValue = false;
            this.txtSoLuong.Properties.Mask.EditMask = "N00";
            this.txtSoLuong.Properties.Mask.ShowPlaceHolders = false;
            this.txtSoLuong.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtSoLuong.Size = new System.Drawing.Size(60, 20);
            this.txtSoLuong.TabIndex = 1;
            this.txtSoLuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoLuong_KeyDown);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdXoa.Image = global::INVENTORY.WinApp.Properties.Resources.delete;
            this.cmdXoa.Location = new System.Drawing.Point(761, 6);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(100, 20);
            this.cmdXoa.TabIndex = 3;
            this.cmdXoa.Text = "Xóa (Del)";
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdChon
            // 
            this.cmdChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdChon.Image = global::INVENTORY.WinApp.Properties.Resources.accept;
            this.cmdChon.Location = new System.Drawing.Point(655, 6);
            this.cmdChon.Name = "cmdChon";
            this.cmdChon.Size = new System.Drawing.Size(100, 20);
            this.cmdChon.TabIndex = 2;
            this.cmdChon.Text = "Chọn (Enter)";
            this.cmdChon.Click += new System.EventHandler(this.cmdChon_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXoa});
            this.MainMenu.Name = "ToChucMenu";
            this.MainMenu.Size = new System.Drawing.Size(119, 26);
            // 
            // mnuXoa
            // 
            this.mnuXoa.Image = global::INVENTORY.WinApp.Properties.Resources.delete;
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuXoa.Size = new System.Drawing.Size(118, 22);
            this.mnuXoa.Text = "&Xóa";
            // 
            // PanelThongTin
            // 
            this.PanelThongTin.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelThongTin.Controls.Add(this.groupControl3);
            this.PanelThongTin.Controls.Add(this.groupControl1);
            this.PanelThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelThongTin.Location = new System.Drawing.Point(0, 0);
            this.PanelThongTin.Name = "PanelThongTin";
            this.PanelThongTin.Size = new System.Drawing.Size(884, 83);
            this.PanelThongTin.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.cboKhoNhan);
            this.groupControl3.Controls.Add(this.txtChuThich);
            this.groupControl3.Controls.Add(this.labelControl12);
            this.groupControl3.Controls.Add(this.cboNguoiGiao);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(704, 83);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Thông tin Chung";
            // 
            // cboKhoNhan
            // 
            this.cboKhoNhan.EnterMoveNextControl = true;
            this.cboKhoNhan.Location = new System.Drawing.Point(73, 28);
            this.cboKhoNhan.Name = "cboKhoNhan";
            this.cboKhoNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhoNhan.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MatHang", "MatHang", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.cboKhoNhan.Properties.DropDownRows = 15;
            this.cboKhoNhan.Properties.NullText = " -- Kho nhận --";
            this.cboKhoNhan.Properties.PopupFormMinSize = new System.Drawing.Size(363, 0);
            this.cboKhoNhan.Properties.PopupWidth = 363;
            this.cboKhoNhan.Properties.ShowFooter = false;
            this.cboKhoNhan.Properties.ShowHeader = false;
            this.cboKhoNhan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboKhoNhan.Size = new System.Drawing.Size(380, 20);
            this.cboKhoNhan.TabIndex = 0;
            // 
            // txtChuThich
            // 
            this.txtChuThich.EnterMoveNextControl = true;
            this.txtChuThich.Location = new System.Drawing.Point(73, 54);
            this.txtChuThich.Name = "txtChuThich";
            this.txtChuThich.Properties.MaxLength = 300;
            this.txtChuThich.Size = new System.Drawing.Size(616, 20);
            this.txtChuThich.TabIndex = 2;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(22, 57);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(45, 13);
            this.labelControl12.TabIndex = 28;
            this.labelControl12.Text = "Chú thích";
            // 
            // cboNguoiGiao
            // 
            this.cboNguoiGiao.EnterMoveNextControl = true;
            this.cboNguoiGiao.Location = new System.Drawing.Point(529, 28);
            this.cboNguoiGiao.Name = "cboNguoiGiao";
            this.cboNguoiGiao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNguoiGiao.Properties.ImmediatePopup = true;
            this.cboNguoiGiao.Properties.NullText = " -- Người giao --";
            this.cboNguoiGiao.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboNguoiGiao.Properties.PopupFormMinSize = new System.Drawing.Size(156, 220);
            this.cboNguoiGiao.Properties.PopupFormSize = new System.Drawing.Size(156, 220);
            this.cboNguoiGiao.Properties.ShowFooter = false;
            this.cboNguoiGiao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboNguoiGiao.Properties.ValidateOnEnterKey = true;
            this.cboNguoiGiao.Properties.View = this.cboNguoiGiaoView;
            this.cboNguoiGiao.Size = new System.Drawing.Size(160, 20);
            this.cboNguoiGiao.TabIndex = 1;
            // 
            // cboNguoiGiaoView
            // 
            this.cboNguoiGiaoView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cboNguoiGiaoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cboNguoiGiao_Ten});
            this.cboNguoiGiaoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboNguoiGiaoView.IndicatorWidth = 10;
            this.cboNguoiGiaoView.Name = "cboNguoiGiaoView";
            this.cboNguoiGiaoView.OptionsBehavior.Editable = false;
            this.cboNguoiGiaoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboNguoiGiaoView.OptionsSelection.InvertSelection = true;
            this.cboNguoiGiaoView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboNguoiGiaoView.OptionsView.ShowColumnHeaders = false;
            this.cboNguoiGiaoView.OptionsView.ShowGroupPanel = false;
            this.cboNguoiGiaoView.OptionsView.ShowIndicator = false;
            // 
            // cboNguoiGiao_Ten
            // 
            this.cboNguoiGiao_Ten.Caption = "Tên";
            this.cboNguoiGiao_Ten.FieldName = "Ten";
            this.cboNguoiGiao_Ten.Name = "cboNguoiGiao_Ten";
            this.cboNguoiGiao_Ten.OptionsFilter.AllowAutoFilter = false;
            this.cboNguoiGiao_Ten.OptionsFilter.AllowFilter = false;
            this.cboNguoiGiao_Ten.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.cboNguoiGiao_Ten.Visible = true;
            this.cboNguoiGiao_Ten.VisibleIndex = 0;
            this.cboNguoiGiao_Ten.Width = 70;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(472, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Người giao";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(22, 31);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Kho nhận";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtNgayTao);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtSoPhieu);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(704, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(180, 83);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin Phiếu chuyển";
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Location = new System.Drawing.Point(59, 54);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.Properties.ReadOnly = true;
            this.txtNgayTao.Size = new System.Drawing.Size(100, 20);
            this.txtNgayTao.TabIndex = 1;
            this.txtNgayTao.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 57);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Ngày tạo";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(59, 28);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Properties.ReadOnly = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(100, 20);
            this.txtSoPhieu.TabIndex = 0;
            this.txtSoPhieu.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Số phiếu";
            // 
            // ToolbarMv
            // 
            this.ToolbarMv.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarMv.Appearance.Options.UseBackColor = true;
            this.ToolbarMv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolbarMv.Location = new System.Drawing.Point(0, 573);
            this.ToolbarMv.Name = "ToolbarMv";
            this.ToolbarMv.SenderName = INVENTORY.CONTROL.ToolbarMv.Action.None;
            this.ToolbarMv.Size = new System.Drawing.Size(884, 28);
            this.ToolbarMv.TabIndex = 2;
            this.ToolbarMv.Clicked += new System.EventHandler(this.ToolbarMv_Clicked);
            // 
            // frmPhieuChuyenEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 601);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.ToolbarMv);
            this.Controls.Add(this.PanelThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhieuChuyenEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa đổi Phiếu chuyển";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhieuChuyenEdit_FormClosing);
            this.Load += new System.EventHandler(this.frmPhieuChuyenEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_txtChuThich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatTuView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            this.MainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelThongTin)).EndInit();
            this.PanelThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguoiGiao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguoiGiaoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker brgWorker;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl PanelThongTin;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SpinEdit txtSoLuong;
        private DevExpress.XtraEditors.SimpleButton cmdXoa;
        private DevExpress.XtraEditors.SimpleButton cmdChon;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtNgayTao;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSoPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LookUpEdit cboKhoNhan;
        private DevExpress.XtraEditors.TextEdit txtChuThich;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.GridLookUpEdit cboNguoiGiao;
        private DevExpress.XtraGrid.Views.Grid.GridView cboNguoiGiaoView;
        private DevExpress.XtraGrid.Columns.GridColumn cboNguoiGiao_Ten;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private INVENTORY.CONTROL.ToolbarMv ToolbarMv;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private DevExpress.XtraEditors.GridLookUpEdit cboLoaiVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView cboLoaiVatTuView;
        private DevExpress.XtraGrid.Columns.GridColumn cboLoaiVatTu_Ten;
        private DevExpress.XtraGrid.Columns.GridColumn cboLoaiVatTu_QuyCach;
        private DevExpress.XtraGrid.Columns.GridColumn cboLoaiVatTu_TenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn cboLoaiVatTu_SoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn QuyCach;
        private DevExpress.XtraGrid.Columns.GridColumn TenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn ChuThich;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit gridMain_txtChuThich;
    }
}
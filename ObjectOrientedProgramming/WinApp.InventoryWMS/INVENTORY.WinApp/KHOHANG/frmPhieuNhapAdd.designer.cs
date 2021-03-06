namespace INVENTORY.WinApp.KHOHANG
{
    partial class frmPhieuNhapAdd
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
            this.PanelSanPham = new DevExpress.XtraEditors.GroupControl();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.MenuNhap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThayDoi = new System.Windows.Forms.ToolStripMenuItem();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_spSoLuong = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.ChuThich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_txtChuThich = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmdThem = new DevExpress.XtraEditors.SimpleButton();
            this.cmdThayDoi = new DevExpress.XtraEditors.SimpleButton();
            this.cmdXoa = new DevExpress.XtraEditors.SimpleButton();
            this.cboLoaiVatTu = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cboLoaiVatTuView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboLoaiVatTu_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboLoaiVatTu_QuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboLoaiVatTu_TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.brgWorker = new System.ComponentModel.BackgroundWorker();
            this.PanelThongTin = new DevExpress.XtraEditors.PanelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.cboNguonNhap = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cboNguonNhapView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboNguonNhap_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboNguonNhap_DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboNguonNhap_ChuThich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtChuThich = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtNgayTao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoPhieu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ToolbarMv = new INVENTORY.CONTROL.ToolbarMv();
            ((System.ComponentModel.ISupportInitialize)(this.PanelSanPham)).BeginInit();
            this.PanelSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.MenuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_spSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_txtChuThich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatTuView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelThongTin)).BeginInit();
            this.PanelThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguonNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguonNhapView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSanPham
            // 
            this.PanelSanPham.Controls.Add(this.gridMain);
            this.PanelSanPham.Controls.Add(this.panelControl1);
            this.PanelSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSanPham.Location = new System.Drawing.Point(0, 83);
            this.PanelSanPham.Name = "PanelSanPham";
            this.PanelSanPham.Size = new System.Drawing.Size(884, 490);
            this.PanelSanPham.TabIndex = 1;
            this.PanelSanPham.Text = "Thông tin Sản phẩm";
            // 
            // gridMain
            // 
            this.gridMain.ContextMenuStrip = this.MenuNhap;
            this.gridMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(2, 53);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gridMain_spSoLuong,
            this.gridMain_txtChuThich});
            this.gridMain.Size = new System.Drawing.Size(880, 435);
            this.gridMain.TabIndex = 1;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
            this.gridMain.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridMain_ProcessGridKey);
            // 
            // MenuNhap
            // 
            this.MenuNhap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXoa,
            this.mnuThayDoi});
            this.MenuNhap.Name = "MenuNhap";
            this.MenuNhap.Size = new System.Drawing.Size(139, 48);
            this.MenuNhap.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuNhap_ItemClicked);
            // 
            // mnuXoa
            // 
            this.mnuXoa.Image = global::INVENTORY.WinApp.Properties.Resources.delete;
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuXoa.Size = new System.Drawing.Size(138, 22);
            this.mnuXoa.Text = "Xóa";
            // 
            // mnuThayDoi
            // 
            this.mnuThayDoi.Image = global::INVENTORY.WinApp.Properties.Resources.table_edit;
            this.mnuThayDoi.Name = "mnuThayDoi";
            this.mnuThayDoi.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuThayDoi.Size = new System.Drawing.Size(138, 22);
            this.mnuThayDoi.Text = "Thay đổi";
            // 
            // gridMainView
            // 
            this.gridMainView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
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
            this.SoLuong.ColumnEdit = this.gridMain_spSoLuong;
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
            this.SoLuong.VisibleIndex = 3;
            this.SoLuong.Width = 60;
            // 
            // gridMain_spSoLuong
            // 
            this.gridMain_spSoLuong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridMain_spSoLuong.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.gridMain_spSoLuong.IsFloatValue = false;
            this.gridMain_spSoLuong.Mask.EditMask = "N00";
            this.gridMain_spSoLuong.Mask.UseMaskAsDisplayFormat = true;
            this.gridMain_spSoLuong.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.gridMain_spSoLuong.Name = "gridMain_spSoLuong";
            this.gridMain_spSoLuong.NullText = "0";
            this.gridMain_spSoLuong.ValidateOnEnterKey = true;
            this.gridMain_spSoLuong.EditValueChanged += new System.EventHandler(this.gridMain_spSoLuong_EditValueChanged);
            // 
            // ChuThich
            // 
            this.ChuThich.Caption = "Chú thích";
            this.ChuThich.ColumnEdit = this.gridMain_txtChuThich;
            this.ChuThich.FieldName = "ChuThich";
            this.ChuThich.Name = "ChuThich";
            this.ChuThich.OptionsColumn.AllowEdit = false;
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
            this.panelControl1.Controls.Add(this.cmdThem);
            this.panelControl1.Controls.Add(this.cmdThayDoi);
            this.panelControl1.Controls.Add(this.cmdXoa);
            this.panelControl1.Controls.Add(this.cboLoaiVatTu);
            this.panelControl1.Controls.Add(this.txtSoLuong);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(880, 32);
            this.panelControl1.TabIndex = 0;
            // 
            // cmdThem
            // 
            this.cmdThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdThem.Image = global::INVENTORY.WinApp.Properties.Resources.accept;
            this.cmdThem.Location = new System.Drawing.Point(549, 6);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(100, 20);
            this.cmdThem.TabIndex = 2;
            this.cmdThem.Text = "Thêm (Enter)";
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cmdThayDoi
            // 
            this.cmdThayDoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdThayDoi.Image = global::INVENTORY.WinApp.Properties.Resources.table_edit;
            this.cmdThayDoi.Location = new System.Drawing.Point(761, 6);
            this.cmdThayDoi.Name = "cmdThayDoi";
            this.cmdThayDoi.Size = new System.Drawing.Size(100, 20);
            this.cmdThayDoi.TabIndex = 4;
            this.cmdThayDoi.Text = "Thay đổi (F2)";
            this.cmdThayDoi.Click += new System.EventHandler(this.cmdThayDoi_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdXoa.Image = global::INVENTORY.WinApp.Properties.Resources.delete;
            this.cmdXoa.Location = new System.Drawing.Point(655, 6);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(100, 20);
            this.cmdXoa.TabIndex = 3;
            this.cmdXoa.Text = "Xóa (Del)";
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
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
            this.cboLoaiVatTu.Size = new System.Drawing.Size(406, 20);
            this.cboLoaiVatTu.TabIndex = 0;
            // 
            // cboLoaiVatTuView
            // 
            this.cboLoaiVatTuView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cboLoaiVatTuView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cboLoaiVatTu_Ten,
            this.cboLoaiVatTu_QuyCach,
            this.cboLoaiVatTu_TenDonViTinh});
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
            this.cboLoaiVatTu_Ten.Width = 213;
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
            // txtSoLuong
            // 
            this.txtSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoLuong.Location = new System.Drawing.Point(483, 6);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtSoLuong.Properties.IsFloatValue = false;
            this.txtSoLuong.Properties.Mask.EditMask = "N00";
            this.txtSoLuong.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtSoLuong.Size = new System.Drawing.Size(60, 20);
            this.txtSoLuong.TabIndex = 1;
            this.txtSoLuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoLuong_KeyDown);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 9);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 13);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Loại vật tư";
            // 
            // brgWorker
            // 
            this.brgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.brgWorker_DoWork);
            this.brgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.brgWorker_RunWorkerCompleted);
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
            this.groupControl3.Controls.Add(this.cboNguonNhap);
            this.groupControl3.Controls.Add(this.txtChuThich);
            this.groupControl3.Controls.Add(this.labelControl10);
            this.groupControl3.Controls.Add(this.labelControl11);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(704, 83);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Thông tin Chung";
            // 
            // cboNguonNhap
            // 
            this.cboNguonNhap.EnterMoveNextControl = true;
            this.cboNguonNhap.Location = new System.Drawing.Point(73, 28);
            this.cboNguonNhap.Name = "cboNguonNhap";
            this.cboNguonNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNguonNhap.Properties.ImmediatePopup = true;
            this.cboNguonNhap.Properties.NullText = " -- Nguồn nhập --";
            this.cboNguonNhap.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboNguonNhap.Properties.PopupFormMinSize = new System.Drawing.Size(786, 0);
            this.cboNguonNhap.Properties.PopupFormSize = new System.Drawing.Size(786, 0);
            this.cboNguonNhap.Properties.ShowFooter = false;
            this.cboNguonNhap.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboNguonNhap.Properties.ValidateOnEnterKey = true;
            this.cboNguonNhap.Properties.View = this.cboNguonNhapView;
            this.cboNguonNhap.Size = new System.Drawing.Size(616, 20);
            this.cboNguonNhap.TabIndex = 0;
            // 
            // cboNguonNhapView
            // 
            this.cboNguonNhapView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cboNguonNhapView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cboNguonNhap_Ten,
            this.cboNguonNhap_DiaChi,
            this.cboNguonNhap_ChuThich});
            this.cboNguonNhapView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboNguonNhapView.FooterPanelHeight = 5;
            this.cboNguonNhapView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Ten", this.cboNguonNhap_Ten, "Tổng cộng: {0} loại vật tư")});
            this.cboNguonNhapView.IndicatorWidth = 10;
            this.cboNguonNhapView.Name = "cboNguonNhapView";
            this.cboNguonNhapView.OptionsBehavior.Editable = false;
            this.cboNguonNhapView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboNguonNhapView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboNguonNhapView.OptionsView.ShowGroupPanel = false;
            // 
            // cboNguonNhap_Ten
            // 
            this.cboNguonNhap_Ten.Caption = "Tên";
            this.cboNguonNhap_Ten.FieldName = "Ten";
            this.cboNguonNhap_Ten.Name = "cboNguonNhap_Ten";
            this.cboNguonNhap_Ten.OptionsFilter.AllowFilter = false;
            this.cboNguonNhap_Ten.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.cboNguonNhap_Ten.Visible = true;
            this.cboNguonNhap_Ten.VisibleIndex = 0;
            this.cboNguonNhap_Ten.Width = 300;
            // 
            // cboNguonNhap_DiaChi
            // 
            this.cboNguonNhap_DiaChi.Caption = "Địa chỉ";
            this.cboNguonNhap_DiaChi.FieldName = "DiaChi";
            this.cboNguonNhap_DiaChi.Name = "cboNguonNhap_DiaChi";
            this.cboNguonNhap_DiaChi.OptionsColumn.FixedWidth = true;
            this.cboNguonNhap_DiaChi.OptionsFilter.AllowFilter = false;
            this.cboNguonNhap_DiaChi.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.cboNguonNhap_DiaChi.Visible = true;
            this.cboNguonNhap_DiaChi.VisibleIndex = 1;
            this.cboNguonNhap_DiaChi.Width = 150;
            // 
            // cboNguonNhap_ChuThich
            // 
            this.cboNguonNhap_ChuThich.Caption = "Chú thích";
            this.cboNguonNhap_ChuThich.FieldName = "ChuThich";
            this.cboNguonNhap_ChuThich.Name = "cboNguonNhap_ChuThich";
            this.cboNguonNhap_ChuThich.OptionsColumn.FixedWidth = true;
            this.cboNguonNhap_ChuThich.OptionsFilter.AllowFilter = false;
            this.cboNguonNhap_ChuThich.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.cboNguonNhap_ChuThich.Visible = true;
            this.cboNguonNhap_ChuThich.VisibleIndex = 2;
            this.cboNguonNhap_ChuThich.Width = 100;
            // 
            // txtChuThich
            // 
            this.txtChuThich.EnterMoveNextControl = true;
            this.txtChuThich.Location = new System.Drawing.Point(73, 54);
            this.txtChuThich.Name = "txtChuThich";
            this.txtChuThich.Properties.MaxLength = 255;
            this.txtChuThich.Size = new System.Drawing.Size(616, 20);
            this.txtChuThich.TabIndex = 1;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(9, 31);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(58, 13);
            this.labelControl10.TabIndex = 14;
            this.labelControl10.Text = "Nguồn nhập";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(22, 57);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(45, 13);
            this.labelControl11.TabIndex = 16;
            this.labelControl11.Text = "Chú thích";
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
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin Phiếu nhập";
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
            this.txtSoPhieu.EnterMoveNextControl = true;
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
            // frmPhieuNhapAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 601);
            this.Controls.Add(this.PanelSanPham);
            this.Controls.Add(this.ToolbarMv);
            this.Controls.Add(this.PanelThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhieuNhapAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo mới Phiếu nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhieuNhapAdd_FormClosing);
            this.Load += new System.EventHandler(this.frmPhieuNhapAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelSanPham)).EndInit();
            this.PanelSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.MenuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_spSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_txtChuThich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatTuView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelThongTin)).EndInit();
            this.PanelThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguonNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguonNhapView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl PanelSanPham;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private System.ComponentModel.BackgroundWorker brgWorker;
        private System.Windows.Forms.ContextMenuStrip MenuNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private DevExpress.XtraEditors.PanelControl PanelThongTin;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtNgayTao;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSoPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txtChuThich;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private INVENTORY.CONTROL.ToolbarMv ToolbarMv;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SpinEdit txtSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.GridLookUpEdit cboLoaiVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView cboLoaiVatTuView;
        private DevExpress.XtraGrid.Columns.GridColumn cboLoaiVatTu_Ten;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit gridMain_spSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn TenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraEditors.SimpleButton cmdThem;
        private DevExpress.XtraEditors.SimpleButton cmdXoa;
        private DevExpress.XtraGrid.Columns.GridColumn cboLoaiVatTu_TenDonViTinh;
        private DevExpress.XtraEditors.GridLookUpEdit cboNguonNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView cboNguonNhapView;
        private DevExpress.XtraGrid.Columns.GridColumn cboNguonNhap_Ten;
        private DevExpress.XtraGrid.Columns.GridColumn cboNguonNhap_DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn cboNguonNhap_ChuThich;
        private DevExpress.XtraGrid.Columns.GridColumn ChuThich;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit gridMain_txtChuThich;
        private DevExpress.XtraEditors.SimpleButton cmdThayDoi;
        private DevExpress.XtraGrid.Columns.GridColumn cboLoaiVatTu_QuyCach;
        private DevExpress.XtraGrid.Columns.GridColumn QuyCach;
        private System.Windows.Forms.ToolStripMenuItem mnuThayDoi;
    }
}
namespace INVENTORY.WinApp.KHOHANG
{
    partial class frmPhieuXuatAdd
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
            this.PanelThongTin = new DevExpress.XtraEditors.PanelControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.cboNguoiNhan = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cboNguoiNhanView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboNguoiNhan_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtChuThich = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cboBoPhan = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cboBoPhanView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboBoPhan_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboBoPhan_ChuThich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtNgayTao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoPhieu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cboLoaiVatTu = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cboLoaiVatTuView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboLoaiVatTu_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboLoaiVatTu_QuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboLoaiVatTu_TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboLoaiVatTu_SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.cmdXoa = new DevExpress.XtraEditors.SimpleButton();
            this.cmdChon = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.PanelSanPham = new DevExpress.XtraEditors.GroupControl();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChuThich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_txtChuThich = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolbarMv = new INVENTORY.CONTROL.ToolbarMv();
            ((System.ComponentModel.ISupportInitialize)(this.PanelThongTin)).BeginInit();
            this.PanelThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguoiNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguoiNhanView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBoPhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBoPhanView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatTuView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelSanPham)).BeginInit();
            this.PanelSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_txtChuThich)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // brgWorker
            // 
            this.brgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.brgWorker_DoWork);
            this.brgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.brgWorker_RunWorkerCompleted);
            // 
            // PanelThongTin
            // 
            this.PanelThongTin.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelThongTin.Controls.Add(this.groupControl5);
            this.PanelThongTin.Controls.Add(this.groupControl2);
            this.PanelThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelThongTin.Location = new System.Drawing.Point(0, 0);
            this.PanelThongTin.Name = "PanelThongTin";
            this.PanelThongTin.Size = new System.Drawing.Size(884, 83);
            this.PanelThongTin.TabIndex = 0;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.cboNguoiNhan);
            this.groupControl5.Controls.Add(this.labelControl7);
            this.groupControl5.Controls.Add(this.txtChuThich);
            this.groupControl5.Controls.Add(this.labelControl10);
            this.groupControl5.Controls.Add(this.cboBoPhan);
            this.groupControl5.Controls.Add(this.labelControl13);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(0, 0);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(704, 83);
            this.groupControl5.TabIndex = 0;
            this.groupControl5.Text = "Thông tin Chung";
            // 
            // cboNguoiNhan
            // 
            this.cboNguoiNhan.EnterMoveNextControl = true;
            this.cboNguoiNhan.Location = new System.Drawing.Point(529, 28);
            this.cboNguoiNhan.Name = "cboNguoiNhan";
            this.cboNguoiNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNguoiNhan.Properties.ImmediatePopup = true;
            this.cboNguoiNhan.Properties.NullText = " -- Người nhận --";
            this.cboNguoiNhan.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboNguoiNhan.Properties.PopupFormMinSize = new System.Drawing.Size(156, 220);
            this.cboNguoiNhan.Properties.PopupFormSize = new System.Drawing.Size(156, 220);
            this.cboNguoiNhan.Properties.ShowFooter = false;
            this.cboNguoiNhan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboNguoiNhan.Properties.ValidateOnEnterKey = true;
            this.cboNguoiNhan.Properties.View = this.cboNguoiNhanView;
            this.cboNguoiNhan.Size = new System.Drawing.Size(160, 20);
            this.cboNguoiNhan.TabIndex = 3;
            // 
            // cboNguoiNhanView
            // 
            this.cboNguoiNhanView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cboNguoiNhanView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cboNguoiNhan_Ten});
            this.cboNguoiNhanView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboNguoiNhanView.IndicatorWidth = 10;
            this.cboNguoiNhanView.Name = "cboNguoiNhanView";
            this.cboNguoiNhanView.OptionsBehavior.Editable = false;
            this.cboNguoiNhanView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboNguoiNhanView.OptionsSelection.InvertSelection = true;
            this.cboNguoiNhanView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboNguoiNhanView.OptionsView.ShowColumnHeaders = false;
            this.cboNguoiNhanView.OptionsView.ShowGroupPanel = false;
            this.cboNguoiNhanView.OptionsView.ShowIndicator = false;
            // 
            // cboNguoiNhan_Ten
            // 
            this.cboNguoiNhan_Ten.Caption = "Tên";
            this.cboNguoiNhan_Ten.FieldName = "Ten";
            this.cboNguoiNhan_Ten.Name = "cboNguoiNhan_Ten";
            this.cboNguoiNhan_Ten.OptionsFilter.AllowAutoFilter = false;
            this.cboNguoiNhan_Ten.OptionsFilter.AllowFilter = false;
            this.cboNguoiNhan_Ten.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.cboNguoiNhan_Ten.Visible = true;
            this.cboNguoiNhan_Ten.VisibleIndex = 0;
            this.cboNguoiNhan_Ten.Width = 70;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(468, 31);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 13);
            this.labelControl7.TabIndex = 34;
            this.labelControl7.Text = "Người nhận";
            // 
            // txtChuThich
            // 
            this.txtChuThich.EnterMoveNextControl = true;
            this.txtChuThich.Location = new System.Drawing.Point(73, 54);
            this.txtChuThich.Name = "txtChuThich";
            this.txtChuThich.Properties.MaxLength = 300;
            this.txtChuThich.Size = new System.Drawing.Size(616, 20);
            this.txtChuThich.TabIndex = 4;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(22, 57);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(45, 13);
            this.labelControl10.TabIndex = 32;
            this.labelControl10.Text = "Chú thích";
            // 
            // cboBoPhan
            // 
            this.cboBoPhan.EnterMoveNextControl = true;
            this.cboBoPhan.Location = new System.Drawing.Point(73, 28);
            this.cboBoPhan.Name = "cboBoPhan";
            this.cboBoPhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBoPhan.Properties.ImmediatePopup = true;
            this.cboBoPhan.Properties.NullText = " -- Bộ phận --";
            this.cboBoPhan.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboBoPhan.Properties.PopupFormMinSize = new System.Drawing.Size(786, 0);
            this.cboBoPhan.Properties.PopupFormSize = new System.Drawing.Size(786, 0);
            this.cboBoPhan.Properties.ShowFooter = false;
            this.cboBoPhan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboBoPhan.Properties.ValidateOnEnterKey = true;
            this.cboBoPhan.Properties.View = this.cboBoPhanView;
            this.cboBoPhan.Size = new System.Drawing.Size(380, 20);
            this.cboBoPhan.TabIndex = 0;
            this.cboBoPhan.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.cboBoPhan_CloseUp);
            // 
            // cboBoPhanView
            // 
            this.cboBoPhanView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cboBoPhanView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cboBoPhan_Ten,
            this.cboBoPhan_ChuThich});
            this.cboBoPhanView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboBoPhanView.FooterPanelHeight = 5;
            this.cboBoPhanView.IndicatorWidth = 10;
            this.cboBoPhanView.Name = "cboBoPhanView";
            this.cboBoPhanView.OptionsBehavior.Editable = false;
            this.cboBoPhanView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboBoPhanView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboBoPhanView.OptionsView.ShowGroupPanel = false;
            // 
            // cboBoPhan_Ten
            // 
            this.cboBoPhan_Ten.Caption = "Tên";
            this.cboBoPhan_Ten.FieldName = "Ten";
            this.cboBoPhan_Ten.Name = "cboBoPhan_Ten";
            this.cboBoPhan_Ten.OptionsColumn.FixedWidth = true;
            this.cboBoPhan_Ten.OptionsFilter.AllowFilter = false;
            this.cboBoPhan_Ten.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.cboBoPhan_Ten.Visible = true;
            this.cboBoPhan_Ten.VisibleIndex = 0;
            this.cboBoPhan_Ten.Width = 300;
            // 
            // cboBoPhan_ChuThich
            // 
            this.cboBoPhan_ChuThich.Caption = "Chú thích";
            this.cboBoPhan_ChuThich.FieldName = "ChuThich";
            this.cboBoPhan_ChuThich.Name = "cboBoPhan_ChuThich";
            this.cboBoPhan_ChuThich.OptionsFilter.AllowFilter = false;
            this.cboBoPhan_ChuThich.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.cboBoPhan_ChuThich.Visible = true;
            this.cboBoPhan_ChuThich.VisibleIndex = 1;
            this.cboBoPhan_ChuThich.Width = 83;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(28, 31);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(39, 13);
            this.labelControl13.TabIndex = 14;
            this.labelControl13.Text = "Bộ phận";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtNgayTao);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtSoPhieu);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(704, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(180, 83);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông tin Phiếu xuất";
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Ngày tạo";
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
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Số phiếu";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.cboLoaiVatTu);
            this.panelControl2.Controls.Add(this.txtSoLuong);
            this.panelControl2.Controls.Add(this.cmdXoa);
            this.panelControl2.Controls.Add(this.cmdChon);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 21);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(880, 32);
            this.panelControl2.TabIndex = 0;
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
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 9);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 13);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Loại vật tư";
            // 
            // PanelSanPham
            // 
            this.PanelSanPham.Controls.Add(this.gridMain);
            this.PanelSanPham.Controls.Add(this.panelControl2);
            this.PanelSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSanPham.Location = new System.Drawing.Point(0, 83);
            this.PanelSanPham.Name = "PanelSanPham";
            this.PanelSanPham.Size = new System.Drawing.Size(884, 490);
            this.PanelSanPham.TabIndex = 1;
            this.PanelSanPham.Text = "Thông tin Sản phẩm";
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
            this.Id.OptionsFilter.AllowFilter = false;
            this.Id.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
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
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXoa});
            this.MainMenu.Name = "MenuNhap";
            this.MainMenu.Size = new System.Drawing.Size(119, 26);
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
            // 
            // mnuXoa
            // 
            this.mnuXoa.Image = global::INVENTORY.WinApp.Properties.Resources.delete;
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuXoa.Size = new System.Drawing.Size(118, 22);
            this.mnuXoa.Text = "Xóa";
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
            // frmPhieuXuatAdd
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
            this.Name = "frmPhieuXuatAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo mới Phiếu xuất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhieuXuatAdd_FormClosing);
            this.Load += new System.EventHandler(this.frmPhieuXuatAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelThongTin)).EndInit();
            this.PanelThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguoiNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguoiNhanView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBoPhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBoPhanView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatTuView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelSanPham)).EndInit();
            this.PanelSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_txtChuThich)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker brgWorker;
        private DevExpress.XtraEditors.PanelControl PanelThongTin;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SpinEdit txtSoLuong;
        private DevExpress.XtraEditors.SimpleButton cmdXoa;
        private DevExpress.XtraEditors.SimpleButton cmdChon;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtNgayTao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSoPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl PanelSanPham;
        private INVENTORY.CONTROL.ToolbarMv ToolbarMv;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GridLookUpEdit cboNguoiNhan;
        private DevExpress.XtraGrid.Views.Grid.GridView cboNguoiNhanView;
        private DevExpress.XtraGrid.Columns.GridColumn cboNguoiNhan_Ten;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtChuThich;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GridLookUpEdit cboBoPhan;
        private DevExpress.XtraGrid.Views.Grid.GridView cboBoPhanView;
        private DevExpress.XtraGrid.Columns.GridColumn cboBoPhan_Ten;
        private DevExpress.XtraGrid.Columns.GridColumn cboBoPhan_ChuThich;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.GridLookUpEdit cboLoaiVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView cboLoaiVatTuView;
        private DevExpress.XtraGrid.Columns.GridColumn cboLoaiVatTu_Ten;
        private DevExpress.XtraGrid.Columns.GridColumn cboLoaiVatTu_QuyCach;
        private DevExpress.XtraGrid.Columns.GridColumn cboLoaiVatTu_TenDonViTinh;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn QuyCach;
        private DevExpress.XtraGrid.Columns.GridColumn TenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn ChuThich;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit gridMain_txtChuThich;
        private DevExpress.XtraGrid.Columns.GridColumn cboLoaiVatTu_SoLuong;
    }
}
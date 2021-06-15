namespace INVENTORY.WinApp.KHOHANG
{
    partial class frmPhieuNhapNb
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
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.MenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuThayDoi = new System.Windows.Forms.ToolStripMenuItem();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKhoChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNguoiTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChuThich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToolbarGia = new INVENTORY.CONTROL.ToolbarGia();
            this.splitMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridChiTiet = new DevExpress.XtraGrid.GridControl();
            this.gridChiTietView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridChiTiet_TenLoaiVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridChiTiet_QuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridChiTiet_TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridChiTiet_SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridChiTiet_ChuThich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.brgWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.MenuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTietView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMain
            // 
            this.gridMain.ContextMenuStrip = this.MenuMain;
            this.gridMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(0, 0);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(1394, 434);
            this.gridMain.TabIndex = 0;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
            this.gridMain.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridMain_ProcessGridKey);
            // 
            // MenuMain
            // 
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThayDoi});
            this.MenuMain.Name = "ToChucMenu";
            this.MenuMain.Size = new System.Drawing.Size(193, 26);
            this.MenuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuMain_ItemClicked);
            // 
            // mnuThayDoi
            // 
            this.mnuThayDoi.Image = global::INVENTORY.WinApp.Properties.Resources.table_edit;
            this.mnuThayDoi.Name = "mnuThayDoi";
            this.mnuThayDoi.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuThayDoi.Size = new System.Drawing.Size(192, 22);
            this.mnuThayDoi.Text = "Thay đổi Kho nhận";
            // 
            // gridMainView
            // 
            this.gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.TrangThai,
            this.SoPhieu,
            this.TenKhoChuyen,
            this.TenTrangThai,
            this.TenNguoiTao,
            this.NgayTao,
            this.ChuThich});
            this.gridMainView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.GroupPanelText = "Kéo cột tương ứng thả vào đây để nhóm dữ liệu";
            this.gridMainView.IndicatorWidth = 37;
            this.gridMainView.Name = "gridMainView";
            this.gridMainView.OptionsBehavior.Editable = false;
            this.gridMainView.OptionsView.ShowAutoFilterRow = true;
            this.gridMainView.OptionsView.ShowDetailButtons = false;
            this.gridMainView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridMainView_CustomDrawRowIndicator);
            this.gridMainView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridMainView_FocusedRowChanged);
            this.gridMainView.DoubleClick += new System.EventHandler(this.gridMainView_DoubleClick);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.OptionsColumn.AllowEdit = false;
            this.Id.OptionsColumn.ReadOnly = true;
            this.Id.OptionsFilter.AllowFilter = false;
            this.Id.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // TrangThai
            // 
            this.TrangThai.Caption = "TrangThai";
            this.TrangThai.FieldName = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.OptionsFilter.AllowFilter = false;
            this.TrangThai.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
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
            this.SoPhieu.VisibleIndex = 0;
            this.SoPhieu.Width = 85;
            // 
            // TenKhoChuyen
            // 
            this.TenKhoChuyen.Caption = "Kho chuyển";
            this.TenKhoChuyen.FieldName = "TenKhoChuyen";
            this.TenKhoChuyen.Name = "TenKhoChuyen";
            this.TenKhoChuyen.OptionsColumn.FixedWidth = true;
            this.TenKhoChuyen.OptionsFilter.AllowFilter = false;
            this.TenKhoChuyen.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenKhoChuyen.Visible = true;
            this.TenKhoChuyen.VisibleIndex = 1;
            this.TenKhoChuyen.Width = 250;
            // 
            // TenTrangThai
            // 
            this.TenTrangThai.AppearanceHeader.Options.UseTextOptions = true;
            this.TenTrangThai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenTrangThai.Caption = "Trạng thái";
            this.TenTrangThai.FieldName = "TenTrangThai";
            this.TenTrangThai.Name = "TenTrangThai";
            this.TenTrangThai.OptionsColumn.FixedWidth = true;
            this.TenTrangThai.OptionsFilter.AllowFilter = false;
            this.TenTrangThai.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenTrangThai.Visible = true;
            this.TenTrangThai.VisibleIndex = 2;
            this.TenTrangThai.Width = 80;
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
            this.NgayTao.Width = 100;
            // 
            // ChuThich
            // 
            this.ChuThich.Caption = "Chú thích";
            this.ChuThich.FieldName = "ChuThich";
            this.ChuThich.Name = "ChuThich";
            this.ChuThich.OptionsFilter.AllowFilter = false;
            this.ChuThich.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ChuThich.Visible = true;
            this.ChuThich.VisibleIndex = 5;
            this.ChuThich.Width = 708;
            // 
            // ToolbarGia
            // 
            this.ToolbarGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolbarGia.Location = new System.Drawing.Point(0, 0);
            this.ToolbarGia.Name = "ToolbarGia";
            this.ToolbarGia.SenderName = INVENTORY.CONTROL.ToolbarGia.Action.None;
            this.ToolbarGia.Size = new System.Drawing.Size(1394, 28);
            this.ToolbarGia.TabIndex = 0;
            this.ToolbarGia.Clicked += new System.EventHandler(this.ToolbarGia_Clicked);
            // 
            // splitMain
            // 
            this.splitMain.Collapsed = true;
            this.splitMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitMain.Horizontal = false;
            this.splitMain.Location = new System.Drawing.Point(0, 28);
            this.splitMain.Name = "splitMain";
            this.splitMain.Panel1.Controls.Add(this.gridMain);
            this.splitMain.Panel1.Text = "Panel1";
            this.splitMain.Panel2.Controls.Add(this.groupControl1);
            this.splitMain.Panel2.Text = "Panel2";
            this.splitMain.Size = new System.Drawing.Size(1394, 640);
            this.splitMain.SplitterPosition = 200;
            this.splitMain.TabIndex = 1;
            this.splitMain.Text = "splitMain";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridChiTiet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1394, 200);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin Chi tiết";
            // 
            // gridChiTiet
            // 
            this.gridChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridChiTiet.Location = new System.Drawing.Point(2, 21);
            this.gridChiTiet.MainView = this.gridChiTietView;
            this.gridChiTiet.Name = "gridChiTiet";
            this.gridChiTiet.Size = new System.Drawing.Size(1390, 177);
            this.gridChiTiet.TabIndex = 0;
            this.gridChiTiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridChiTietView});
            // 
            // gridChiTietView
            // 
            this.gridChiTietView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridChiTietView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridChiTiet_TenLoaiVatTu,
            this.gridChiTiet_QuyCach,
            this.gridChiTiet_TenDonViTinh,
            this.gridChiTiet_SoLuong,
            this.gridChiTiet_ChuThich});
            this.gridChiTietView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridChiTietView.GridControl = this.gridChiTiet;
            this.gridChiTietView.GroupFormat = "[#image]{1} {2}";
            this.gridChiTietView.GroupPanelText = "Kéo cột tương ứng thả vào đây để nhóm dữ liệu";
            this.gridChiTietView.IndicatorWidth = 30;
            this.gridChiTietView.Name = "gridChiTietView";
            this.gridChiTietView.OptionsBehavior.Editable = false;
            this.gridChiTietView.OptionsSelection.MultiSelect = true;
            this.gridChiTietView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridChiTietView.OptionsView.ShowFooter = true;
            this.gridChiTietView.OptionsView.ShowGroupPanel = false;
            this.gridChiTietView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridMainView_CustomDrawRowIndicator);
            // 
            // gridChiTiet_TenLoaiVatTu
            // 
            this.gridChiTiet_TenLoaiVatTu.Caption = "Loại vật tư";
            this.gridChiTiet_TenLoaiVatTu.FieldName = "TenLoaiVatTu";
            this.gridChiTiet_TenLoaiVatTu.Name = "gridChiTiet_TenLoaiVatTu";
            this.gridChiTiet_TenLoaiVatTu.OptionsFilter.AllowFilter = false;
            this.gridChiTiet_TenLoaiVatTu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridChiTiet_TenLoaiVatTu.Visible = true;
            this.gridChiTiet_TenLoaiVatTu.VisibleIndex = 0;
            this.gridChiTiet_TenLoaiVatTu.Width = 700;
            // 
            // gridChiTiet_QuyCach
            // 
            this.gridChiTiet_QuyCach.Caption = "Quy cách";
            this.gridChiTiet_QuyCach.FieldName = "QuyCach";
            this.gridChiTiet_QuyCach.Name = "gridChiTiet_QuyCach";
            this.gridChiTiet_QuyCach.OptionsColumn.FixedWidth = true;
            this.gridChiTiet_QuyCach.OptionsFilter.AllowFilter = false;
            this.gridChiTiet_QuyCach.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridChiTiet_QuyCach.Visible = true;
            this.gridChiTiet_QuyCach.VisibleIndex = 1;
            this.gridChiTiet_QuyCach.Width = 150;
            // 
            // gridChiTiet_TenDonViTinh
            // 
            this.gridChiTiet_TenDonViTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.gridChiTiet_TenDonViTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridChiTiet_TenDonViTinh.Caption = "ĐVT";
            this.gridChiTiet_TenDonViTinh.FieldName = "TenDonViTinh";
            this.gridChiTiet_TenDonViTinh.Name = "gridChiTiet_TenDonViTinh";
            this.gridChiTiet_TenDonViTinh.OptionsColumn.FixedWidth = true;
            this.gridChiTiet_TenDonViTinh.OptionsFilter.AllowFilter = false;
            this.gridChiTiet_TenDonViTinh.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridChiTiet_TenDonViTinh.Visible = true;
            this.gridChiTiet_TenDonViTinh.VisibleIndex = 2;
            this.gridChiTiet_TenDonViTinh.Width = 60;
            // 
            // gridChiTiet_SoLuong
            // 
            this.gridChiTiet_SoLuong.AppearanceCell.Options.UseTextOptions = true;
            this.gridChiTiet_SoLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridChiTiet_SoLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.gridChiTiet_SoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridChiTiet_SoLuong.Caption = "Số lượng";
            this.gridChiTiet_SoLuong.DisplayFormat.FormatString = "N0";
            this.gridChiTiet_SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridChiTiet_SoLuong.FieldName = "SoLuong";
            this.gridChiTiet_SoLuong.Name = "gridChiTiet_SoLuong";
            this.gridChiTiet_SoLuong.OptionsColumn.FixedWidth = true;
            this.gridChiTiet_SoLuong.OptionsFilter.AllowFilter = false;
            this.gridChiTiet_SoLuong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridChiTiet_SoLuong.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuong", "{0:N0}")});
            this.gridChiTiet_SoLuong.Visible = true;
            this.gridChiTiet_SoLuong.VisibleIndex = 3;
            this.gridChiTiet_SoLuong.Width = 60;
            // 
            // gridChiTiet_ChuThich
            // 
            this.gridChiTiet_ChuThich.Caption = "Chú thích";
            this.gridChiTiet_ChuThich.FieldName = "ChuThich";
            this.gridChiTiet_ChuThich.Name = "gridChiTiet_ChuThich";
            this.gridChiTiet_ChuThich.OptionsColumn.FixedWidth = true;
            this.gridChiTiet_ChuThich.OptionsFilter.AllowFilter = false;
            this.gridChiTiet_ChuThich.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridChiTiet_ChuThich.Visible = true;
            this.gridChiTiet_ChuThich.VisibleIndex = 4;
            this.gridChiTiet_ChuThich.Width = 200;
            // 
            // brgWorker
            // 
            this.brgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.brgWorker_DoWork);
            this.brgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.brgWorker_RunWorkerCompleted);
            // 
            // frmPhieuNhapNb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 668);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.ToolbarGia);
            this.Name = "frmPhieuNhapNb";
            this.Text = "Phiếu nhận hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmPhieuNhapNb_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.MenuMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTietView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn SoPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn TenKhoChuyen;
        private DevExpress.XtraGrid.Columns.GridColumn TenNguoiTao;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTao;
        private INVENTORY.CONTROL.ToolbarGia ToolbarGia;
        private DevExpress.XtraGrid.Columns.GridColumn ChuThich;
        private DevExpress.XtraGrid.Columns.GridColumn TenTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
        private System.Windows.Forms.ContextMenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuThayDoi;
        private DevExpress.XtraEditors.SplitContainerControl splitMain;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.ComponentModel.BackgroundWorker brgWorker;
        private DevExpress.XtraGrid.GridControl gridChiTiet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridChiTietView;
        private DevExpress.XtraGrid.Columns.GridColumn gridChiTiet_TenLoaiVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn gridChiTiet_QuyCach;
        private DevExpress.XtraGrid.Columns.GridColumn gridChiTiet_TenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn gridChiTiet_SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn gridChiTiet_ChuThich;
    }
}
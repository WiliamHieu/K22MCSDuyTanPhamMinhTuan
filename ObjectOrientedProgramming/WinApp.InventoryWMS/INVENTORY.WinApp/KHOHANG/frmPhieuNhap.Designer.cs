namespace INVENTORY.WinApp.KHOHANG
{
    partial class frmPhieuNhap
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
            this.Toolbar01 = new INVENTORY.CONTROL.Toolbar01();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdKhoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNguonNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNguoiTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChuThich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.brgWorker = new System.ComponentModel.BackgroundWorker();
            this.splitMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridChiTiet = new DevExpress.XtraGrid.GridControl();
            this.gridChiTietView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridChiTiet_TenLoaiVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridChiTiet_QuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridChiTiet_TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridChiTiet_SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridChiTiet_ChuThich = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTietView)).BeginInit();
            this.SuspendLayout();
            // 
            // Toolbar01
            // 
            this.Toolbar01.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toolbar01.Location = new System.Drawing.Point(0, 0);
            this.Toolbar01.Name = "Toolbar01";
            this.Toolbar01.SenderName = INVENTORY.CONTROL.Toolbar01.Action.None;
            this.Toolbar01.Size = new System.Drawing.Size(1394, 28);
            this.Toolbar01.TabIndex = 0;
            this.Toolbar01.TuNgay = new System.DateTime(((long)(0)));
            this.Toolbar01.Clicked += new System.EventHandler(this.Toolbar01_Clicked);
            // 
            // gridMain
            // 
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
            // gridMainView
            // 
            this.gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.IdKhoHang,
            this.LoaiNhap,
            this.SoPhieu,
            this.TenLoaiNhap,
            this.TenNguonNhap,
            this.TenNguoiTao,
            this.NgayTao,
            this.ChuThich});
            this.gridMainView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.GroupPanelText = "Kéo cột tương ứng thả vào đây để nhóm dữ liệu";
            this.gridMainView.IndicatorWidth = 37;
            this.gridMainView.Name = "gridMainView";
            this.gridMainView.OptionsBehavior.Editable = false;
            this.gridMainView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridMainView.OptionsView.ShowAutoFilterRow = true;
            this.gridMainView.OptionsView.ShowDetailButtons = false;
            this.gridMainView.OptionsView.ShowFooter = true;
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
            // IdKhoHang
            // 
            this.IdKhoHang.Caption = "IdKhoHang";
            this.IdKhoHang.FieldName = "IdKhoHang";
            this.IdKhoHang.Name = "IdKhoHang";
            this.IdKhoHang.OptionsColumn.FixedWidth = true;
            this.IdKhoHang.OptionsFilter.AllowFilter = false;
            this.IdKhoHang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // LoaiNhap
            // 
            this.LoaiNhap.Caption = "LoaiNhap";
            this.LoaiNhap.FieldName = "LoaiNhap";
            this.LoaiNhap.Name = "LoaiNhap";
            this.LoaiNhap.OptionsFilter.AllowFilter = false;
            this.LoaiNhap.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
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
            // TenLoaiNhap
            // 
            this.TenLoaiNhap.AppearanceHeader.Options.UseTextOptions = true;
            this.TenLoaiNhap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenLoaiNhap.Caption = "Loại nhập";
            this.TenLoaiNhap.FieldName = "TenLoaiNhap";
            this.TenLoaiNhap.Name = "TenLoaiNhap";
            this.TenLoaiNhap.OptionsColumn.FixedWidth = true;
            this.TenLoaiNhap.OptionsFilter.AllowFilter = false;
            this.TenLoaiNhap.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenLoaiNhap.Visible = true;
            this.TenLoaiNhap.VisibleIndex = 1;
            this.TenLoaiNhap.Width = 70;
            // 
            // TenNguonNhap
            // 
            this.TenNguonNhap.Caption = "Nguồn nhập";
            this.TenNguonNhap.FieldName = "TenNguonNhap";
            this.TenNguonNhap.Name = "TenNguonNhap";
            this.TenNguonNhap.OptionsColumn.FixedWidth = true;
            this.TenNguonNhap.OptionsFilter.AllowFilter = false;
            this.TenNguonNhap.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenNguonNhap.Visible = true;
            this.TenNguonNhap.VisibleIndex = 2;
            this.TenNguonNhap.Width = 250;
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
            // ChuThich
            // 
            this.ChuThich.Caption = "Chú thích";
            this.ChuThich.FieldName = "ChuThich";
            this.ChuThich.Name = "ChuThich";
            this.ChuThich.OptionsFilter.AllowFilter = false;
            this.ChuThich.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ChuThich.Visible = true;
            this.ChuThich.VisibleIndex = 5;
            this.ChuThich.Width = 343;
            // 
            // brgWorker
            // 
            this.brgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.brgWorker_DoWork);
            this.brgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.brgWorker_RunWorkerCompleted);
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
            this.gridChiTiet_TenLoaiVatTu.Width = 890;
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
            this.gridChiTiet_QuyCach.Width = 200;
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
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 668);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.Toolbar01);
            this.Name = "frmPhieuNhap";
            this.Text = "Phiếu nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmPhieuNhap_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhieuNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
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

        private INVENTORY.CONTROL.Toolbar01 Toolbar01;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn SoPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn TenNguonNhap;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiNhap;
        private DevExpress.XtraGrid.Columns.GridColumn TenNguoiTao;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn ChuThich;
        private System.ComponentModel.BackgroundWorker brgWorker;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiNhap;
        private DevExpress.XtraEditors.SplitContainerControl splitMain;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridChiTiet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridChiTietView;
        private DevExpress.XtraGrid.Columns.GridColumn gridChiTiet_TenLoaiVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn gridChiTiet_TenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn gridChiTiet_SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn gridChiTiet_ChuThich;
        private DevExpress.XtraGrid.Columns.GridColumn IdKhoHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridChiTiet_QuyCach;
    }
}
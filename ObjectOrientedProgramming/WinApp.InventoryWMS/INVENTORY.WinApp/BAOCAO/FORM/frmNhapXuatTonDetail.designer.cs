namespace INVENTORY.WinApp.BAOCAO.FORM
{
    partial class frmNhapXuatTonDetail
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
            this.brgWorker = new System.ComponentModel.BackgroundWorker();
            this.ToolbarIn = new INVENTORY.CONTROL.ToolbarIn();
            this.PanelSanPham = new DevExpress.XtraEditors.GroupControl();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridMainView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.bandThoiGian = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.NgayTao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandChungTu = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.SoPhieuNhap = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.SoPhieuXuat = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.SoPhieuChuyen = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandDienGiai = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.DienGiai = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandSoLuong = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.Nhap = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Xuat = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Chuyen = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Ton = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.IdPhieu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.LoaiPhieu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtTuNgay = new DevExpress.XtraEditors.TextEdit();
            this.txtDenNgay = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLoaiVatTu = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKhoHang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PanelSanPham)).BeginInit();
            this.PanelSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // brgWorker
            // 
            this.brgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.brgWorker_DoWork);
            this.brgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.brgWorker_RunWorkerCompleted);
            // 
            // ToolbarIn
            // 
            this.ToolbarIn.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarIn.Appearance.Options.UseBackColor = true;
            this.ToolbarIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolbarIn.Location = new System.Drawing.Point(0, 433);
            this.ToolbarIn.Name = "ToolbarIn";
            this.ToolbarIn.SenderName = INVENTORY.CONTROL.ToolbarIn.Action.None;
            this.ToolbarIn.Size = new System.Drawing.Size(884, 28);
            this.ToolbarIn.TabIndex = 2;
            this.ToolbarIn.Clicked += new System.EventHandler(this.ToolbarIn_Clicked);
            // 
            // PanelSanPham
            // 
            this.PanelSanPham.Controls.Add(this.gridMain);
            this.PanelSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSanPham.Location = new System.Drawing.Point(0, 58);
            this.PanelSanPham.Name = "PanelSanPham";
            this.PanelSanPham.Size = new System.Drawing.Size(884, 375);
            this.PanelSanPham.TabIndex = 1;
            this.PanelSanPham.Text = "Thông tin Sản phẩm";
            // 
            // gridMain
            // 
            this.gridMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(2, 21);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(880, 352);
            this.gridMain.TabIndex = 0;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
            this.gridMain.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridMain_ProcessGridKey);
            // 
            // gridMainView
            // 
            this.gridMainView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandThoiGian,
            this.bandChungTu,
            this.bandDienGiai,
            this.bandSoLuong});
            this.gridMainView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.IdPhieu,
            this.LoaiPhieu,
            this.NgayTao,
            this.SoPhieuNhap,
            this.SoPhieuXuat,
            this.SoPhieuChuyen,
            this.DienGiai,
            this.Nhap,
            this.Xuat,
            this.Chuyen,
            this.Ton});
            this.gridMainView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.GroupFormat = "[#image]{1} {2}";
            this.gridMainView.GroupPanelText = "Kéo cột tương ứng thả vào đây để nhóm dữ liệu";
            this.gridMainView.IndicatorWidth = 30;
            this.gridMainView.Name = "gridMainView";
            this.gridMainView.OptionsBehavior.Editable = false;
            this.gridMainView.OptionsNavigation.AutoFocusNewRow = true;
            this.gridMainView.OptionsSelection.MultiSelect = true;
            this.gridMainView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridMainView.OptionsView.ShowAutoFilterRow = true;
            this.gridMainView.OptionsView.ShowFooter = true;
            this.gridMainView.OptionsView.ShowGroupPanel = false;
            this.gridMainView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridMainView_CustomDrawRowIndicator);
            this.gridMainView.DoubleClick += new System.EventHandler(this.gridMainView_DoubleClick);
            // 
            // bandThoiGian
            // 
            this.bandThoiGian.AppearanceHeader.Options.UseTextOptions = true;
            this.bandThoiGian.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandThoiGian.Caption = "Thời gian";
            this.bandThoiGian.Columns.Add(this.NgayTao);
            this.bandThoiGian.Name = "bandThoiGian";
            this.bandThoiGian.OptionsBand.FixedWidth = true;
            this.bandThoiGian.VisibleIndex = 0;
            this.bandThoiGian.Width = 95;
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
            this.NgayTao.Visible = true;
            this.NgayTao.Width = 95;
            // 
            // bandChungTu
            // 
            this.bandChungTu.AppearanceHeader.Options.UseTextOptions = true;
            this.bandChungTu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandChungTu.Caption = "Chứng từ";
            this.bandChungTu.Columns.Add(this.SoPhieuNhap);
            this.bandChungTu.Columns.Add(this.SoPhieuXuat);
            this.bandChungTu.Columns.Add(this.SoPhieuChuyen);
            this.bandChungTu.Name = "bandChungTu";
            this.bandChungTu.OptionsBand.FixedWidth = true;
            this.bandChungTu.VisibleIndex = 1;
            this.bandChungTu.Width = 240;
            // 
            // SoPhieuNhap
            // 
            this.SoPhieuNhap.AppearanceHeader.Options.UseTextOptions = true;
            this.SoPhieuNhap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoPhieuNhap.Caption = "Nhập";
            this.SoPhieuNhap.FieldName = "SoPhieuNhap";
            this.SoPhieuNhap.Name = "SoPhieuNhap";
            this.SoPhieuNhap.OptionsColumn.FixedWidth = true;
            this.SoPhieuNhap.OptionsFilter.AllowFilter = false;
            this.SoPhieuNhap.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.SoPhieuNhap.Visible = true;
            this.SoPhieuNhap.Width = 80;
            // 
            // SoPhieuXuat
            // 
            this.SoPhieuXuat.AppearanceHeader.Options.UseTextOptions = true;
            this.SoPhieuXuat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoPhieuXuat.Caption = "Xuất";
            this.SoPhieuXuat.FieldName = "SoPhieuXuat";
            this.SoPhieuXuat.Name = "SoPhieuXuat";
            this.SoPhieuXuat.OptionsColumn.FixedWidth = true;
            this.SoPhieuXuat.OptionsFilter.AllowFilter = false;
            this.SoPhieuXuat.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.SoPhieuXuat.Visible = true;
            this.SoPhieuXuat.Width = 80;
            // 
            // SoPhieuChuyen
            // 
            this.SoPhieuChuyen.AppearanceHeader.Options.UseTextOptions = true;
            this.SoPhieuChuyen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoPhieuChuyen.Caption = "Chuyển";
            this.SoPhieuChuyen.FieldName = "SoPhieuChuyen";
            this.SoPhieuChuyen.Name = "SoPhieuChuyen";
            this.SoPhieuChuyen.OptionsColumn.FixedWidth = true;
            this.SoPhieuChuyen.OptionsFilter.AllowFilter = false;
            this.SoPhieuChuyen.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.SoPhieuChuyen.Visible = true;
            this.SoPhieuChuyen.Width = 80;
            // 
            // bandDienGiai
            // 
            this.bandDienGiai.AppearanceHeader.Options.UseTextOptions = true;
            this.bandDienGiai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandDienGiai.Caption = "Diễn giải";
            this.bandDienGiai.Columns.Add(this.DienGiai);
            this.bandDienGiai.Name = "bandDienGiai";
            this.bandDienGiai.VisibleIndex = 2;
            this.bandDienGiai.Width = 245;
            // 
            // DienGiai
            // 
            this.DienGiai.AppearanceHeader.Options.UseTextOptions = true;
            this.DienGiai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DienGiai.Caption = "Nội dung";
            this.DienGiai.FieldName = "DienGiai";
            this.DienGiai.Name = "DienGiai";
            this.DienGiai.OptionsFilter.AllowFilter = false;
            this.DienGiai.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.DienGiai.Visible = true;
            this.DienGiai.Width = 245;
            // 
            // bandSoLuong
            // 
            this.bandSoLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.bandSoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandSoLuong.Caption = "Số lượng";
            this.bandSoLuong.Columns.Add(this.Nhap);
            this.bandSoLuong.Columns.Add(this.Xuat);
            this.bandSoLuong.Columns.Add(this.Chuyen);
            this.bandSoLuong.Columns.Add(this.Ton);
            this.bandSoLuong.Name = "bandSoLuong";
            this.bandSoLuong.OptionsBand.FixedWidth = true;
            this.bandSoLuong.VisibleIndex = 3;
            this.bandSoLuong.Width = 200;
            // 
            // Nhap
            // 
            this.Nhap.AppearanceCell.Options.UseTextOptions = true;
            this.Nhap.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Nhap.AppearanceHeader.Options.UseTextOptions = true;
            this.Nhap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Nhap.Caption = "Nhập";
            this.Nhap.DisplayFormat.FormatString = "N0";
            this.Nhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Nhap.FieldName = "Nhap";
            this.Nhap.Name = "Nhap";
            this.Nhap.OptionsColumn.FixedWidth = true;
            this.Nhap.OptionsFilter.AllowFilter = false;
            this.Nhap.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Nhap.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nhap", "{0:N0}")});
            this.Nhap.Visible = true;
            this.Nhap.Width = 50;
            // 
            // Xuat
            // 
            this.Xuat.AppearanceCell.Options.UseTextOptions = true;
            this.Xuat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Xuat.AppearanceHeader.Options.UseTextOptions = true;
            this.Xuat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Xuat.Caption = "Xuất";
            this.Xuat.DisplayFormat.FormatString = "N0";
            this.Xuat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Xuat.FieldName = "Xuat";
            this.Xuat.Name = "Xuat";
            this.Xuat.OptionsColumn.FixedWidth = true;
            this.Xuat.OptionsFilter.AllowFilter = false;
            this.Xuat.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Xuat.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Xuat", "{0:N0}")});
            this.Xuat.Visible = true;
            this.Xuat.Width = 50;
            // 
            // Chuyen
            // 
            this.Chuyen.AppearanceCell.Options.UseTextOptions = true;
            this.Chuyen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Chuyen.AppearanceHeader.Options.UseTextOptions = true;
            this.Chuyen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Chuyen.Caption = "Chuyển";
            this.Chuyen.DisplayFormat.FormatString = "N0";
            this.Chuyen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Chuyen.FieldName = "Chuyen";
            this.Chuyen.Name = "Chuyen";
            this.Chuyen.OptionsColumn.FixedWidth = true;
            this.Chuyen.OptionsFilter.AllowFilter = false;
            this.Chuyen.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Chuyen.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Chuyen", "{0:N0}")});
            this.Chuyen.Visible = true;
            this.Chuyen.Width = 50;
            // 
            // Ton
            // 
            this.Ton.AppearanceCell.Options.UseTextOptions = true;
            this.Ton.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Ton.AppearanceHeader.Options.UseTextOptions = true;
            this.Ton.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ton.Caption = "Tồn";
            this.Ton.DisplayFormat.FormatString = "N0";
            this.Ton.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Ton.FieldName = "Ton";
            this.Ton.Name = "Ton";
            this.Ton.OptionsColumn.FixedWidth = true;
            this.Ton.OptionsFilter.AllowFilter = false;
            this.Ton.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Ton.Visible = true;
            this.Ton.Width = 50;
            // 
            // IdPhieu
            // 
            this.IdPhieu.Caption = "IdPhieu";
            this.IdPhieu.FieldName = "IdPhieu";
            this.IdPhieu.Name = "IdPhieu";
            this.IdPhieu.OptionsFilter.AllowFilter = false;
            this.IdPhieu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // LoaiPhieu
            // 
            this.LoaiPhieu.Caption = "LoaiPhieu";
            this.LoaiPhieu.FieldName = "LoaiPhieu";
            this.LoaiPhieu.Name = "LoaiPhieu";
            this.LoaiPhieu.OptionsFilter.AllowFilter = false;
            this.LoaiPhieu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtTuNgay);
            this.groupControl3.Controls.Add(this.txtDenNgay);
            this.groupControl3.Controls.Add(this.txtTenLoaiVatTu);
            this.groupControl3.Controls.Add(this.txtTenKhoHang);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(884, 58);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Thông tin Chung";
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.EnterMoveNextControl = true;
            this.txtTuNgay.Location = new System.Drawing.Point(612, 28);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Properties.MaxLength = 300;
            this.txtTuNgay.Properties.ReadOnly = true;
            this.txtTuNgay.Size = new System.Drawing.Size(90, 20);
            this.txtTuNgay.TabIndex = 2;
            this.txtTuNgay.TabStop = false;
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.EnterMoveNextControl = true;
            this.txtDenNgay.Location = new System.Drawing.Point(771, 28);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.Properties.MaxLength = 300;
            this.txtDenNgay.Properties.ReadOnly = true;
            this.txtDenNgay.Size = new System.Drawing.Size(90, 20);
            this.txtDenNgay.TabIndex = 3;
            this.txtDenNgay.TabStop = false;
            // 
            // txtTenLoaiVatTu
            // 
            this.txtTenLoaiVatTu.EnterMoveNextControl = true;
            this.txtTenLoaiVatTu.Location = new System.Drawing.Point(329, 28);
            this.txtTenLoaiVatTu.Name = "txtTenLoaiVatTu";
            this.txtTenLoaiVatTu.Properties.MaxLength = 300;
            this.txtTenLoaiVatTu.Properties.ReadOnly = true;
            this.txtTenLoaiVatTu.Size = new System.Drawing.Size(220, 20);
            this.txtTenLoaiVatTu.TabIndex = 1;
            this.txtTenLoaiVatTu.TabStop = false;
            // 
            // txtTenKhoHang
            // 
            this.txtTenKhoHang.EnterMoveNextControl = true;
            this.txtTenKhoHang.Location = new System.Drawing.Point(73, 28);
            this.txtTenKhoHang.Name = "txtTenKhoHang";
            this.txtTenKhoHang.Properties.MaxLength = 300;
            this.txtTenKhoHang.Properties.ReadOnly = true;
            this.txtTenKhoHang.Size = new System.Drawing.Size(180, 20);
            this.txtTenKhoHang.TabIndex = 0;
            this.txtTenKhoHang.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(718, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Đến ngày";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(271, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Loại vật tư";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(566, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Từ ngày";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(22, 31);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Kho hàng";
            // 
            // frmNhapXuatTonDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.PanelSanPham);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.ToolbarIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhapXuatTonDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết Nhập xuất tồn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhapXuatTonDetail_FormClosing);
            this.Load += new System.EventHandler(this.frmNhapXuatTonDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelSanPham)).EndInit();
            this.PanelSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoHang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker brgWorker;
        private INVENTORY.CONTROL.ToolbarIn ToolbarIn;
        private DevExpress.XtraEditors.GroupControl PanelSanPham;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gridMainView;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn SoPhieuNhap;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn SoPhieuXuat;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn DienGiai;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Nhap;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Xuat;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Chuyen;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn NgayTao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn SoPhieuChuyen;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Ton;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txtTuNgay;
        private DevExpress.XtraEditors.TextEdit txtDenNgay;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiVatTu;
        private DevExpress.XtraEditors.TextEdit txtTenKhoHang;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn IdPhieu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn LoaiPhieu;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandThoiGian;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandChungTu;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandDienGiai;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandSoLuong;
    }
}
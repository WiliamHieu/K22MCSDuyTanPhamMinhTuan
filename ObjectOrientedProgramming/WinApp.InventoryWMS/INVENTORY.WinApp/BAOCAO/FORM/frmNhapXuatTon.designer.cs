namespace INVENTORY.WinApp.BAOCAO.FORM
{
    partial class frmNhapXuatTon
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
            this.ToolbarBc = new INVENTORY.CONTROL.ToolbarBc();
            this.brgWorker = new System.ComponentModel.BackgroundWorker();
            this.splitMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ucNhomVatTu = new INVENTORY.WinApp.CONTROL.ucNhomVatTu();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ucThoiGian = new INVENTORY.WinApp.CONTROL.ucThoiGian();
            this.cboKhoHang = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdLoaiVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhomVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TonDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Xuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Chuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TonCuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolbarBc
            // 
            this.ToolbarBc.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolbarBc.Location = new System.Drawing.Point(0, 0);
            this.ToolbarBc.Name = "ToolbarBc";
            this.ToolbarBc.SenderName = INVENTORY.CONTROL.ToolbarBc.Action.None;
            this.ToolbarBc.Size = new System.Drawing.Size(1301, 28);
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
            this.splitMain.Size = new System.Drawing.Size(1301, 600);
            this.splitMain.SplitterPosition = 200;
            this.splitMain.TabIndex = 1;
            this.splitMain.Text = "splitMain";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ucNhomVatTu);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 86);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(200, 514);
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
            this.ucNhomVatTu.Size = new System.Drawing.Size(196, 491);
            this.ucNhomVatTu.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ucThoiGian);
            this.groupControl1.Controls.Add(this.cboKhoHang);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 86);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // ucThoiGian
            // 
            this.ucThoiGian.DenNgay = new System.DateTime(((long)(0)));
            this.ucThoiGian.Location = new System.Drawing.Point(12, 56);
            this.ucThoiGian.Name = "ucThoiGian";
            this.ucThoiGian.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ucThoiGian.Size = new System.Drawing.Size(178, 20);
            this.ucThoiGian.TabIndex = 1;
            this.ucThoiGian.TuNgay = new System.DateTime(((long)(0)));
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
            this.groupControl3.Size = new System.Drawing.Size(1095, 600);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Thông tin Nhập xuất tồn";
            // 
            // gridMain
            // 
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(2, 21);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(1091, 577);
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
            this.IdLoaiVatTu,
            this.TenNhomVatTu,
            this.TenLoaiVatTu,
            this.QuyCach,
            this.TenDonViTinh,
            this.TonDau,
            this.Nhap,
            this.Xuat,
            this.Chuyen,
            this.TonCuoi});
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.GroupCount = 1;
            this.gridMainView.GroupFormat = "{1} {2}";
            this.gridMainView.GroupPanelText = "Kéo cột tương ứng thả vào đây để nhóm dữ liệu";
            this.gridMainView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TonDau", null, "{0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nhap", null, "{0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Xuat", null, "{0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Chuyen", null, "{0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TonCuoi", null, "{0:N0}")});
            this.gridMainView.IndicatorWidth = 37;
            this.gridMainView.LevelIndent = 0;
            this.gridMainView.Name = "gridMainView";
            this.gridMainView.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridMainView.OptionsBehavior.Editable = false;
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
            // IdLoaiVatTu
            // 
            this.IdLoaiVatTu.Caption = "IdLoaiVatTu";
            this.IdLoaiVatTu.FieldName = "IdLoaiVatTu";
            this.IdLoaiVatTu.Name = "IdLoaiVatTu";
            this.IdLoaiVatTu.OptionsFilter.AllowFilter = false;
            this.IdLoaiVatTu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // TenNhomVatTu
            // 
            this.TenNhomVatTu.Caption = "Nhóm vật tư";
            this.TenNhomVatTu.FieldName = "TenNhomVatTu";
            this.TenNhomVatTu.Name = "TenNhomVatTu";
            this.TenNhomVatTu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // TenLoaiVatTu
            // 
            this.TenLoaiVatTu.Caption = "Loại vật tư";
            this.TenLoaiVatTu.FieldName = "TenLoaiVatTu";
            this.TenLoaiVatTu.Name = "TenLoaiVatTu";
            this.TenLoaiVatTu.OptionsFilter.AllowFilter = false;
            this.TenLoaiVatTu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenLoaiVatTu.Visible = true;
            this.TenLoaiVatTu.VisibleIndex = 0;
            this.TenLoaiVatTu.Width = 494;
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
            this.QuyCach.VisibleIndex = 1;
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
            this.TenDonViTinh.VisibleIndex = 2;
            this.TenDonViTinh.Width = 60;
            // 
            // TonDau
            // 
            this.TonDau.AppearanceCell.Options.UseTextOptions = true;
            this.TonDau.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TonDau.AppearanceHeader.Options.UseTextOptions = true;
            this.TonDau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TonDau.Caption = "Tồn đầu";
            this.TonDau.DisplayFormat.FormatString = "N0";
            this.TonDau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TonDau.FieldName = "TonDau";
            this.TonDau.Name = "TonDau";
            this.TonDau.OptionsColumn.FixedWidth = true;
            this.TonDau.OptionsFilter.AllowFilter = false;
            this.TonDau.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TonDau.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TonDau", "{0:N0}")});
            this.TonDau.Visible = true;
            this.TonDau.VisibleIndex = 3;
            this.TonDau.Width = 60;
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
            this.Nhap.VisibleIndex = 4;
            this.Nhap.Width = 60;
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
            this.Xuat.VisibleIndex = 5;
            this.Xuat.Width = 60;
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
            this.Chuyen.VisibleIndex = 6;
            this.Chuyen.Width = 60;
            // 
            // TonCuoi
            // 
            this.TonCuoi.AppearanceCell.Options.UseTextOptions = true;
            this.TonCuoi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TonCuoi.AppearanceHeader.Options.UseTextOptions = true;
            this.TonCuoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TonCuoi.Caption = "Tồn cuối";
            this.TonCuoi.DisplayFormat.FormatString = "N0";
            this.TonCuoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TonCuoi.FieldName = "TonCuoi";
            this.TonCuoi.Name = "TonCuoi";
            this.TonCuoi.OptionsColumn.FixedWidth = true;
            this.TonCuoi.OptionsFilter.AllowFilter = false;
            this.TonCuoi.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TonCuoi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TonCuoi", "{0:N0}")});
            this.TonCuoi.Visible = true;
            this.TonCuoi.VisibleIndex = 7;
            this.TonCuoi.Width = 60;
            // 
            // frmNhapXuatTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 628);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.ToolbarBc);
            this.Name = "frmNhapXuatTon";
            this.Text = "Nhập xuất tồn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhapXuatTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private INVENTORY.CONTROL.ToolbarBc ToolbarBc;
        private System.ComponentModel.BackgroundWorker brgWorker;
        private DevExpress.XtraEditors.SplitContainerControl splitMain;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cboKhoHang;
        private CONTROL.ucNhomVatTu ucNhomVatTu;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhomVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn TenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn TonDau;
        private DevExpress.XtraGrid.Columns.GridColumn Nhap;
        private DevExpress.XtraGrid.Columns.GridColumn Xuat;
        private DevExpress.XtraGrid.Columns.GridColumn Chuyen;
        private DevExpress.XtraGrid.Columns.GridColumn TonCuoi;
        private CONTROL.ucThoiGian ucThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn QuyCach;
        private DevExpress.XtraGrid.Columns.GridColumn IdLoaiVatTu;
    }
}
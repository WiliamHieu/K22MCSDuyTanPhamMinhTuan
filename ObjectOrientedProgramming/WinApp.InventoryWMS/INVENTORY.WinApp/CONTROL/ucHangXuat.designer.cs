namespace INVENTORY.WinApp.CONTROL
{
    partial class ucHangXuat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pceMain = new DevExpress.XtraEditors.PopupContainerEdit();
            this.pccMain = new DevExpress.XtraEditors.PopupContainerControl();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMain_IdLoaiVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_TenLoaiVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_MaHienThi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cboDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.cboTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.spSoLuong = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pceMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pccMain)).BeginInit();
            this.pccMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoLuong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pceMain
            // 
            this.pceMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceMain.Location = new System.Drawing.Point(0, 0);
            this.pceMain.Name = "pceMain";
            this.pceMain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.pceMain.Properties.MaxLength = 100;
            this.pceMain.Properties.PopupControl = this.pccMain;
            this.pceMain.Properties.PopupFormMinSize = new System.Drawing.Size(796, 0);
            this.pceMain.Properties.PopupFormSize = new System.Drawing.Size(796, 0);
            this.pceMain.Properties.PopupSizeable = false;
            this.pceMain.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.pceMain.Properties.ShowPopupCloseButton = false;
            this.pceMain.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.pceMain.Size = new System.Drawing.Size(600, 20);
            this.pceMain.TabIndex = 0;
            this.pceMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pceMain_KeyDown);
            // 
            // pccMain
            // 
            this.pccMain.Controls.Add(this.gridMain);
            this.pccMain.Controls.Add(this.panelControl1);
            this.pccMain.Location = new System.Drawing.Point(0, 19);
            this.pccMain.Name = "pccMain";
            this.pccMain.Size = new System.Drawing.Size(640, 300);
            this.pccMain.TabIndex = 1;
            // 
            // gridMain
            // 
            this.gridMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(0, 28);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(640, 272);
            this.gridMain.TabIndex = 25;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
            this.gridMain.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridMain_ProcessGridKey);
            // 
            // gridMainView
            // 
            this.gridMainView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridMain_IdLoaiVatTu,
            this.gridMain_MaHienThi,
            this.gridMain_TenLoaiVatTu,
            this.gridMain_TenDonViTinh,
            this.gridMain_SoLuong,
            this.gridMain_DonGia,
            this.gridMain_ThanhTien});
            this.gridMainView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.GroupFormat = "[#image]{1} {2}";
            this.gridMainView.GroupPanelText = "Kéo cột tương ứng thả vào đây để nhóm dữ liệu";
            this.gridMainView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienConNo", this.gridMain_DonGia, "{0:N0}")});
            this.gridMainView.IndicatorWidth = 30;
            this.gridMainView.Name = "gridMainView";
            this.gridMainView.OptionsBehavior.Editable = false;
            this.gridMainView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridMainView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridMainView.OptionsView.ShowDetailButtons = false;
            this.gridMainView.OptionsView.ShowGroupPanel = false;
            this.gridMainView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridMainView_CustomDrawRowIndicator);
            this.gridMainView.DoubleClick += new System.EventHandler(this.gridMainView_DoubleClick);
            // 
            // gridMain_IdLoaiVatTu
            // 
            this.gridMain_IdLoaiVatTu.Caption = "IdLoaiVatTu";
            this.gridMain_IdLoaiVatTu.FieldName = "IdLoaiVatTu";
            this.gridMain_IdLoaiVatTu.Name = "gridMain_IdLoaiVatTu";
            // 
            // gridMain_TenLoaiVatTu
            // 
            this.gridMain_TenLoaiVatTu.Caption = "Loại vật tư";
            this.gridMain_TenLoaiVatTu.FieldName = "TenLoaiVatTu";
            this.gridMain_TenLoaiVatTu.Name = "gridMain_TenLoaiVatTu";
            this.gridMain_TenLoaiVatTu.OptionsColumn.AllowEdit = false;
            this.gridMain_TenLoaiVatTu.OptionsFilter.AllowFilter = false;
            this.gridMain_TenLoaiVatTu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridMain_TenLoaiVatTu.Visible = true;
            this.gridMain_TenLoaiVatTu.VisibleIndex = 1;
            this.gridMain_TenLoaiVatTu.Width = 250;
            // 
            // gridMain_TenDonViTinh
            // 
            this.gridMain_TenDonViTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.gridMain_TenDonViTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridMain_TenDonViTinh.Caption = "ĐVT";
            this.gridMain_TenDonViTinh.FieldName = "TenDonViTinh";
            this.gridMain_TenDonViTinh.Name = "gridMain_TenDonViTinh";
            this.gridMain_TenDonViTinh.OptionsColumn.FixedWidth = true;
            this.gridMain_TenDonViTinh.OptionsFilter.AllowFilter = false;
            this.gridMain_TenDonViTinh.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridMain_TenDonViTinh.Visible = true;
            this.gridMain_TenDonViTinh.VisibleIndex = 2;
            this.gridMain_TenDonViTinh.Width = 40;
            // 
            // gridMain_MaHienThi
            // 
            this.gridMain_MaHienThi.Caption = "Mã vạch";
            this.gridMain_MaHienThi.FieldName = "MaHienThi";
            this.gridMain_MaHienThi.Name = "gridMain_MaHienThi";
            this.gridMain_MaHienThi.OptionsColumn.FixedWidth = true;
            this.gridMain_MaHienThi.OptionsFilter.AllowFilter = false;
            this.gridMain_MaHienThi.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridMain_MaHienThi.Visible = true;
            this.gridMain_MaHienThi.VisibleIndex = 0;
            this.gridMain_MaHienThi.Width = 80;
            // 
            // gridMain_SoLuong
            // 
            this.gridMain_SoLuong.AppearanceCell.Options.UseTextOptions = true;
            this.gridMain_SoLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridMain_SoLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.gridMain_SoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridMain_SoLuong.Caption = "Số lượng";
            this.gridMain_SoLuong.DisplayFormat.FormatString = "N0";
            this.gridMain_SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridMain_SoLuong.FieldName = "SoLuong";
            this.gridMain_SoLuong.Name = "gridMain_SoLuong";
            this.gridMain_SoLuong.OptionsColumn.AllowEdit = false;
            this.gridMain_SoLuong.OptionsColumn.FixedWidth = true;
            this.gridMain_SoLuong.OptionsFilter.AllowFilter = false;
            this.gridMain_SoLuong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridMain_SoLuong.Visible = true;
            this.gridMain_SoLuong.VisibleIndex = 3;
            this.gridMain_SoLuong.Width = 55;
            // 
            // gridMain_DonGia
            // 
            this.gridMain_DonGia.AppearanceCell.Options.UseTextOptions = true;
            this.gridMain_DonGia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridMain_DonGia.AppearanceHeader.Options.UseTextOptions = true;
            this.gridMain_DonGia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridMain_DonGia.Caption = "Đơn giá";
            this.gridMain_DonGia.DisplayFormat.FormatString = "N0";
            this.gridMain_DonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridMain_DonGia.FieldName = "DonGia";
            this.gridMain_DonGia.Name = "gridMain_DonGia";
            this.gridMain_DonGia.OptionsColumn.AllowEdit = false;
            this.gridMain_DonGia.OptionsColumn.FixedWidth = true;
            this.gridMain_DonGia.OptionsFilter.AllowFilter = false;
            this.gridMain_DonGia.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridMain_DonGia.Visible = true;
            this.gridMain_DonGia.VisibleIndex = 4;
            this.gridMain_DonGia.Width = 70;
            // 
            // gridMain_ThanhTien
            // 
            this.gridMain_ThanhTien.AppearanceCell.Options.UseTextOptions = true;
            this.gridMain_ThanhTien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridMain_ThanhTien.AppearanceHeader.Options.UseTextOptions = true;
            this.gridMain_ThanhTien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridMain_ThanhTien.Caption = "Thành tiền";
            this.gridMain_ThanhTien.DisplayFormat.FormatString = "N0";
            this.gridMain_ThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridMain_ThanhTien.FieldName = "ThanhTien";
            this.gridMain_ThanhTien.Name = "gridMain_ThanhTien";
            this.gridMain_ThanhTien.OptionsColumn.AllowEdit = false;
            this.gridMain_ThanhTien.OptionsColumn.FixedWidth = true;
            this.gridMain_ThanhTien.OptionsFilter.AllowFilter = false;
            this.gridMain_ThanhTien.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridMain_ThanhTien.Visible = true;
            this.gridMain_ThanhTien.VisibleIndex = 5;
            this.gridMain_ThanhTien.Width = 70;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.cboDenNgay);
            this.panelControl1.Controls.Add(this.cboTuNgay);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cmdTimKiem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(640, 28);
            this.panelControl1.TabIndex = 24;
            // 
            // cboDenNgay
            // 
            this.cboDenNgay.EditValue = null;
            this.cboDenNgay.EnterMoveNextControl = true;
            this.cboDenNgay.Location = new System.Drawing.Point(147, 4);
            this.cboDenNgay.Name = "cboDenNgay";
            this.cboDenNgay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cboDenNgay.Properties.NullText = " -- Ngày xem --";
            this.cboDenNgay.Properties.ShowToday = false;
            this.cboDenNgay.Size = new System.Drawing.Size(86, 20);
            this.cboDenNgay.TabIndex = 22;
            // 
            // cboTuNgay
            // 
            this.cboTuNgay.EditValue = null;
            this.cboTuNgay.EnterMoveNextControl = true;
            this.cboTuNgay.Location = new System.Drawing.Point(55, 4);
            this.cboTuNgay.Name = "cboTuNgay";
            this.cboTuNgay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cboTuNgay.Properties.NullText = " -- Ngày xem --";
            this.cboTuNgay.Properties.ShowToday = false;
            this.cboTuNgay.Size = new System.Drawing.Size(86, 20);
            this.cboTuNgay.TabIndex = 21;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Thời gian";
            // 
            // cmdTimKiem
            // 
            this.cmdTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdTimKiem.Image = global::INVENTORY.WinApp.Properties.Resources.view;
            this.cmdTimKiem.Location = new System.Drawing.Point(239, 4);
            this.cmdTimKiem.Name = "cmdTimKiem";
            this.cmdTimKiem.Size = new System.Drawing.Size(100, 20);
            this.cmdTimKiem.TabIndex = 2;
            this.cmdTimKiem.Text = "Tìm kiếm (F3)";
            // 
            // spSoLuong
            // 
            this.spSoLuong.Dock = System.Windows.Forms.DockStyle.Right;
            this.spSoLuong.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spSoLuong.Location = new System.Drawing.Point(600, 0);
            this.spSoLuong.Name = "spSoLuong";
            this.spSoLuong.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.spSoLuong.Properties.DisplayFormat.FormatString = "N0";
            this.spSoLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spSoLuong.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.spSoLuong.Properties.ReadOnly = true;
            this.spSoLuong.Size = new System.Drawing.Size(40, 20);
            this.spSoLuong.TabIndex = 1;
            // 
            // ucHangXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pceMain);
            this.Controls.Add(this.spSoLuong);
            this.Controls.Add(this.pccMain);
            this.Name = "ucHangXuat";
            this.Size = new System.Drawing.Size(640, 20);
            ((System.ComponentModel.ISupportInitialize)(this.pceMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pccMain)).EndInit();
            this.pccMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoLuong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PopupContainerEdit pceMain;
        private DevExpress.XtraEditors.PopupContainerControl pccMain;
        private DevExpress.XtraEditors.DateEdit cboDenNgay;
        private DevExpress.XtraEditors.DateEdit cboTuNgay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdTimKiem;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn gridMain_TenLoaiVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn gridMain_SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn gridMain_DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn gridMain_ThanhTien;
        private DevExpress.XtraEditors.SpinEdit spSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn gridMain_IdLoaiVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn gridMain_TenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn gridMain_MaHienThi;
    }
}

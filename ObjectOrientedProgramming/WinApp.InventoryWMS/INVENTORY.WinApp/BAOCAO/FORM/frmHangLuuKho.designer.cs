namespace INVENTORY.WinApp.BAOCAO.FORM
{
    partial class frmHangLuuKho
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.ucNhomVatTu = new INVENTORY.WinApp.CONTROL.ucNhomVatTu();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblNgayDuLieu = new DevExpress.XtraEditors.TextEdit();
            this.txtNgayTonKho = new DevExpress.XtraEditors.SpinEdit();
            this.cboKhoHang = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenNhomVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblNgayDuLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTonKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
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
            this.ToolbarBc.Size = new System.Drawing.Size(1305, 28);
            this.ToolbarBc.TabIndex = 0;
            this.ToolbarBc.Clicked += new System.EventHandler(this.ToolbarBc_Clicked);
            // 
            // brgWorker
            // 
            this.brgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.brgWorker_DoWork);
            this.brgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.brgWorker_RunWorkerCompleted);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 28);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1305, 628);
            this.splitContainerControl1.SplitterPosition = 200;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.ucNhomVatTu);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 86);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(200, 542);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Ngành hàng";
            // 
            // ucNhomVatTu
            // 
            this.ucNhomVatTu.Appearance.BackColor = System.Drawing.Color.White;
            this.ucNhomVatTu.Appearance.Options.UseBackColor = true;
            this.ucNhomVatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNhomVatTu.Location = new System.Drawing.Point(2, 21);
            this.ucNhomVatTu.Name = "ucNhomVatTu";
            this.ucNhomVatTu.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ucNhomVatTu.Size = new System.Drawing.Size(196, 519);
            this.ucNhomVatTu.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblNgayDuLieu);
            this.groupControl1.Controls.Add(this.txtNgayTonKho);
            this.groupControl1.Controls.Add(this.cboKhoHang);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 86);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // lblNgayDuLieu
            // 
            this.lblNgayDuLieu.EditValue = " Số ngày tồn trong kho";
            this.lblNgayDuLieu.EnterMoveNextControl = true;
            this.lblNgayDuLieu.Location = new System.Drawing.Point(12, 56);
            this.lblNgayDuLieu.Name = "lblNgayDuLieu";
            this.lblNgayDuLieu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.lblNgayDuLieu.Properties.Appearance.Options.UseBackColor = true;
            this.lblNgayDuLieu.Properties.ReadOnly = true;
            this.lblNgayDuLieu.Size = new System.Drawing.Size(120, 20);
            this.lblNgayDuLieu.TabIndex = 1;
            this.lblNgayDuLieu.TabStop = false;
            // 
            // txtNgayTonKho
            // 
            this.txtNgayTonKho.EditValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.txtNgayTonKho.EnterMoveNextControl = true;
            this.txtNgayTonKho.Location = new System.Drawing.Point(138, 56);
            this.txtNgayTonKho.Name = "txtNgayTonKho";
            this.txtNgayTonKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtNgayTonKho.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtNgayTonKho.Properties.IsFloatValue = false;
            this.txtNgayTonKho.Properties.Mask.EditMask = "N00";
            this.txtNgayTonKho.Properties.MaxValue = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.txtNgayTonKho.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNgayTonKho.Size = new System.Drawing.Size(51, 20);
            this.txtNgayTonKho.TabIndex = 2;
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
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridMain);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1099, 628);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thông tin Hàng tồn";
            // 
            // gridMain
            // 
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(2, 21);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(1095, 605);
            this.gridMain.TabIndex = 0;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
            // 
            // gridMainView
            // 
            this.gridMainView.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridMainView.Appearance.GroupRow.Options.UseFont = true;
            this.gridMainView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenNhomVatTu,
            this.TenLoaiVatTu,
            this.QuyCach,
            this.TenDonViTinh,
            this.SoLuong,
            this.NgayTao,
            this.NgayTon});
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
            this.gridMainView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridMainView.OptionsView.ShowAutoFilterRow = true;
            this.gridMainView.OptionsView.ShowFooter = true;
            this.gridMainView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TenNhomVatTu, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridMainView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridMainView_CustomDrawRowIndicator);
            this.gridMainView.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridMainView_CustomDrawGroupRow);
            // 
            // TenNhomVatTu
            // 
            this.TenNhomVatTu.Caption = "Nhóm vật tư";
            this.TenNhomVatTu.FieldName = "TenNhomVatTu";
            this.TenNhomVatTu.Name = "TenNhomVatTu";
            this.TenNhomVatTu.OptionsFilter.AllowFilter = false;
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
            this.TenLoaiVatTu.Width = 743;
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
            this.SoLuong.VisibleIndex = 3;
            this.SoLuong.Width = 60;
            // 
            // NgayTao
            // 
            this.NgayTao.AppearanceCell.Options.UseTextOptions = true;
            this.NgayTao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NgayTao.AppearanceHeader.Options.UseTextOptions = true;
            this.NgayTao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayTao.Caption = "Ngày nhập";
            this.NgayTao.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgayTao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayTao.FieldName = "NgayTao";
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.OptionsColumn.FixedWidth = true;
            this.NgayTao.OptionsFilter.AllowFilter = false;
            this.NgayTao.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NgayTao.Visible = true;
            this.NgayTao.VisibleIndex = 4;
            this.NgayTao.Width = 70;
            // 
            // NgayTon
            // 
            this.NgayTon.AppearanceCell.Options.UseTextOptions = true;
            this.NgayTon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NgayTon.AppearanceHeader.Options.UseTextOptions = true;
            this.NgayTon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayTon.Caption = "Ngày tồn";
            this.NgayTon.DisplayFormat.FormatString = "N0";
            this.NgayTon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NgayTon.FieldName = "NgayTon";
            this.NgayTon.Name = "NgayTon";
            this.NgayTon.OptionsColumn.FixedWidth = true;
            this.NgayTon.OptionsFilter.AllowFilter = false;
            this.NgayTon.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NgayTon.Visible = true;
            this.NgayTon.VisibleIndex = 5;
            this.NgayTon.Width = 60;
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
            // frmHangLuuKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 656);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ToolbarBc);
            this.Name = "frmHangLuuKho";
            this.Text = "Hàng lưu kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHangLuuKho_FormClosing);
            this.Load += new System.EventHandler(this.frmHangLuuKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblNgayDuLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTonKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private INVENTORY.CONTROL.ToolbarBc ToolbarBc;
        private System.ComponentModel.BackgroundWorker brgWorker;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cboKhoHang;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private CONTROL.ucNhomVatTu ucNhomVatTu;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhomVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTon;
        private DevExpress.XtraEditors.TextEdit lblNgayDuLieu;
        private DevExpress.XtraEditors.SpinEdit txtNgayTonKho;
        private DevExpress.XtraGrid.Columns.GridColumn TenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn QuyCach;
    }
}
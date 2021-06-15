namespace INVENTORY.WinApp.KHOHANG
{
    partial class frmPhieuNhapNbAdd
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
            this.brgWorker = new System.ComponentModel.BackgroundWorker();
            this.PanelThongTin = new DevExpress.XtraEditors.PanelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtKhoChuyen = new DevExpress.XtraEditors.TextEdit();
            this.txtNguoiGiao = new DevExpress.XtraEditors.TextEdit();
            this.txtChuThich = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtNgayTao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoPhieu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ToolbarLd = new INVENTORY.CONTROL.ToolbarLd();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_txtChuThich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelThongTin)).BeginInit();
            this.PanelThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoChuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiGiao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridMain);
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
            this.gridMain.Location = new System.Drawing.Point(2, 21);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gridMain_txtChuThich});
            this.gridMain.Size = new System.Drawing.Size(880, 467);
            this.gridMain.TabIndex = 2;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
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
            this.gridMainView.OptionsBehavior.Editable = false;
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
            this.Id.OptionsColumn.FixedWidth = true;
            // 
            // Status
            // 
            this.Status.Caption = "Status";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.OptionsColumn.FixedWidth = true;
            this.Status.OptionsFilter.AllowFilter = false;
            this.Status.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
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
            this.TenLoaiVatTu.Width = 410;
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
            this.QuyCach.Width = 200;
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
            // ChuThich
            // 
            this.ChuThich.Caption = "Chú thích";
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
            this.groupControl3.Controls.Add(this.txtKhoChuyen);
            this.groupControl3.Controls.Add(this.txtNguoiGiao);
            this.groupControl3.Controls.Add(this.txtChuThich);
            this.groupControl3.Controls.Add(this.labelControl12);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(704, 83);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Thông tin Chung";
            // 
            // txtKhoChuyen
            // 
            this.txtKhoChuyen.Location = new System.Drawing.Point(73, 28);
            this.txtKhoChuyen.Name = "txtKhoChuyen";
            this.txtKhoChuyen.Properties.ReadOnly = true;
            this.txtKhoChuyen.Size = new System.Drawing.Size(380, 20);
            this.txtKhoChuyen.TabIndex = 0;
            this.txtKhoChuyen.TabStop = false;
            // 
            // txtNguoiGiao
            // 
            this.txtNguoiGiao.Location = new System.Drawing.Point(529, 28);
            this.txtNguoiGiao.Name = "txtNguoiGiao";
            this.txtNguoiGiao.Properties.ReadOnly = true;
            this.txtNguoiGiao.Size = new System.Drawing.Size(160, 20);
            this.txtNguoiGiao.TabIndex = 1;
            this.txtNguoiGiao.TabStop = false;
            // 
            // txtChuThich
            // 
            this.txtChuThich.Location = new System.Drawing.Point(73, 54);
            this.txtChuThich.Name = "txtChuThich";
            this.txtChuThich.Properties.MaxLength = 300;
            this.txtChuThich.Properties.ReadOnly = true;
            this.txtChuThich.Size = new System.Drawing.Size(616, 20);
            this.txtChuThich.TabIndex = 2;
            this.txtChuThich.TabStop = false;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(22, 57);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(45, 13);
            this.labelControl12.TabIndex = 28;
            this.labelControl12.Text = "Chú thích";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(472, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Người giao";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Kho chuyển";
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
            // ToolbarLd
            // 
            this.ToolbarLd.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarLd.Appearance.Options.UseBackColor = true;
            this.ToolbarLd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolbarLd.Location = new System.Drawing.Point(0, 573);
            this.ToolbarLd.Name = "ToolbarLd";
            this.ToolbarLd.SenderName = INVENTORY.CONTROL.ToolbarLd.Action.None;
            this.ToolbarLd.Size = new System.Drawing.Size(884, 28);
            this.ToolbarLd.TabIndex = 2;
            this.ToolbarLd.Clicked += new System.EventHandler(this.ToolbarLd_Clicked);
            // 
            // frmPhieuNhapNbAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 601);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.ToolbarLd);
            this.Controls.Add(this.PanelThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhieuNhapNbAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xác nhận Hàng chuyển kho";
            this.Load += new System.EventHandler(this.frmPhieuNhapNbAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_txtChuThich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelThongTin)).EndInit();
            this.PanelThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoChuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiGiao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.ComponentModel.BackgroundWorker brgWorker;
        private DevExpress.XtraEditors.PanelControl PanelThongTin;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtNgayTao;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSoPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txtKhoChuyen;
        private DevExpress.XtraEditors.TextEdit txtNguoiGiao;
        private DevExpress.XtraEditors.TextEdit txtChuThich;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private INVENTORY.CONTROL.ToolbarLd ToolbarLd;
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
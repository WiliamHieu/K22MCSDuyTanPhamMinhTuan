namespace INVENTORY.WinApp.BAOCAO.FORM
{
    partial class frmHangTonTheoKho
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
            this.hangTonKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangTon = new INVENTORY.WinApp.DATASET.HangTon();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ucNhomVatTu = new INVENTORY.WinApp.CONTROL.ucNhomVatTu();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.cboKhoHang = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridMain = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldTenKhoHang = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTenNhomVatTu = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTenLoaiVatTu = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSoLuong = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtTenNhomVatTu = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLoaiVatTu = new DevExpress.XtraEditors.TextEdit();
            this.BrgWorker = new System.ComponentModel.BackgroundWorker();
            this.ToolbarBc = new INVENTORY.CONTROL.ToolbarBc();
            ((System.ComponentModel.ISupportInitialize)(this.hangTonKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhomVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiVatTu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hangTonKhoBindingSource
            // 
            this.hangTonKhoBindingSource.DataMember = "HangTonKho";
            this.hangTonKhoBindingSource.DataSource = this.hangTon;
            // 
            // hangTon
            // 
            this.hangTon.DataSetName = "HangTon";
            this.hangTon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 28);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1294, 640);
            this.splitContainerControl1.SplitterPosition = 200;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ucNhomVatTu);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 60);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(200, 580);
            this.groupControl2.TabIndex = 2;
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
            this.ucNhomVatTu.Size = new System.Drawing.Size(196, 557);
            this.ucNhomVatTu.TabIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.cboKhoHang);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(200, 60);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Tìm kiếm";
            // 
            // cboKhoHang
            // 
            this.cboKhoHang.Location = new System.Drawing.Point(12, 30);
            this.cboKhoHang.Name = "cboKhoHang";
            this.cboKhoHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhoHang.Properties.DropDownRows = 12;
            this.cboKhoHang.Properties.NullText = " -- Kho hàng --";
            this.cboKhoHang.Properties.PopupFormMinSize = new System.Drawing.Size(178, 220);
            this.cboKhoHang.Properties.PopupFormSize = new System.Drawing.Size(178, 220);
            this.cboKhoHang.Properties.PopupSizeable = false;
            this.cboKhoHang.Properties.SelectAllItemCaption = "(Chọn tất cả)";
            this.cboKhoHang.Properties.ShowButtons = false;
            this.cboKhoHang.Properties.ShowPopupCloseButton = false;
            this.cboKhoHang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboKhoHang.Size = new System.Drawing.Size(178, 20);
            this.cboKhoHang.TabIndex = 0;
            this.cboKhoHang.EditValueChanged += new System.EventHandler(this.cboKhoHang_EditValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridMain);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1088, 640);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin Hàng tồn";
            // 
            // gridMain
            // 
            this.gridMain.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridMain.Appearance.FieldValueTotal.Options.UseFont = true;
            this.gridMain.Appearance.TotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridMain.Appearance.TotalCell.Options.UseFont = true;
            this.gridMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridMain.DataSource = this.hangTonKhoBindingSource;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldTenKhoHang,
            this.fieldTenNhomVatTu,
            this.fieldTenLoaiVatTu,
            this.fieldSoLuong});
            this.gridMain.Location = new System.Drawing.Point(2, 43);
            this.gridMain.Name = "gridMain";
            this.gridMain.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea;
            this.gridMain.OptionsDataField.AreaIndex = 0;
            this.gridMain.OptionsView.ShowColumnHeaders = false;
            this.gridMain.OptionsView.ShowDataHeaders = false;
            this.gridMain.OptionsView.ShowFilterHeaders = false;
            this.gridMain.Size = new System.Drawing.Size(1084, 595);
            this.gridMain.TabIndex = 1;
            this.gridMain.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.gridMain_FieldValueDisplayText);
            // 
            // fieldTenKhoHang
            // 
            this.fieldTenKhoHang.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldTenKhoHang.AreaIndex = 0;
            this.fieldTenKhoHang.Caption = "Kho hàng";
            this.fieldTenKhoHang.CellFormat.FormatString = "N0";
            this.fieldTenKhoHang.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldTenKhoHang.FieldName = "TenKhoHang";
            this.fieldTenKhoHang.GrandTotalCellFormat.FormatString = "N0";
            this.fieldTenKhoHang.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldTenKhoHang.GrandTotalText = "Tổng cộng";
            this.fieldTenKhoHang.Name = "fieldTenKhoHang";
            this.fieldTenKhoHang.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            this.fieldTenKhoHang.Width = 70;
            // 
            // fieldTenNhomVatTu
            // 
            this.fieldTenNhomVatTu.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldTenNhomVatTu.AreaIndex = 0;
            this.fieldTenNhomVatTu.Caption = "Nhóm vật tư";
            this.fieldTenNhomVatTu.FieldName = "TenNhomVatTu";
            this.fieldTenNhomVatTu.Name = "fieldTenNhomVatTu";
            this.fieldTenNhomVatTu.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            this.fieldTenNhomVatTu.Width = 150;
            // 
            // fieldTenLoaiVatTu
            // 
            this.fieldTenLoaiVatTu.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldTenLoaiVatTu.AreaIndex = 1;
            this.fieldTenLoaiVatTu.Caption = "Loại vật tư";
            this.fieldTenLoaiVatTu.FieldName = "TenLoaiVatTu";
            this.fieldTenLoaiVatTu.Name = "fieldTenLoaiVatTu";
            this.fieldTenLoaiVatTu.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            this.fieldTenLoaiVatTu.Width = 250;
            // 
            // fieldSoLuong
            // 
            this.fieldSoLuong.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSoLuong.AreaIndex = 0;
            this.fieldSoLuong.Caption = "Số lượng";
            this.fieldSoLuong.CellFormat.FormatString = "N0";
            this.fieldSoLuong.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldSoLuong.EmptyCellText = "-";
            this.fieldSoLuong.EmptyValueText = "-";
            this.fieldSoLuong.FieldName = "SoLuong";
            this.fieldSoLuong.Name = "fieldSoLuong";
            this.fieldSoLuong.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            this.fieldSoLuong.ValueFormat.FormatString = "N0";
            this.fieldSoLuong.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.txtTenNhomVatTu);
            this.panelControl1.Controls.Add(this.txtTenLoaiVatTu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1084, 22);
            this.panelControl1.TabIndex = 0;
            // 
            // txtTenNhomVatTu
            // 
            this.txtTenNhomVatTu.EditValue = "";
            this.txtTenNhomVatTu.EnterMoveNextControl = true;
            this.txtTenNhomVatTu.Location = new System.Drawing.Point(2, 1);
            this.txtTenNhomVatTu.Name = "txtTenNhomVatTu";
            this.txtTenNhomVatTu.Properties.MaxLength = 100;
            this.txtTenNhomVatTu.Properties.NullText = "Hãng sản xuất";
            this.txtTenNhomVatTu.Size = new System.Drawing.Size(147, 20);
            this.txtTenNhomVatTu.TabIndex = 0;
            this.txtTenNhomVatTu.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtKeySearch_EditValueChanging);
            // 
            // txtTenLoaiVatTu
            // 
            this.txtTenLoaiVatTu.EditValue = "";
            this.txtTenLoaiVatTu.EnterMoveNextControl = true;
            this.txtTenLoaiVatTu.Location = new System.Drawing.Point(149, 1);
            this.txtTenLoaiVatTu.Name = "txtTenLoaiVatTu";
            this.txtTenLoaiVatTu.Properties.MaxLength = 100;
            this.txtTenLoaiVatTu.Properties.NullText = "Loại sản phẩm";
            this.txtTenLoaiVatTu.Size = new System.Drawing.Size(246, 20);
            this.txtTenLoaiVatTu.TabIndex = 1;
            this.txtTenLoaiVatTu.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtKeySearch_EditValueChanging);
            // 
            // BrgWorker
            // 
            this.BrgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BrgWorker_DoWork);
            this.BrgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BrgWorker_RunWorkerCompleted);
            // 
            // ToolbarBc
            // 
            this.ToolbarBc.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolbarBc.Location = new System.Drawing.Point(0, 0);
            this.ToolbarBc.Name = "ToolbarBc";
            this.ToolbarBc.SenderName = INVENTORY.CONTROL.ToolbarBc.Action.None;
            this.ToolbarBc.Size = new System.Drawing.Size(1294, 28);
            this.ToolbarBc.TabIndex = 1;
            this.ToolbarBc.Clicked += new System.EventHandler(this.ToolbarBc_Clicked);
            // 
            // frmHangTonTheoKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 668);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ToolbarBc);
            this.Name = "frmHangTonTheoKho";
            this.Text = "Hàng tồn theo kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHangTonTheoKho_FormClosing);
            this.Load += new System.EventHandler(this.frmHangTonTheoKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangTonKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhomVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiVatTu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private INVENTORY.CONTROL.ToolbarBc ToolbarBc;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.ComponentModel.BackgroundWorker BrgWorker;
        private System.Windows.Forms.BindingSource hangTonKhoBindingSource;
        private INVENTORY.WinApp.DATASET.HangTon hangTon;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cboKhoHang;
        private CONTROL.ucNhomVatTu ucNhomVatTu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraPivotGrid.PivotGridControl gridMain;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTenKhoHang;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTenNhomVatTu;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTenLoaiVatTu;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSoLuong;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenNhomVatTu;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiVatTu;
    }
}
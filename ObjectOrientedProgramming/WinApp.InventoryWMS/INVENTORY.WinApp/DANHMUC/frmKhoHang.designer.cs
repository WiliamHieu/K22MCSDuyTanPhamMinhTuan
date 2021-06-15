namespace INVENTORY.WinApp.DANHMUC
{
    partial class frmKhoHang
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
            this.Toolbar = new INVENTORY.CONTROL.Toolbar();
            this.mainSplit = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.ucChiNhanh = new INVENTORY.WinApp.CONTROL.ucChiNhanh();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThuTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChuThich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_cboTrangThai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).BeginInit();
            this.mainSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_cboTrangThai)).BeginInit();
            this.SuspendLayout();
            // 
            // Toolbar
            // 
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.SenderName = INVENTORY.CONTROL.Toolbar.Action.None;
            this.Toolbar.Size = new System.Drawing.Size(1294, 28);
            this.Toolbar.TabIndex = 0;
            this.Toolbar.Clicked += new System.EventHandler(this.Toolbar_Clicked);
            this.Toolbar.Changed += new System.EventHandler(this.Toolbar_Changed);
            // 
            // mainSplit
            // 
            this.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit.Location = new System.Drawing.Point(0, 28);
            this.mainSplit.Name = "mainSplit";
            this.mainSplit.Panel1.Controls.Add(this.groupControl3);
            this.mainSplit.Panel1.Text = "Panel1";
            this.mainSplit.Panel2.Controls.Add(this.gridMain);
            this.mainSplit.Panel2.Text = "Panel2";
            this.mainSplit.Size = new System.Drawing.Size(1294, 640);
            this.mainSplit.SplitterPosition = 200;
            this.mainSplit.TabIndex = 1;
            this.mainSplit.Text = "mainSplit";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.ucChiNhanh);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(200, 640);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Chi nhánh";
            // 
            // ucChiNhanh
            // 
            this.ucChiNhanh.Appearance.BackColor = System.Drawing.Color.White;
            this.ucChiNhanh.Appearance.Options.UseBackColor = true;
            this.ucChiNhanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucChiNhanh.Location = new System.Drawing.Point(2, 21);
            this.ucChiNhanh.Name = "ucChiNhanh";
            this.ucChiNhanh.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ucChiNhanh.Size = new System.Drawing.Size(196, 617);
            this.ucChiNhanh.TabIndex = 0;
            // 
            // gridMain
            // 
            this.gridMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(0, 0);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gridMain_cboTrangThai});
            this.gridMain.Size = new System.Drawing.Size(1088, 640);
            this.gridMain.TabIndex = 0;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
            this.gridMain.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridMain_ProcessGridKey);
            // 
            // gridMainView
            // 
            this.gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Ten,
            this.ThuTu,
            this.ChuThich,
            this.TrangThai});
            this.gridMainView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.GroupPanelText = "Kéo cột tương ứng thả vào đây để nhóm dữ liệu";
            this.gridMainView.IndicatorWidth = 37;
            this.gridMainView.Name = "gridMainView";
            this.gridMainView.OptionsBehavior.Editable = false;
            this.gridMainView.OptionsNavigation.AutoFocusNewRow = true;
            this.gridMainView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridMainView.OptionsView.ShowAutoFilterRow = true;
            this.gridMainView.OptionsView.ShowDetailButtons = false;
            this.gridMainView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridMainView_CustomDrawRowIndicator);
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
            // Ten
            // 
            this.Ten.Caption = "Tên";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.OptionsColumn.AllowEdit = false;
            this.Ten.OptionsColumn.FixedWidth = true;
            this.Ten.OptionsFilter.AllowFilter = false;
            this.Ten.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 0;
            this.Ten.Width = 300;
            // 
            // ThuTu
            // 
            this.ThuTu.AppearanceCell.Options.UseTextOptions = true;
            this.ThuTu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ThuTu.AppearanceHeader.Options.UseTextOptions = true;
            this.ThuTu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ThuTu.Caption = "Thứ tự";
            this.ThuTu.FieldName = "ThuTu";
            this.ThuTu.Name = "ThuTu";
            this.ThuTu.OptionsColumn.FixedWidth = true;
            this.ThuTu.OptionsFilter.AllowFilter = false;
            this.ThuTu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ThuTu.Visible = true;
            this.ThuTu.VisibleIndex = 1;
            this.ThuTu.Width = 60;
            // 
            // ChuThich
            // 
            this.ChuThich.Caption = "Chú thích";
            this.ChuThich.FieldName = "ChuThich";
            this.ChuThich.Name = "ChuThich";
            this.ChuThich.OptionsColumn.AllowEdit = false;
            this.ChuThich.OptionsFilter.AllowFilter = false;
            this.ChuThich.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ChuThich.Visible = true;
            this.ChuThich.VisibleIndex = 2;
            this.ChuThich.Width = 513;
            // 
            // TrangThai
            // 
            this.TrangThai.AppearanceHeader.Options.UseTextOptions = true;
            this.TrangThai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TrangThai.Caption = "Trạng thái";
            this.TrangThai.ColumnEdit = this.gridMain_cboTrangThai;
            this.TrangThai.FieldName = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.OptionsColumn.AllowEdit = false;
            this.TrangThai.OptionsColumn.FixedWidth = true;
            this.TrangThai.OptionsFilter.AllowFilter = false;
            this.TrangThai.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TrangThai.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 3;
            this.TrangThai.Width = 70;
            // 
            // gridMain_cboTrangThai
            // 
            this.gridMain_cboTrangThai.AutoHeight = false;
            this.gridMain_cboTrangThai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridMain_cboTrangThai.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên")});
            this.gridMain_cboTrangThai.DisplayMember = "Ten";
            this.gridMain_cboTrangThai.DropDownRows = 4;
            this.gridMain_cboTrangThai.ImmediatePopup = true;
            this.gridMain_cboTrangThai.Name = "gridMain_cboTrangThai";
            this.gridMain_cboTrangThai.NullText = "";
            this.gridMain_cboTrangThai.PopupFormMinSize = new System.Drawing.Size(53, 0);
            this.gridMain_cboTrangThai.PopupWidth = 53;
            this.gridMain_cboTrangThai.ShowFooter = false;
            this.gridMain_cboTrangThai.ShowHeader = false;
            this.gridMain_cboTrangThai.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gridMain_cboTrangThai.ValueMember = "Id";
            // 
            // frmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 668);
            this.Controls.Add(this.mainSplit);
            this.Controls.Add(this.Toolbar);
            this.Name = "frmKhoHang";
            this.Text = "Kho hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmKhoHang_Activated);
            this.Load += new System.EventHandler(this.frmKhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).EndInit();
            this.mainSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_cboTrangThai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private INVENTORY.CONTROL.Toolbar Toolbar;
        private DevExpress.XtraEditors.SplitContainerControl mainSplit;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private CONTROL.ucChiNhanh ucChiNhanh;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn ThuTu;
        private DevExpress.XtraGrid.Columns.GridColumn ChuThich;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gridMain_cboTrangThai;
    }
}
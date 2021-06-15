namespace INVENTORY.WinApp.HETHONG
{
    partial class frmVaiTro
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
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThuTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChuThich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_cboTrangThai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
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
            this.Toolbar.Size = new System.Drawing.Size(1284, 28);
            this.Toolbar.TabIndex = 5;
            this.Toolbar.Clicked += new System.EventHandler(this.Toolbar_Clicked);
            this.Toolbar.Changed += new System.EventHandler(this.Toolbar_Changed);
            // 
            // gridMain
            // 
            this.gridMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(0, 28);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gridMain_cboTrangThai});
            this.gridMain.Size = new System.Drawing.Size(1284, 633);
            this.gridMain.TabIndex = 6;
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
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.GroupPanelText = "Kéo cột tương ứng thả vào đây để nhóm dữ liệu";
            this.gridMainView.IndicatorWidth = 37;
            this.gridMainView.Name = "gridMainView";
            this.gridMainView.OptionsBehavior.Editable = false;
            this.gridMainView.OptionsNavigation.AutoFocusNewRow = true;
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
            this.Id.OptionsFilter.AllowFilter = false;
            this.Id.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            // 
            // Ten
            // 
            this.Ten.Caption = "Tên";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.OptionsColumn.FixedWidth = true;
            this.Ten.OptionsFilter.AllowFilter = false;
            this.Ten.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.Ten.UnboundType = DevExpress.Data.UnboundColumnType.String;
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
            this.ChuThich.Caption = "Ghi chú";
            this.ChuThich.FieldName = "ChuThich";
            this.ChuThich.Name = "ChuThich";
            this.ChuThich.OptionsFilter.AllowFilter = false;
            this.ChuThich.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.ChuThich.Visible = true;
            this.ChuThich.VisibleIndex = 2;
            this.ChuThich.Width = 532;
            // 
            // TrangThai
            // 
            this.TrangThai.AppearanceHeader.Options.UseTextOptions = true;
            this.TrangThai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TrangThai.Caption = "Trạng thái";
            this.TrangThai.ColumnEdit = this.gridMain_cboTrangThai;
            this.TrangThai.FieldName = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.OptionsColumn.FixedWidth = true;
            this.TrangThai.OptionsFilter.AllowFilter = false;
            this.TrangThai.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 3;
            this.TrangThai.Width = 80;
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
            this.gridMain_cboTrangThai.PopupFormMinSize = new System.Drawing.Size(63, 0);
            this.gridMain_cboTrangThai.PopupWidth = 63;
            this.gridMain_cboTrangThai.ShowFooter = false;
            this.gridMain_cboTrangThai.ShowHeader = false;
            this.gridMain_cboTrangThai.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gridMain_cboTrangThai.ValueMember = "Id";
            // 
            // frmVaiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.Toolbar);
            this.Name = "frmVaiTro";
            this.Text = "Quản lý Vai trò";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmVaiTro_Activated);
            this.Load += new System.EventHandler(this.frmVaiTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_cboTrangThai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private INVENTORY.CONTROL.Toolbar Toolbar;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn ChuThich;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gridMain_cboTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn ThuTu;
    }
}
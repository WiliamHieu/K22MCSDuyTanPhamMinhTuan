namespace INVENTORY.WinApp.KHOHANG
{
    partial class frmHangTon
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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.ucNhomVatTu = new INVENTORY.WinApp.CONTROL.ucNhomVatTu();
            this.ToolbarBc = new INVENTORY.CONTROL.ToolbarBc();
            this.splitMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuInAn = new System.Windows.Forms.ToolStripMenuItem();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdLoaiVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.brgWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.ucNhomVatTu);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(200, 630);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Nhóm vật tư";
            // 
            // ucNhomVatTu
            // 
            this.ucNhomVatTu.Appearance.BackColor = System.Drawing.Color.White;
            this.ucNhomVatTu.Appearance.Options.UseBackColor = true;
            this.ucNhomVatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNhomVatTu.Location = new System.Drawing.Point(2, 21);
            this.ucNhomVatTu.Margin = new System.Windows.Forms.Padding(0);
            this.ucNhomVatTu.Name = "ucNhomVatTu";
            this.ucNhomVatTu.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ucNhomVatTu.Size = new System.Drawing.Size(196, 607);
            this.ucNhomVatTu.TabIndex = 0;
            this.ucNhomVatTu.FocusedNodeChanged += new System.EventHandler(this.ucNhomVatTu_FocusedNodeChanged);
            // 
            // ToolbarBc
            // 
            this.ToolbarBc.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolbarBc.Location = new System.Drawing.Point(0, 0);
            this.ToolbarBc.Name = "ToolbarBc";
            this.ToolbarBc.SenderName = INVENTORY.CONTROL.ToolbarBc.Action.None;
            this.ToolbarBc.Size = new System.Drawing.Size(1151, 30);
            this.ToolbarBc.TabIndex = 1;
            this.ToolbarBc.Clicked += new System.EventHandler(this.ToolbarBc_Clicked);
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 30);
            this.splitMain.Name = "splitMain";
            this.splitMain.Panel1.Controls.Add(this.groupControl3);
            this.splitMain.Panel1.Text = "Panel1";
            this.splitMain.Panel2.Controls.Add(this.groupControl1);
            this.splitMain.Panel2.Text = "Panel2";
            this.splitMain.Size = new System.Drawing.Size(1151, 630);
            this.splitMain.SplitterPosition = 200;
            this.splitMain.TabIndex = 2;
            this.splitMain.Text = "splitMain";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridMain);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(945, 630);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin Hàng tồn";
            // 
            // gridMain
            // 
            this.gridMain.ContextMenuStrip = this.MainMenu;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(2, 21);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(941, 607);
            this.gridMain.TabIndex = 0;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInAn});
            this.MainMenu.Name = "MenuNhap";
            this.MainMenu.Size = new System.Drawing.Size(128, 26);
            // 
            // mnuInAn
            // 
            this.mnuInAn.Image = global::INVENTORY.WinApp.Properties.Resources.printer_empty;
            this.mnuInAn.Name = "mnuInAn";
            this.mnuInAn.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuInAn.Size = new System.Drawing.Size(127, 22);
            this.mnuInAn.Text = "In tem";
            // 
            // gridMainView
            // 
            this.gridMainView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdLoaiVatTu,
            this.TenLoaiVatTu,
            this.QuyCach,
            this.TenDonViTinh,
            this.SoLuong});
            this.gridMainView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.IndicatorWidth = 37;
            this.gridMainView.LevelIndent = 0;
            this.gridMainView.Name = "gridMainView";
            this.gridMainView.OptionsBehavior.Editable = false;
            this.gridMainView.OptionsSelection.InvertSelection = true;
            this.gridMainView.OptionsSelection.MultiSelect = true;
            this.gridMainView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridMainView.OptionsView.ShowAutoFilterRow = true;
            this.gridMainView.OptionsView.ShowFooter = true;
            this.gridMainView.OptionsView.ShowGroupPanel = false;
            this.gridMainView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridMainView_CustomDrawRowIndicator);
            // 
            // IdLoaiVatTu
            // 
            this.IdLoaiVatTu.Caption = "IdLoaiVatTu";
            this.IdLoaiVatTu.FieldName = "IdLoaiVatTu";
            this.IdLoaiVatTu.Name = "IdLoaiVatTu";
            this.IdLoaiVatTu.OptionsFilter.AllowFilter = false;
            this.IdLoaiVatTu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
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
            this.TenLoaiVatTu.Width = 644;
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
            // brgWorker
            // 
            this.brgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.brgWorker_DoWork);
            this.brgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.brgWorker_RunWorkerCompleted);
            // 
            // frmHangTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 660);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.ToolbarBc);
            this.Name = "frmHangTon";
            this.Text = "Hàng tồn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmHangTon_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHangTon_FormClosing);
            this.Load += new System.EventHandler(this.frmHangTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.MainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private INVENTORY.CONTROL.ToolbarBc ToolbarBc;
        private DevExpress.XtraEditors.SplitContainerControl splitMain;
        private System.ComponentModel.BackgroundWorker brgWorker;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn IdLoaiVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private INVENTORY.WinApp.CONTROL.ucNhomVatTu ucNhomVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn TenDonViTinh;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuInAn;
        private DevExpress.XtraGrid.Columns.GridColumn QuyCach;
    }
}
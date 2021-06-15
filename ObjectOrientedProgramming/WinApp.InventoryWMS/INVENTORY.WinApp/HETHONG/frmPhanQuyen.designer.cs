namespace INVENTORY.WinApp.HETHONG
{
    partial class frmPhanQuyen
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
            this.splitMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ucVaiTro = new INVENTORY.WinApp.CONTROL.ucVaiTro();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThayDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenPhanHe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Xem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain_chkCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Them = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Xoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToolbarGia = new INVENTORY.CONTROL.ToolbarGia();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_chkCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 28);
            this.splitMain.Name = "splitMain";
            this.splitMain.Panel1.Controls.Add(this.groupControl1);
            this.splitMain.Panel1.Text = "Panel1";
            this.splitMain.Panel2.Controls.Add(this.groupControl2);
            this.splitMain.Panel2.Text = "Panel2";
            this.splitMain.Size = new System.Drawing.Size(1284, 633);
            this.splitMain.SplitterPosition = 185;
            this.splitMain.TabIndex = 7;
            this.splitMain.Text = "splitMain";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ucVaiTro);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(185, 633);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Vai trò";
            // 
            // ucVaiTro
            // 
            this.ucVaiTro.Appearance.BackColor = System.Drawing.Color.White;
            this.ucVaiTro.Appearance.Options.UseBackColor = true;
            this.ucVaiTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucVaiTro.FocusedNode = null;
            this.ucVaiTro.Location = new System.Drawing.Point(2, 21);
            this.ucVaiTro.Name = "ucVaiTro";
            this.ucVaiTro.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ucVaiTro.Size = new System.Drawing.Size(181, 610);
            this.ucVaiTro.TabIndex = 1;
            this.ucVaiTro.FocusedNodeChanged += new System.EventHandler(this.ucVaiTro_FocusedNodeChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridMain);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1093, 633);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Quyền hạn";
            // 
            // gridMain
            // 
            this.gridMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(2, 21);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gridMain_chkCheck});
            this.gridMain.Size = new System.Drawing.Size(1089, 610);
            this.gridMain.TabIndex = 6;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
            // 
            // gridMainView
            // 
            this.gridMainView.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridMainView.Appearance.GroupRow.Options.UseFont = true;
            this.gridMainView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.ThayDoi,
            this.TenPhanHe,
            this.TenChucNang,
            this.Xem,
            this.Them,
            this.Sua,
            this.Xoa});
            this.gridMainView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.GroupCount = 1;
            this.gridMainView.GroupFormat = "{1} {2}";
            this.gridMainView.GroupPanelText = "Kéo cột tương ứng thả vào đây để nhóm dữ liệu";
            this.gridMainView.IndicatorWidth = 37;
            this.gridMainView.LevelIndent = 0;
            this.gridMainView.Name = "gridMainView";
            this.gridMainView.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridMainView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridMainView.OptionsView.ShowAutoFilterRow = true;
            this.gridMainView.OptionsView.ShowDetailButtons = false;
            this.gridMainView.OptionsView.ShowGroupPanel = false;
            this.gridMainView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TenPhanHe, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridMainView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridMainView_CustomDrawRowIndicator);
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
            // ThayDoi
            // 
            this.ThayDoi.Caption = "ThayDoi";
            this.ThayDoi.FieldName = "ThayDoi";
            this.ThayDoi.Name = "ThayDoi";
            // 
            // TenPhanHe
            // 
            this.TenPhanHe.Caption = "Phân hệ";
            this.TenPhanHe.FieldName = "TenPhanHe";
            this.TenPhanHe.FieldNameSortGroup = "ThuTuPhanHe";
            this.TenPhanHe.Name = "TenPhanHe";
            this.TenPhanHe.OptionsColumn.AllowEdit = false;
            this.TenPhanHe.OptionsColumn.FixedWidth = true;
            this.TenPhanHe.OptionsFilter.AllowFilter = false;
            this.TenPhanHe.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.TenPhanHe.Width = 130;
            // 
            // TenChucNang
            // 
            this.TenChucNang.Caption = "Chức năng";
            this.TenChucNang.FieldName = "TenChucNang";
            this.TenChucNang.Name = "TenChucNang";
            this.TenChucNang.OptionsColumn.AllowEdit = false;
            this.TenChucNang.OptionsFilter.AllowFilter = false;
            this.TenChucNang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenChucNang.Visible = true;
            this.TenChucNang.VisibleIndex = 0;
            this.TenChucNang.Width = 262;
            // 
            // Xem
            // 
            this.Xem.AppearanceCell.Options.UseTextOptions = true;
            this.Xem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Xem.AppearanceHeader.Options.UseTextOptions = true;
            this.Xem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Xem.Caption = "Xem";
            this.Xem.ColumnEdit = this.gridMain_chkCheck;
            this.Xem.FieldName = "Xem";
            this.Xem.Name = "Xem";
            this.Xem.OptionsColumn.AllowEdit = false;
            this.Xem.OptionsColumn.FixedWidth = true;
            this.Xem.OptionsFilter.AllowFilter = false;
            this.Xem.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Xem.Visible = true;
            this.Xem.VisibleIndex = 1;
            this.Xem.Width = 70;
            // 
            // gridMain_chkCheck
            // 
            this.gridMain_chkCheck.AutoHeight = false;
            this.gridMain_chkCheck.Caption = "Check";
            this.gridMain_chkCheck.Name = "gridMain_chkCheck";
            this.gridMain_chkCheck.CheckedChanged += new System.EventHandler(this.gridMain_chkCheck_CheckedChanged);
            // 
            // Them
            // 
            this.Them.AppearanceCell.Options.UseTextOptions = true;
            this.Them.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Them.AppearanceHeader.Options.UseTextOptions = true;
            this.Them.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Them.Caption = "Thêm";
            this.Them.ColumnEdit = this.gridMain_chkCheck;
            this.Them.FieldName = "Them";
            this.Them.Name = "Them";
            this.Them.OptionsColumn.AllowEdit = false;
            this.Them.OptionsColumn.FixedWidth = true;
            this.Them.OptionsFilter.AllowFilter = false;
            this.Them.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Them.Visible = true;
            this.Them.VisibleIndex = 2;
            this.Them.Width = 70;
            // 
            // Sua
            // 
            this.Sua.AppearanceCell.Options.UseTextOptions = true;
            this.Sua.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Sua.AppearanceHeader.Options.UseTextOptions = true;
            this.Sua.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Sua.Caption = "Sửa";
            this.Sua.ColumnEdit = this.gridMain_chkCheck;
            this.Sua.FieldName = "Sua";
            this.Sua.Name = "Sua";
            this.Sua.OptionsColumn.AllowEdit = false;
            this.Sua.OptionsColumn.FixedWidth = true;
            this.Sua.OptionsFilter.AllowFilter = false;
            this.Sua.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Sua.Visible = true;
            this.Sua.VisibleIndex = 3;
            this.Sua.Width = 70;
            // 
            // Xoa
            // 
            this.Xoa.AppearanceCell.Options.UseTextOptions = true;
            this.Xoa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Xoa.AppearanceHeader.Options.UseTextOptions = true;
            this.Xoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Xoa.Caption = "Xóa";
            this.Xoa.ColumnEdit = this.gridMain_chkCheck;
            this.Xoa.FieldName = "Xoa";
            this.Xoa.Name = "Xoa";
            this.Xoa.OptionsColumn.AllowEdit = false;
            this.Xoa.OptionsColumn.FixedWidth = true;
            this.Xoa.OptionsFilter.AllowFilter = false;
            this.Xoa.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Xoa.Visible = true;
            this.Xoa.VisibleIndex = 4;
            this.Xoa.Width = 70;
            // 
            // ToolbarGia
            // 
            this.ToolbarGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolbarGia.Location = new System.Drawing.Point(0, 0);
            this.ToolbarGia.Name = "ToolbarGia";
            this.ToolbarGia.SenderName = INVENTORY.CONTROL.ToolbarGia.Action.None;
            this.ToolbarGia.Size = new System.Drawing.Size(1284, 28);
            this.ToolbarGia.TabIndex = 7;
            this.ToolbarGia.Clicked += new System.EventHandler(this.ToolbarGia_Clicked);
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.ToolbarGia);
            this.Name = "frmPhanQuyen";
            this.Text = "Phân quyền Vai trò";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmPhanQuyen_Activated);
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_chkCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitMain;
        private INVENTORY.CONTROL.ToolbarGia ToolbarGia;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn TenPhanHe;
        private DevExpress.XtraGrid.Columns.GridColumn TenChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn Xem;
        private DevExpress.XtraGrid.Columns.GridColumn Them;
        private DevExpress.XtraGrid.Columns.GridColumn Sua;
        private DevExpress.XtraGrid.Columns.GridColumn Xoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit gridMain_chkCheck;
        private DevExpress.XtraGrid.Columns.GridColumn ThayDoi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private CONTROL.ucVaiTro ucVaiTro;
    }
}
namespace SMSSC.WinApp
{
    partial class frmMessageHistory
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
            this.BrgWorker = new System.ComponentModel.BackgroundWorker();
            this.Toolbar01 = new SMSSC.CONTROL.Toolbar01();
            this.TabMain = new DevExpress.XtraTab.XtraTabControl();
            this.Tab_0 = new DevExpress.XtraTab.XtraTabPage();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuGuiTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FromPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContentText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tab_1 = new DevExpress.XtraTab.XtraTabPage();
            this.Tab_2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.TabMain)).BeginInit();
            this.TabMain.SuspendLayout();
            this.Tab_0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            this.SuspendLayout();
            // 
            // BrgWorker
            // 
            this.BrgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BrgWorker_DoWork);
            this.BrgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BrgWorker_RunWorkerCompleted);
            // 
            // Toolbar01
            // 
            this.Toolbar01.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toolbar01.Location = new System.Drawing.Point(0, 0);
            this.Toolbar01.Name = "Toolbar01";
            this.Toolbar01.SenderName = SMSSC.CONTROL.Toolbar01.Action.None;
            this.Toolbar01.Size = new System.Drawing.Size(1184, 28);
            this.Toolbar01.TabIndex = 1;
            this.Toolbar01.TuNgay = new System.DateTime(2021, 7, 25, 0, 0, 0, 0);
            this.Toolbar01.Clicked += new System.EventHandler(this.Toolbar01_Clicked);
            // 
            // TabMain
            // 
            this.TabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMain.Location = new System.Drawing.Point(0, 28);
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedTabPage = this.Tab_0;
            this.TabMain.Size = new System.Drawing.Size(1184, 633);
            this.TabMain.TabIndex = 0;
            this.TabMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.Tab_0,
            this.Tab_1,
            this.Tab_2});
            this.TabMain.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.TabMain_SelectedPageChanged);
            this.TabMain.SelectedPageChanging += new DevExpress.XtraTab.TabPageChangingEventHandler(this.TabMain_SelectedPageChanging);
            // 
            // Tab_0
            // 
            this.Tab_0.Controls.Add(this.gridMain);
            this.Tab_0.Name = "Tab_0";
            this.Tab_0.Size = new System.Drawing.Size(1179, 607);
            this.Tab_0.Text = "Tin nhắn đi";
            // 
            // gridMain
            // 
            this.gridMain.ContextMenuStrip = this.MainMenu;
            this.gridMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(0, 0);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(1179, 607);
            this.gridMain.TabIndex = 11;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGuiTin,
            this.mnuXoa});
            this.MainMenu.Name = "ToChucMenu";
            this.MainMenu.Size = new System.Drawing.Size(140, 48);
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
            // 
            // mnuGuiTin
            // 
            this.mnuGuiTin.Image = global::SMSSC.WinApp.Properties.Resources.arrow_down;
            this.mnuGuiTin.Name = "mnuGuiTin";
            this.mnuGuiTin.Size = new System.Drawing.Size(139, 22);
            this.mnuGuiTin.Text = "Gửi tin nhắn";
            // 
            // mnuXoa
            // 
            this.mnuXoa.Image = global::SMSSC.WinApp.Properties.Resources.delete;
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.Size = new System.Drawing.Size(139, 22);
            this.mnuXoa.Text = "Xóa";
            // 
            // gridMainView
            // 
            this.gridMainView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.FromPhoneNumber,
            this.ToPhoneNumber,
            this.ContentText,
            this.StatusName,
            this.CreatedDate,
            this.SentDate,
            this.Note});
            this.gridMainView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.GroupPanelText = "Kéo cột tương ứng thả vào đây để nhóm dữ liệu";
            this.gridMainView.IndicatorWidth = 37;
            this.gridMainView.Name = "gridMainView";
            this.gridMainView.OptionsBehavior.Editable = false;
            this.gridMainView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridMainView.OptionsSelection.MultiSelect = true;
            this.gridMainView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridMainView.OptionsView.ShowAutoFilterRow = true;
            this.gridMainView.OptionsView.ShowDetailButtons = false;
            this.gridMainView.OptionsView.ShowGroupPanel = false;
            this.gridMainView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridMainView_CustomDrawRowIndicator);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.OptionsFilter.AllowFilter = false;
            this.Id.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // FromPhoneNumber
            // 
            this.FromPhoneNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.FromPhoneNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FromPhoneNumber.Caption = "Đầu số gửi";
            this.FromPhoneNumber.FieldName = "FromPhoneNumber";
            this.FromPhoneNumber.Name = "FromPhoneNumber";
            this.FromPhoneNumber.OptionsColumn.FixedWidth = true;
            this.FromPhoneNumber.OptionsFilter.AllowFilter = false;
            this.FromPhoneNumber.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.FromPhoneNumber.Visible = true;
            this.FromPhoneNumber.VisibleIndex = 0;
            this.FromPhoneNumber.Width = 80;
            // 
            // ToPhoneNumber
            // 
            this.ToPhoneNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.ToPhoneNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ToPhoneNumber.Caption = "Đầu số nhận";
            this.ToPhoneNumber.FieldName = "ToPhoneNumber";
            this.ToPhoneNumber.Name = "ToPhoneNumber";
            this.ToPhoneNumber.OptionsColumn.FixedWidth = true;
            this.ToPhoneNumber.OptionsFilter.AllowFilter = false;
            this.ToPhoneNumber.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ToPhoneNumber.Visible = true;
            this.ToPhoneNumber.VisibleIndex = 1;
            this.ToPhoneNumber.Width = 80;
            // 
            // ContentText
            // 
            this.ContentText.Caption = "Nội dung";
            this.ContentText.FieldName = "ContentText";
            this.ContentText.Name = "ContentText";
            this.ContentText.OptionsFilter.AllowFilter = false;
            this.ContentText.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ContentText.Visible = true;
            this.ContentText.VisibleIndex = 2;
            this.ContentText.Width = 243;
            // 
            // StatusName
            // 
            this.StatusName.AppearanceHeader.Options.UseTextOptions = true;
            this.StatusName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StatusName.Caption = "Trạng thái";
            this.StatusName.FieldName = "StatusName";
            this.StatusName.Name = "StatusName";
            this.StatusName.OptionsColumn.FixedWidth = true;
            this.StatusName.OptionsFilter.AllowFilter = false;
            this.StatusName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.StatusName.Visible = true;
            this.StatusName.VisibleIndex = 3;
            this.StatusName.Width = 80;
            // 
            // CreatedDate
            // 
            this.CreatedDate.AppearanceCell.Options.UseTextOptions = true;
            this.CreatedDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CreatedDate.AppearanceHeader.Options.UseTextOptions = true;
            this.CreatedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CreatedDate.Caption = "Ngày tạo";
            this.CreatedDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.CreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.CreatedDate.FieldName = "CreatedDate";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.OptionsColumn.FixedWidth = true;
            this.CreatedDate.OptionsFilter.AllowFilter = false;
            this.CreatedDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.CreatedDate.Visible = true;
            this.CreatedDate.VisibleIndex = 4;
            this.CreatedDate.Width = 95;
            // 
            // SentDate
            // 
            this.SentDate.AppearanceCell.Options.UseTextOptions = true;
            this.SentDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SentDate.AppearanceHeader.Options.UseTextOptions = true;
            this.SentDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SentDate.Caption = "Ngày gửi";
            this.SentDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.SentDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.SentDate.FieldName = "SentDate";
            this.SentDate.Name = "SentDate";
            this.SentDate.OptionsColumn.FixedWidth = true;
            this.SentDate.OptionsFilter.AllowFilter = false;
            this.SentDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.SentDate.Visible = true;
            this.SentDate.VisibleIndex = 5;
            this.SentDate.Width = 95;
            // 
            // Note
            // 
            this.Note.Caption = "Chú thích";
            this.Note.FieldName = "Note";
            this.Note.Name = "Note";
            this.Note.OptionsColumn.FixedWidth = true;
            this.Note.OptionsFilter.AllowFilter = false;
            this.Note.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Note.Visible = true;
            this.Note.VisibleIndex = 6;
            this.Note.Width = 200;
            // 
            // Tab_1
            // 
            this.Tab_1.Name = "Tab_1";
            this.Tab_1.Size = new System.Drawing.Size(1179, 607);
            this.Tab_1.Text = "Tin đã gửi";
            // 
            // Tab_2
            // 
            this.Tab_2.Name = "Tab_2";
            this.Tab_2.Size = new System.Drawing.Size(1179, 607);
            this.Tab_2.Text = "Tin nhắn đến";
            // 
            // frmMessageHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.TabMain);
            this.Controls.Add(this.Toolbar01);
            this.Name = "frmMessageHistory";
            this.Text = "Nhật ký Tin nhắn";
            this.Activated += new System.EventHandler(this.frmMessageHistory_Activated);
            this.Load += new System.EventHandler(this.frmMessageHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabMain)).EndInit();
            this.TabMain.ResumeLayout(false);
            this.Tab_0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.MainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BrgWorker;
        private SMSSC.CONTROL.Toolbar01 Toolbar01;
        private DevExpress.XtraTab.XtraTabControl TabMain;
        private DevExpress.XtraTab.XtraTabPage Tab_1;
        private DevExpress.XtraTab.XtraTabPage Tab_2;
        private DevExpress.XtraTab.XtraTabPage Tab_0;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuGuiTin;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn FromPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ToPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ContentText;
        private DevExpress.XtraGrid.Columns.GridColumn StatusName;
        private DevExpress.XtraGrid.Columns.GridColumn CreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn SentDate;
        private DevExpress.XtraGrid.Columns.GridColumn Note;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
    }
}
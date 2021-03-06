namespace SMSSC.WinApp
{
    partial class frmMessageImport
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
            this.ToolbarLd = new SMSSC.CONTROL.ToolbarLd();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FromPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContentText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtFilePath = new DevExpress.XtraEditors.ButtonEdit();
            this.cmdTapTinMau = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmdImport = new DevExpress.XtraEditors.SimpleButton();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BrgWorker
            // 
            this.BrgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BrgWorker_DoWork);
            this.BrgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BrgWorker_RunWorkerCompleted);
            // 
            // ToolbarLd
            // 
            this.ToolbarLd.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarLd.Appearance.Options.UseBackColor = true;
            this.ToolbarLd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolbarLd.Location = new System.Drawing.Point(0, 433);
            this.ToolbarLd.Name = "ToolbarLd";
            this.ToolbarLd.SenderName = SMSSC.CONTROL.ToolbarLd.Action.None;
            this.ToolbarLd.Size = new System.Drawing.Size(584, 28);
            this.ToolbarLd.TabIndex = 1;
            this.ToolbarLd.Clicked += new System.EventHandler(this.ToolbarLd_Clicked);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXoa});
            this.MainMenu.Name = "ToChucMenu";
            this.MainMenu.Size = new System.Drawing.Size(119, 26);
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
            // 
            // mnuXoa
            // 
            this.mnuXoa.Image = global::SMSSC.WinApp.Properties.Resources.delete;
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuXoa.Size = new System.Drawing.Size(118, 22);
            this.mnuXoa.Text = "&Xóa";
            // 
            // ExcelFileDialog
            // 
            this.ExcelFileDialog.Filter = "Excel file|*.xls;*.xlsx";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridMain);
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(584, 433);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // gridMain
            // 
            this.gridMain.ContextMenuStrip = this.MainMenu;
            this.gridMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(2, 59);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(580, 372);
            this.gridMain.TabIndex = 1;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
            // 
            // gridMainView
            // 
            this.gridMainView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.FromPhoneNumber,
            this.ToPhoneNumber,
            this.ContentText,
            this.Note});
            this.gridMainView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.GroupPanelText = "Kéo cột tương ứng thả vào đây để nhóm dữ liệu";
            this.gridMainView.IndicatorWidth = 30;
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
            this.ContentText.Width = 270;
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
            this.Note.VisibleIndex = 3;
            this.Note.Width = 120;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.txtFilePath);
            this.panelControl2.Controls.Add(this.cmdTapTinMau);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.cmdImport);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 21);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(580, 38);
            this.panelControl2.TabIndex = 0;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(71, 10);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtFilePath.Size = new System.Drawing.Size(227, 20);
            this.txtFilePath.TabIndex = 0;
            this.txtFilePath.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtFilePath_ButtonClick);
            // 
            // cmdTapTinMau
            // 
            this.cmdTapTinMau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdTapTinMau.Image = global::SMSSC.WinApp.Properties.Resources.arrow_down;
            this.cmdTapTinMau.Location = new System.Drawing.Point(440, 10);
            this.cmdTapTinMau.Name = "cmdTapTinMau";
            this.cmdTapTinMau.Size = new System.Drawing.Size(130, 20);
            this.cmdTapTinMau.TabIndex = 2;
            this.cmdTapTinMau.Text = "Tập tin mẫu (Ctrl+T)";
            this.cmdTapTinMau.Click += new System.EventHandler(this.cmdTapTinMau_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Đường dẫn";
            // 
            // cmdImport
            // 
            this.cmdImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdImport.Image = global::SMSSC.WinApp.Properties.Resources.accept;
            this.cmdImport.Location = new System.Drawing.Point(304, 10);
            this.cmdImport.Name = "cmdImport";
            this.cmdImport.Size = new System.Drawing.Size(130, 20);
            this.cmdImport.TabIndex = 1;
            this.cmdImport.Text = "Trích dữ liệu (Ctrl+T)";
            this.cmdImport.Click += new System.EventHandler(this.cmdImport_Click);
            // 
            // frmMessageImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ToolbarLd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMessageImport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import tin nhắn";
            this.Load += new System.EventHandler(this.frmMessageImport_Load);
            this.MainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker BrgWorker;
        private SMSSC.CONTROL.ToolbarLd ToolbarLd;
        private System.Windows.Forms.OpenFileDialog ExcelFileDialog;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton cmdImport;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit txtFilePath;
        private DevExpress.XtraEditors.SimpleButton cmdTapTinMau;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn FromPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ToPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ContentText;
        private DevExpress.XtraGrid.Columns.GridColumn Note;
    }
}
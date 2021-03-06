namespace SMSSC.WinApp
{
    partial class frmMessageTemplate
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
            this.Toolbar = new SMSSC.CONTROL.Toolbar();
            this.gridMain_cboTrangThai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContentText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_cboTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // Toolbar
            // 
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.SenderName = SMSSC.CONTROL.Toolbar.Action.None;
            this.Toolbar.Size = new System.Drawing.Size(984, 28);
            this.Toolbar.TabIndex = 0;
            this.Toolbar.Clicked += new System.EventHandler(this.Toolbar_Clicked);
            this.Toolbar.Changed += new System.EventHandler(this.Toolbar_Changed);
            // 
            // gridMain_cboTrangThai
            // 
            this.gridMain_cboTrangThai.AutoHeight = false;
            this.gridMain_cboTrangThai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridMain_cboTrangThai.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên")});
            this.gridMain_cboTrangThai.DisplayMember = "Ten";
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
            // gridMainView
            // 
            this.gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Title,
            this.ContentText,
            this.Note,
            this.Status});
            this.gridMainView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridMainView.GridControl = this.gridMain;
            this.gridMainView.GroupPanelText = "Kéo cột tương ứng thả vào đây để nhóm dữ liệu";
            this.gridMainView.IndicatorWidth = 30;
            this.gridMainView.Name = "gridMainView";
            this.gridMainView.OptionsBehavior.Editable = false;
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
            this.Id.OptionsColumn.FixedWidth = true;
            this.Id.OptionsFilter.AllowFilter = false;
            this.Id.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // Title
            // 
            this.Title.Caption = "Tiêu đề";
            this.Title.FieldName = "Title";
            this.Title.Name = "Title";
            this.Title.OptionsColumn.FixedWidth = true;
            this.Title.OptionsFilter.AllowFilter = false;
            this.Title.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Title.Visible = true;
            this.Title.VisibleIndex = 0;
            this.Title.Width = 200;
            // 
            // ContentText
            // 
            this.ContentText.Caption = "Nội dung";
            this.ContentText.FieldName = "ContentText";
            this.ContentText.Name = "ContentText";
            this.ContentText.OptionsColumn.FixedWidth = true;
            this.ContentText.OptionsFilter.AllowFilter = false;
            this.ContentText.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ContentText.Visible = true;
            this.ContentText.VisibleIndex = 1;
            this.ContentText.Width = 300;
            // 
            // Note
            // 
            this.Note.Caption = "Chú thích";
            this.Note.FieldName = "Note";
            this.Note.Name = "Note";
            this.Note.OptionsFilter.AllowFilter = false;
            this.Note.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Note.Visible = true;
            this.Note.VisibleIndex = 2;
            // 
            // Status
            // 
            this.Status.AppearanceHeader.Options.UseTextOptions = true;
            this.Status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Status.Caption = "Trạng thái";
            this.Status.ColumnEdit = this.gridMain_cboTrangThai;
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.OptionsColumn.FixedWidth = true;
            this.Status.OptionsFilter.AllowFilter = false;
            this.Status.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Status.Visible = true;
            this.Status.VisibleIndex = 3;
            this.Status.Width = 80;
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
            this.gridMain.Size = new System.Drawing.Size(984, 512);
            this.gridMain.TabIndex = 15;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
            this.gridMain.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridMain_ProcessGridKey);
            // 
            // frmMessageTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 540);
            this.ControlBox = false;
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.Toolbar);
            this.Name = "frmMessageTemplate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tin nhắn mẫu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMessageTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain_cboTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMSSC.CONTROL.Toolbar Toolbar;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gridMain_cboTrangThai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn Title;
        private DevExpress.XtraGrid.Columns.GridColumn ContentText;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Note;
    }
}
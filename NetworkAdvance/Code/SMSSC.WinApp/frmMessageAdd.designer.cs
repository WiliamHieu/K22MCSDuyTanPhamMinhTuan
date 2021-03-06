namespace SMSSC.WinApp
{
    partial class frmMessageAdd
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
            this.txtGiaCuoi = new DevExpress.XtraEditors.SpinEdit();
            this.txtGiaDau = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboTinMau = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.BrgWorker = new System.ComponentModel.BackgroundWorker();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FromPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContentText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToolbarNhap = new SMSSC.CONTROL.ToolbarNhap();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboHangSanXuat = new DevExpress.XtraEditors.LookUpEdit();
            this.cboDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.cboMang = new DevExpress.XtraEditors.LookUpEdit();
            this.cboTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.ToolbarLd = new SMSSC.CONTROL.ToolbarLd();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaCuoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTinMau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboHangSanXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGiaCuoi
            // 
            this.txtGiaCuoi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtGiaCuoi.EnterMoveNextControl = true;
            this.txtGiaCuoi.Location = new System.Drawing.Point(453, 38);
            this.txtGiaCuoi.Name = "txtGiaCuoi";
            this.txtGiaCuoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtGiaCuoi.Properties.DisplayFormat.FormatString = "N0";
            this.txtGiaCuoi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtGiaCuoi.Properties.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtGiaCuoi.Properties.IsFloatValue = false;
            this.txtGiaCuoi.Properties.Mask.EditMask = "N00";
            this.txtGiaCuoi.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtGiaCuoi.Properties.ValidateOnEnterKey = true;
            this.txtGiaCuoi.Size = new System.Drawing.Size(97, 20);
            this.txtGiaCuoi.TabIndex = 4;
            // 
            // txtGiaDau
            // 
            this.txtGiaDau.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtGiaDau.EnterMoveNextControl = true;
            this.txtGiaDau.Location = new System.Drawing.Point(350, 38);
            this.txtGiaDau.Name = "txtGiaDau";
            this.txtGiaDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtGiaDau.Properties.DisplayFormat.FormatString = "N0";
            this.txtGiaDau.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtGiaDau.Properties.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtGiaDau.Properties.IsFloatValue = false;
            this.txtGiaDau.Properties.Mask.EditMask = "N00";
            this.txtGiaDau.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtGiaDau.Properties.ValidateOnEnterKey = true;
            this.txtGiaDau.Size = new System.Drawing.Size(97, 20);
            this.txtGiaDau.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(294, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 44;
            this.labelControl1.Text = "Giá bán";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 44;
            this.labelControl4.Text = "Thời gian";
            // 
            // cboTinMau
            // 
            this.cboTinMau.EnterMoveNextControl = true;
            this.cboTinMau.Location = new System.Drawing.Point(70, 12);
            this.cboTinMau.Name = "cboTinMau";
            this.cboTinMau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTinMau.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", "Tiêu đề")});
            this.cboTinMau.Properties.DropDownRows = 10;
            this.cboTinMau.Properties.NullText = " -- Tin mẫu --";
            this.cboTinMau.Properties.PopupFormMinSize = new System.Drawing.Size(403, 0);
            this.cboTinMau.Properties.PopupWidth = 403;
            this.cboTinMau.Properties.ShowFooter = false;
            this.cboTinMau.Properties.ShowHeader = false;
            this.cboTinMau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboTinMau.Size = new System.Drawing.Size(480, 20);
            this.cboTinMau.TabIndex = 0;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(27, 15);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(37, 13);
            this.labelControl12.TabIndex = 41;
            this.labelControl12.Text = "Tin mẫu";
            // 
            // BrgWorker
            // 
            this.BrgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BrgWorker_DoWork);
            this.BrgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BrgWorker_RunWorkerCompleted);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridMain);
            this.groupControl3.Controls.Add(this.ToolbarNhap);
            this.groupControl3.Controls.Add(this.panelControl2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(584, 433);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Thông tin";
            // 
            // gridMain
            // 
            this.gridMain.ContextMenuStrip = this.MainMenu;
            this.gridMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(2, 143);
            this.gridMain.MainView = this.gridMainView;
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(580, 288);
            this.gridMain.TabIndex = 2;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMainView});
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
            this.ContentText.Width = 290;
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
            // ToolbarNhap
            // 
            this.ToolbarNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolbarNhap.Location = new System.Drawing.Point(2, 117);
            this.ToolbarNhap.Name = "ToolbarNhap";
            this.ToolbarNhap.SenderName = SMSSC.CONTROL.ToolbarNhap.Action.None;
            this.ToolbarNhap.Size = new System.Drawing.Size(580, 26);
            this.ToolbarNhap.TabIndex = 1;
            this.ToolbarNhap.Clicked += new System.EventHandler(this.ToolbarNhap_Clicked);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.cboTinMau);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl12);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.cboHangSanXuat);
            this.panelControl2.Controls.Add(this.cboDenNgay);
            this.panelControl2.Controls.Add(this.cboMang);
            this.panelControl2.Controls.Add(this.cboTuNgay);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.txtGiaDau);
            this.panelControl2.Controls.Add(this.txtGiaCuoi);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 21);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(580, 96);
            this.panelControl2.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(296, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 75;
            this.labelControl2.Text = "Nhà mạng";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 67);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 13);
            this.labelControl7.TabIndex = 73;
            this.labelControl7.Text = "Nhãn hàng";
            // 
            // cboHangSanXuat
            // 
            this.cboHangSanXuat.EnterMoveNextControl = true;
            this.cboHangSanXuat.Location = new System.Drawing.Point(70, 64);
            this.cboHangSanXuat.Name = "cboHangSanXuat";
            this.cboHangSanXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHangSanXuat.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên")});
            this.cboHangSanXuat.Properties.DropDownRows = 10;
            this.cboHangSanXuat.Properties.NullText = "-- Tất cả --";
            this.cboHangSanXuat.Properties.PopupFormMinSize = new System.Drawing.Size(163, 0);
            this.cboHangSanXuat.Properties.PopupWidth = 163;
            this.cboHangSanXuat.Properties.ShowFooter = false;
            this.cboHangSanXuat.Properties.ShowHeader = false;
            this.cboHangSanXuat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboHangSanXuat.Size = new System.Drawing.Size(200, 20);
            this.cboHangSanXuat.TabIndex = 5;
            // 
            // cboDenNgay
            // 
            this.cboDenNgay.EditValue = null;
            this.cboDenNgay.EnterMoveNextControl = true;
            this.cboDenNgay.Location = new System.Drawing.Point(173, 38);
            this.cboDenNgay.Name = "cboDenNgay";
            this.cboDenNgay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cboDenNgay.Properties.NullText = " -- Ngày xem --";
            this.cboDenNgay.Properties.ShowToday = false;
            this.cboDenNgay.Size = new System.Drawing.Size(97, 20);
            this.cboDenNgay.TabIndex = 2;
            // 
            // cboMang
            // 
            this.cboMang.EnterMoveNextControl = true;
            this.cboMang.Location = new System.Drawing.Point(350, 64);
            this.cboMang.Name = "cboMang";
            this.cboMang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMang.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên")});
            this.cboMang.Properties.DropDownRows = 10;
            this.cboMang.Properties.NullText = "-- Tất cả --";
            this.cboMang.Properties.PopupFormMinSize = new System.Drawing.Size(163, 0);
            this.cboMang.Properties.PopupWidth = 163;
            this.cboMang.Properties.ShowFooter = false;
            this.cboMang.Properties.ShowHeader = false;
            this.cboMang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboMang.Size = new System.Drawing.Size(200, 20);
            this.cboMang.TabIndex = 6;
            // 
            // cboTuNgay
            // 
            this.cboTuNgay.EditValue = null;
            this.cboTuNgay.EnterMoveNextControl = true;
            this.cboTuNgay.Location = new System.Drawing.Point(70, 38);
            this.cboTuNgay.Name = "cboTuNgay";
            this.cboTuNgay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cboTuNgay.Properties.NullText = " -- Ngày xem --";
            this.cboTuNgay.Properties.ShowToday = false;
            this.cboTuNgay.Size = new System.Drawing.Size(97, 20);
            this.cboTuNgay.TabIndex = 1;
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
            // frmMessageAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.ToolbarLd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMessageAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo tin nhắn";
            this.Load += new System.EventHandler(this.frmMessageAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaCuoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTinMau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.MainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboHangSanXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuNgay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BrgWorker;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit txtGiaCuoi;
        private DevExpress.XtraEditors.SpinEdit txtGiaDau;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cboTinMau;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.DateEdit cboDenNgay;
        private DevExpress.XtraEditors.DateEdit cboTuNgay;
        private SMSSC.CONTROL.ToolbarLd ToolbarLd;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit cboHangSanXuat;
        private DevExpress.XtraEditors.LookUpEdit cboMang;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn FromPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ToPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ContentText;
        private DevExpress.XtraGrid.Columns.GridColumn Note;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private CONTROL.ToolbarNhap ToolbarNhap;
    }
}
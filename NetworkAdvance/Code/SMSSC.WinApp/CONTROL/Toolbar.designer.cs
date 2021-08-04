namespace SMSSC.CONTROL
{
    partial class Toolbar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toolbar));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.BarMain = new DevExpress.XtraBars.BarManager(this.components);
            this.MainToolBar = new DevExpress.XtraBars.Bar();
            this.cmdThem = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdSua = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdXoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdAn = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdNapLai = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdXuatExcel = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdInAn = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdTroGiup = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdDong = new DevExpress.XtraBars.BarLargeButtonItem();
            this.lblTrangThai = new DevExpress.XtraBars.BarEditItem();
            this.cboTrangThai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrangThai)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "add.png");
            this.imageCollection1.Images.SetKeyName(1, "edit.ico");
            this.imageCollection1.Images.SetKeyName(2, "delete.ico");
            this.imageCollection1.Images.SetKeyName(3, "disconnect.png");
            this.imageCollection1.Images.SetKeyName(4, "arrow_refresh.png");
            this.imageCollection1.Images.SetKeyName(5, "page_excel.png");
            this.imageCollection1.Images.SetKeyName(6, "printer.png");
            this.imageCollection1.Images.SetKeyName(7, "information.png");
            this.imageCollection1.Images.SetKeyName(8, "close.png");
            // 
            // BarMain
            // 
            this.BarMain.AllowCustomization = false;
            this.BarMain.AllowHtmlText = true;
            this.BarMain.AllowMoveBarOnToolbar = false;
            this.BarMain.AllowQuickCustomization = false;
            this.BarMain.AllowShowToolbarsPopup = false;
            this.BarMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.MainToolBar});
            this.BarMain.DockControls.Add(this.barDockControlBottom);
            this.BarMain.DockControls.Add(this.barDockControlLeft);
            this.BarMain.DockControls.Add(this.barDockControlRight);
            this.BarMain.DockControls.Add(this.barDockControl1);
            this.BarMain.Form = this;
            this.BarMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.cmdThem,
            this.cmdSua,
            this.cmdXoa,
            this.cmdXuatExcel,
            this.cmdInAn,
            this.cmdNapLai,
            this.cmdTroGiup,
            this.cmdDong,
            this.cmdAn,
            this.lblTrangThai});
            this.BarMain.LargeImages = this.imageCollection1;
            this.BarMain.MainMenu = this.MainToolBar;
            this.BarMain.MaxItemId = 18;
            this.BarMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboTrangThai});
            this.BarMain.ShowScreenTipsInToolbars = false;
            this.BarMain.ShowShortcutInScreenTips = false;
            this.BarMain.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarMain_ItemClick);
            // 
            // MainToolBar
            // 
            this.MainToolBar.BarItemHorzIndent = 5;
            this.MainToolBar.BarItemVertIndent = 4;
            this.MainToolBar.BarName = "MainToolBar";
            this.MainToolBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.MainToolBar.DockCol = 0;
            this.MainToolBar.DockRow = 0;
            this.MainToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MainToolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdAn),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdNapLai, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdXuatExcel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdInAn),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdTroGiup, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdDong, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.lblTrangThai)});
            this.MainToolBar.OptionsBar.AllowQuickCustomization = false;
            this.MainToolBar.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.MainToolBar.OptionsBar.DisableClose = true;
            this.MainToolBar.OptionsBar.DisableCustomization = true;
            this.MainToolBar.OptionsBar.DrawDragBorder = false;
            this.MainToolBar.OptionsBar.MultiLine = true;
            this.MainToolBar.OptionsBar.UseWholeRow = true;
            this.MainToolBar.Text = "MainToolBar";
            // 
            // cmdThem
            // 
            this.cmdThem.Caption = "Thêm";
            this.cmdThem.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdThem.Hint = "Mở cửa sổ thêm mới (Ctrl+N)";
            this.cmdThem.Id = 0;
            this.cmdThem.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.cmdThem.LargeImageIndex = 0;
            this.cmdThem.Name = "cmdThem";
            // 
            // cmdSua
            // 
            this.cmdSua.Caption = "Sửa";
            this.cmdSua.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdSua.Hint = "Mở cửa sổ thay đổi thông tin (F2)";
            this.cmdSua.Id = 1;
            this.cmdSua.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.cmdSua.LargeImageIndex = 1;
            this.cmdSua.Name = "cmdSua";
            // 
            // cmdXoa
            // 
            this.cmdXoa.Caption = "Xóa";
            this.cmdXoa.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdXoa.Hint = "Xóa thông tin đang chọn (Delete)";
            this.cmdXoa.Id = 2;
            this.cmdXoa.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.cmdXoa.LargeImageIndex = 2;
            this.cmdXoa.Name = "cmdXoa";
            // 
            // cmdAn
            // 
            this.cmdAn.Caption = "Ẩn";
            this.cmdAn.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdAn.Hint = "Ẩn thông tin đang chọn (F3)";
            this.cmdAn.Id = 16;
            this.cmdAn.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.cmdAn.LargeImageIndex = 3;
            this.cmdAn.Name = "cmdAn";
            // 
            // cmdNapLai
            // 
            this.cmdNapLai.Caption = "Nạp lại";
            this.cmdNapLai.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdNapLai.Hint = "Làm mới lại dữ liệu (F5)";
            this.cmdNapLai.Id = 9;
            this.cmdNapLai.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.cmdNapLai.LargeImageIndex = 4;
            this.cmdNapLai.Name = "cmdNapLai";
            // 
            // cmdXuatExcel
            // 
            this.cmdXuatExcel.Caption = "Xuất Excel";
            this.cmdXuatExcel.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdXuatExcel.Hint = "Xuất nội dung ra file Excel (Ctrl+E)";
            this.cmdXuatExcel.Id = 6;
            this.cmdXuatExcel.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.cmdXuatExcel.LargeImageIndex = 5;
            this.cmdXuatExcel.Name = "cmdXuatExcel";
            // 
            // cmdInAn
            // 
            this.cmdInAn.Caption = "In ấn";
            this.cmdInAn.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdInAn.Hint = "In nội dung ra máy in (Ctrl+P)";
            this.cmdInAn.Id = 7;
            this.cmdInAn.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.cmdInAn.LargeImageIndex = 6;
            this.cmdInAn.Name = "cmdInAn";
            // 
            // cmdTroGiup
            // 
            this.cmdTroGiup.Caption = "Trợ giúp";
            this.cmdTroGiup.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdTroGiup.Hint = "F1";
            this.cmdTroGiup.Id = 10;
            this.cmdTroGiup.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.cmdTroGiup.LargeImageIndex = 7;
            this.cmdTroGiup.Name = "cmdTroGiup";
            // 
            // cmdDong
            // 
            this.cmdDong.Caption = "Đóng";
            this.cmdDong.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdDong.Hint = "Alt+F4";
            this.cmdDong.Id = 11;
            this.cmdDong.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.cmdDong.LargeImageIndex = 8;
            this.cmdDong.Name = "cmdDong";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblTrangThai.Caption = "Trạng thái";
            this.lblTrangThai.Edit = this.cboTrangThai;
            this.lblTrangThai.EditValue = 0;
            this.lblTrangThai.Id = 17;
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.lblTrangThai.Width = 70;
            this.lblTrangThai.EditValueChanged += new System.EventHandler(this.lblTrangThai_EditValueChanged);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.AutoHeight = false;
            this.cboTrangThai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTrangThai.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên")});
            this.cboTrangThai.DisplayMember = "Ten";
            this.cboTrangThai.DropDownRows = 2;
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.NullText = "";
            this.cboTrangThai.PopupFormMinSize = new System.Drawing.Size(53, 0);
            this.cboTrangThai.PopupWidth = 53;
            this.cboTrangThai.ShowFooter = false;
            this.cboTrangThai.ShowHeader = false;
            this.cboTrangThai.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboTrangThai.ValueMember = "Id";
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 0);
            this.barDockControlBottom.Size = new System.Drawing.Size(914, 30);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Size = new System.Drawing.Size(914, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlRight.Location = new System.Drawing.Point(0, 30);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(914, 30);
            this.barDockControl1.Size = new System.Drawing.Size(0, 0);
            // 
            // Toolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlBottom);
            this.Name = "Toolbar";
            this.Size = new System.Drawing.Size(914, 28);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrangThai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.BarManager BarMain;
        private DevExpress.XtraBars.Bar MainToolBar;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem cmdThem;
        private DevExpress.XtraBars.BarLargeButtonItem cmdSua;
        private DevExpress.XtraBars.BarLargeButtonItem cmdXoa;
        private DevExpress.XtraBars.BarLargeButtonItem cmdXuatExcel;
        private DevExpress.XtraBars.BarLargeButtonItem cmdInAn;
        private DevExpress.XtraBars.BarLargeButtonItem cmdNapLai;
        private DevExpress.XtraBars.BarLargeButtonItem cmdTroGiup;
        private DevExpress.XtraBars.BarLargeButtonItem cmdDong;
        private DevExpress.XtraBars.BarLargeButtonItem cmdAn;
        private DevExpress.XtraBars.BarEditItem lblTrangThai;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTrangThai;
    }
}

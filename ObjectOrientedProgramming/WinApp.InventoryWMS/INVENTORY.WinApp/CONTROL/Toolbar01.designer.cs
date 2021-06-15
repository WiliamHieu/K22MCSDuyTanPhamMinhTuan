namespace INVENTORY.CONTROL
{
    partial class Toolbar01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toolbar01));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.BarMain = new DevExpress.XtraBars.BarManager(this.components);
            this.MainToolBar = new DevExpress.XtraBars.Bar();
            this.cmdThem = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdSua = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdXoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdXacNhan = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barTuNgay = new DevExpress.XtraBars.BarEditItem();
            this.cboTuNgay = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barDenNgay = new DevExpress.XtraBars.BarEditItem();
            this.cboDenNgay = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.cmdNapLai = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdXuatExcel = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdInAn = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdTroGiup = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdDong = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuNgay.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenNgay.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "add.png");
            this.imageCollection1.Images.SetKeyName(1, "edit.ico");
            this.imageCollection1.Images.SetKeyName(2, "delete.ico");
            this.imageCollection1.Images.SetKeyName(3, "tick.png");
            this.imageCollection1.Images.SetKeyName(4, "arrow_refresh.png");
            this.imageCollection1.Images.SetKeyName(5, "page_excel.png");
            this.imageCollection1.Images.SetKeyName(6, "printer.png");
            this.imageCollection1.Images.SetKeyName(7, "information.png");
            this.imageCollection1.Images.SetKeyName(8, "close.png");
            // 
            // BarMain
            // 
            this.BarMain.AllowCustomization = false;
            this.BarMain.AllowItemAnimatedHighlighting = false;
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
            this.cmdTroGiup,
            this.cmdDong,
            this.barTuNgay,
            this.barDenNgay,
            this.cmdNapLai,
            this.cmdXacNhan});
            this.BarMain.LargeImages = this.imageCollection1;
            this.BarMain.MainMenu = this.MainToolBar;
            this.BarMain.MaxItemId = 27;
            this.BarMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboTuNgay,
            this.cboDenNgay});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdXacNhan, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barTuNgay, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.barDenNgay),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdNapLai, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdXuatExcel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdInAn),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdTroGiup, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdDong, true)});
            this.MainToolBar.OptionsBar.AllowQuickCustomization = false;
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
            // cmdXacNhan
            // 
            this.cmdXacNhan.Caption = "Xác nhận";
            this.cmdXacNhan.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdXacNhan.Description = "F4";
            this.cmdXacNhan.Hint = "Xác nhận thông tin đang chọn (F4)";
            this.cmdXacNhan.Id = 22;
            this.cmdXacNhan.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4);
            this.cmdXacNhan.LargeImageIndex = 3;
            this.cmdXacNhan.Name = "cmdXacNhan";
            this.cmdXacNhan.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barTuNgay
            // 
            this.barTuNgay.Edit = this.cboTuNgay;
            this.barTuNgay.Id = 16;
            this.barTuNgay.Name = "barTuNgay";
            this.barTuNgay.Width = 82;
            // 
            // cboTuNgay
            // 
            this.cboTuNgay.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboTuNgay.AutoHeight = false;
            this.cboTuNgay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTuNgay.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cboTuNgay.Name = "cboTuNgay";
            this.cboTuNgay.ShowToday = false;
            // 
            // barDenNgay
            // 
            this.barDenNgay.Edit = this.cboDenNgay;
            this.barDenNgay.Id = 17;
            this.barDenNgay.Name = "barDenNgay";
            this.barDenNgay.Width = 82;
            // 
            // cboDenNgay
            // 
            this.cboDenNgay.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboDenNgay.AutoHeight = false;
            this.cboDenNgay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDenNgay.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cboDenNgay.Name = "cboDenNgay";
            this.cboDenNgay.ShowToday = false;
            // 
            // cmdNapLai
            // 
            this.cmdNapLai.Caption = "Nạp lại";
            this.cmdNapLai.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdNapLai.Description = "F5";
            this.cmdNapLai.Hint = "Làm mới lại dữ liệu (F5)";
            this.cmdNapLai.Id = 18;
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
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 0);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1282, 30);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(1282, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlRight.Location = new System.Drawing.Point(0, 30);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 4);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1282, 30);
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControl1.Size = new System.Drawing.Size(0, 4);
            // 
            // Toolbar01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlBottom);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Toolbar01";
            this.Size = new System.Drawing.Size(1282, 34);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuNgay.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenNgay.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenNgay)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem cmdNapLai;
        private DevExpress.XtraBars.BarLargeButtonItem cmdXacNhan;
        private DevExpress.XtraBars.BarLargeButtonItem cmdXuatExcel;
        private DevExpress.XtraBars.BarLargeButtonItem cmdInAn;
        private DevExpress.XtraBars.BarLargeButtonItem cmdTroGiup;
        private DevExpress.XtraBars.BarLargeButtonItem cmdDong;
        private DevExpress.XtraBars.BarEditItem barTuNgay;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit cboTuNgay;
        private DevExpress.XtraBars.BarEditItem barDenNgay;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit cboDenNgay;
    }
}

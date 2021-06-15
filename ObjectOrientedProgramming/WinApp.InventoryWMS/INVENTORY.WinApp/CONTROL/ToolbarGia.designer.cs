namespace INVENTORY.CONTROL
{
    partial class ToolbarGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolbarGia));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.BarMain = new DevExpress.XtraBars.BarManager(this.components);
            this.MainToolBar = new DevExpress.XtraBars.Bar();
            this.cmdSua = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdXoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdLuu = new DevExpress.XtraBars.BarLargeButtonItem();
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
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "edit.ico");
            this.imageCollection1.Images.SetKeyName(1, "delete.ico");
            this.imageCollection1.Images.SetKeyName(2, "disk.png");
            this.imageCollection1.Images.SetKeyName(3, "arrow_refresh.png");
            this.imageCollection1.Images.SetKeyName(4, "page_excel.png");
            this.imageCollection1.Images.SetKeyName(5, "printer.png");
            this.imageCollection1.Images.SetKeyName(6, "information.png");
            this.imageCollection1.Images.SetKeyName(7, "close.png");
            // 
            // BarMain
            // 
            this.BarMain.AllowCustomization = false;
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
            this.cmdLuu,
            this.cmdSua,
            this.cmdXoa,
            this.cmdXuatExcel,
            this.cmdInAn,
            this.cmdNapLai,
            this.cmdTroGiup,
            this.cmdDong});
            this.BarMain.LargeImages = this.imageCollection1;
            this.BarMain.MainMenu = this.MainToolBar;
            this.BarMain.MaxItemId = 15;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdNapLai, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdXuatExcel),
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
            // cmdSua
            // 
            this.cmdSua.Caption = "Sửa";
            this.cmdSua.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdSua.Hint = "Sửa đổi thông tin";
            this.cmdSua.Id = 1;
            this.cmdSua.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.cmdSua.LargeImageIndex = 0;
            this.cmdSua.Name = "cmdSua";
            // 
            // cmdXoa
            // 
            this.cmdXoa.Caption = "Xóa";
            this.cmdXoa.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdXoa.Hint = "Xóa thông tin";
            this.cmdXoa.Id = 2;
            this.cmdXoa.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.cmdXoa.LargeImageIndex = 1;
            this.cmdXoa.Name = "cmdXoa";
            // 
            // cmdLuu
            // 
            this.cmdLuu.Caption = "Lưu";
            this.cmdLuu.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdLuu.Description = "Ctrl+S";
            this.cmdLuu.Hint = "Lưu thay đổi thông tin";
            this.cmdLuu.Id = 0;
            this.cmdLuu.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.cmdLuu.LargeImageIndex = 2;
            this.cmdLuu.Name = "cmdLuu";
            // 
            // cmdNapLai
            // 
            this.cmdNapLai.Caption = "Nạp lại";
            this.cmdNapLai.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdNapLai.Hint = "Làm mới dữ liệu";
            this.cmdNapLai.Id = 9;
            this.cmdNapLai.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.cmdNapLai.LargeImageIndex = 3;
            this.cmdNapLai.Name = "cmdNapLai";
            // 
            // cmdXuatExcel
            // 
            this.cmdXuatExcel.Caption = "Xuất Excel";
            this.cmdXuatExcel.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdXuatExcel.Hint = "Xuất nội dung ra Excel";
            this.cmdXuatExcel.Id = 6;
            this.cmdXuatExcel.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.cmdXuatExcel.LargeImageIndex = 4;
            this.cmdXuatExcel.Name = "cmdXuatExcel";
            // 
            // cmdInAn
            // 
            this.cmdInAn.Caption = "In ấn";
            this.cmdInAn.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdInAn.Hint = "In nội dung ra máy in";
            this.cmdInAn.Id = 7;
            this.cmdInAn.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.cmdInAn.LargeImageIndex = 5;
            this.cmdInAn.Name = "cmdInAn";
            // 
            // cmdTroGiup
            // 
            this.cmdTroGiup.Caption = "Trợ giúp";
            this.cmdTroGiup.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdTroGiup.Hint = "Hướng dẫn sử dụng";
            this.cmdTroGiup.Id = 10;
            this.cmdTroGiup.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.cmdTroGiup.LargeImageIndex = 6;
            this.cmdTroGiup.Name = "cmdTroGiup";
            // 
            // cmdDong
            // 
            this.cmdDong.Caption = "Đóng";
            this.cmdDong.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdDong.Hint = "Đóng cửa sổ";
            this.cmdDong.Id = 11;
            this.cmdDong.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.cmdDong.LargeImageIndex = 7;
            this.cmdDong.Name = "cmdDong";
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 0);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(990, 34);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(990, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlRight.Location = new System.Drawing.Point(0, 34);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(990, 34);
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControl1.Size = new System.Drawing.Size(0, 0);
            // 
            // ToolbarGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlBottom);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ToolbarGia";
            this.Size = new System.Drawing.Size(990, 34);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarMain)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem cmdLuu;
        private DevExpress.XtraBars.BarLargeButtonItem cmdSua;
        private DevExpress.XtraBars.BarLargeButtonItem cmdXoa;
        private DevExpress.XtraBars.BarLargeButtonItem cmdXuatExcel;
        private DevExpress.XtraBars.BarLargeButtonItem cmdInAn;
        private DevExpress.XtraBars.BarLargeButtonItem cmdNapLai;
        private DevExpress.XtraBars.BarLargeButtonItem cmdTroGiup;
        private DevExpress.XtraBars.BarLargeButtonItem cmdDong;
    }
}

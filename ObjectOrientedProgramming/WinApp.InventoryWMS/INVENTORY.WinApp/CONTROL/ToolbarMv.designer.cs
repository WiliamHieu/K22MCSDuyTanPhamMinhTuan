namespace INVENTORY.CONTROL
{
    partial class ToolbarMv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolbarMv));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.bmMain = new DevExpress.XtraBars.BarManager(this.components);
            this.MaiToolbar = new DevExpress.XtraBars.Bar();
            this.cmdLuu = new DevExpress.XtraBars.BarButtonItem();
            this.cmdLuuVaDong = new DevExpress.XtraBars.BarButtonItem();
            this.cmdLuuVaThem = new DevExpress.XtraBars.BarButtonItem();
            this.cmdLuuVaIn = new DevExpress.XtraBars.BarButtonItem();
            this.cmdLuuVaChuyen = new DevExpress.XtraBars.BarButtonItem();
            this.cmdInAn = new DevExpress.XtraBars.BarButtonItem();
            this.cmdDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cmdXuatExcel = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMain)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "disk.png");
            this.imageCollection1.Images.SetKeyName(1, "drive_disk.png");
            this.imageCollection1.Images.SetKeyName(2, "page_save.png");
            this.imageCollection1.Images.SetKeyName(3, "report_disk.png");
            this.imageCollection1.Images.SetKeyName(4, "disk_multiple.png");
            this.imageCollection1.Images.SetKeyName(5, "printer.png");
            this.imageCollection1.Images.SetKeyName(6, "page_excel.png");
            this.imageCollection1.Images.SetKeyName(7, "close.png");
            // 
            // bmMain
            // 
            this.bmMain.AllowMoveBarOnToolbar = false;
            this.bmMain.AllowQuickCustomization = false;
            this.bmMain.AllowShowToolbarsPopup = false;
            this.bmMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.MaiToolbar});
            this.bmMain.DockControls.Add(this.barDockControlTop);
            this.bmMain.DockControls.Add(this.barDockControlBottom);
            this.bmMain.DockControls.Add(this.barDockControlLeft);
            this.bmMain.DockControls.Add(this.barDockControlRight);
            this.bmMain.Form = this;
            this.bmMain.Images = this.imageCollection1;
            this.bmMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.cmdLuu,
            this.cmdLuuVaThem,
            this.cmdLuuVaIn,
            this.cmdLuuVaChuyen,
            this.cmdDong,
            this.cmdLuuVaDong,
            this.cmdInAn,
            this.cmdXuatExcel});
            this.bmMain.MaxItemId = 20;
            this.bmMain.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bmMain_ItemClick);
            this.bmMain.HighlightedLinkChanged += new DevExpress.XtraBars.HighlightedLinkChangedEventHandler(this.bmMain_HighlightedLinkChanged);
            // 
            // MaiToolbar
            // 
            this.MaiToolbar.BarItemHorzIndent = 5;
            this.MaiToolbar.BarItemVertIndent = 3;
            this.MaiToolbar.BarName = "MaiToolbar";
            this.MaiToolbar.DockCol = 0;
            this.MaiToolbar.DockRow = 0;
            this.MaiToolbar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MaiToolbar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdLuuVaDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdLuuVaThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdLuuVaIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdLuuVaChuyen, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdInAn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdXuatExcel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.MaiToolbar.OptionsBar.AllowQuickCustomization = false;
            this.MaiToolbar.OptionsBar.AllowRename = true;
            this.MaiToolbar.OptionsBar.DisableClose = true;
            this.MaiToolbar.OptionsBar.DisableCustomization = true;
            this.MaiToolbar.OptionsBar.DrawDragBorder = false;
            this.MaiToolbar.OptionsBar.UseWholeRow = true;
            this.MaiToolbar.Text = "MaiToolbar";
            // 
            // cmdLuu
            // 
            this.cmdLuu.Caption = "Lưu ";
            this.cmdLuu.Hint = "Lưu và giữ nguyên cửa sổ";
            this.cmdLuu.Id = 2;
            this.cmdLuu.ImageIndex = 0;
            this.cmdLuu.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.cmdLuu.LargeImageIndex = 0;
            this.cmdLuu.Name = "cmdLuu";
            // 
            // cmdLuuVaDong
            // 
            this.cmdLuuVaDong.Caption = "Lưu và Đóng";
            this.cmdLuuVaDong.Hint = "Lưu và đóng cửa sổ";
            this.cmdLuuVaDong.Id = 8;
            this.cmdLuuVaDong.ImageIndex = 1;
            this.cmdLuuVaDong.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G));
            this.cmdLuuVaDong.LargeImageIndex = 6;
            this.cmdLuuVaDong.Name = "cmdLuuVaDong";
            // 
            // cmdLuuVaThem
            // 
            this.cmdLuuVaThem.Caption = "Lưu và Thêm";
            this.cmdLuuVaThem.Hint = "Lưu và mở cửa sổ thêm mới";
            this.cmdLuuVaThem.Id = 3;
            this.cmdLuuVaThem.ImageIndex = 2;
            this.cmdLuuVaThem.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.cmdLuuVaThem.LargeImageIndex = 1;
            this.cmdLuuVaThem.Name = "cmdLuuVaThem";
            // 
            // cmdLuuVaIn
            // 
            this.cmdLuuVaIn.Caption = "Lưu và In";
            this.cmdLuuVaIn.Hint = "Lưu và in nội dung";
            this.cmdLuuVaIn.Id = 4;
            this.cmdLuuVaIn.ImageIndex = 3;
            this.cmdLuuVaIn.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I));
            this.cmdLuuVaIn.LargeImageIndex = 2;
            this.cmdLuuVaIn.Name = "cmdLuuVaIn";
            // 
            // cmdLuuVaChuyen
            // 
            this.cmdLuuVaChuyen.Caption = "Lưu và Chuyển";
            this.cmdLuuVaChuyen.Hint = "Lưu và duyệt thông tin";
            this.cmdLuuVaChuyen.Id = 5;
            this.cmdLuuVaChuyen.ImageIndex = 4;
            this.cmdLuuVaChuyen.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T));
            this.cmdLuuVaChuyen.LargeImageIndex = 3;
            this.cmdLuuVaChuyen.Name = "cmdLuuVaChuyen";
            this.cmdLuuVaChuyen.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // cmdInAn
            // 
            this.cmdInAn.Caption = "In ấn";
            this.cmdInAn.Hint = "In nội dung ra máy in";
            this.cmdInAn.Id = 17;
            this.cmdInAn.ImageIndex = 5;
            this.cmdInAn.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.cmdInAn.Name = "cmdInAn";
            // 
            // cmdDong
            // 
            this.cmdDong.Caption = "Đóng ";
            this.cmdDong.Hint = "Đóng cửa sổ";
            this.cmdDong.Id = 7;
            this.cmdDong.ImageIndex = 7;
            this.cmdDong.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.cmdDong.LargeImageIndex = 5;
            this.cmdDong.Name = "cmdDong";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(884, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 28);
            this.barDockControlBottom.Size = new System.Drawing.Size(884, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(884, 28);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 0);
            // 
            // cmdXuatExcel
            // 
            this.cmdXuatExcel.Caption = "Xuất Excel";
            this.cmdXuatExcel.Hint = "Xuất nội dung ra tập tin Excel";
            this.cmdXuatExcel.Id = 19;
            this.cmdXuatExcel.ImageIndex = 6;
            this.cmdXuatExcel.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.cmdXuatExcel.Name = "cmdXuatExcel";
            // 
            // ToolbarMv
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ToolbarMv";
            this.Size = new System.Drawing.Size(884, 28);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.BarManager bmMain;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar MaiToolbar;
        private DevExpress.XtraBars.BarButtonItem cmdLuu;
        private DevExpress.XtraBars.BarButtonItem cmdLuuVaThem;
        private DevExpress.XtraBars.BarButtonItem cmdLuuVaIn;
        private DevExpress.XtraBars.BarButtonItem cmdLuuVaChuyen;
        private DevExpress.XtraBars.BarButtonItem cmdDong;
        private DevExpress.XtraBars.BarButtonItem cmdLuuVaDong;
        private DevExpress.XtraBars.BarButtonItem cmdInAn;
        private DevExpress.XtraBars.BarButtonItem cmdXuatExcel;
    }
}

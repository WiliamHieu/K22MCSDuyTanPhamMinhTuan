namespace INVENTORY.CONTROL
{
    partial class ToolbarBc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolbarBc));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.BarMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.cmdTimKiem = new DevExpress.XtraBars.BarLargeButtonItem();
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
            this.imageCollection1.Images.SetKeyName(0, "find.png");
            this.imageCollection1.Images.SetKeyName(1, "page_excel.png");
            this.imageCollection1.Images.SetKeyName(2, "printer.png");
            this.imageCollection1.Images.SetKeyName(3, "information.png");
            this.imageCollection1.Images.SetKeyName(4, "close.png");
            // 
            // BarMain
            // 
            this.BarMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.BarMain.DockControls.Add(this.barDockControlBottom);
            this.BarMain.DockControls.Add(this.barDockControlLeft);
            this.BarMain.DockControls.Add(this.barDockControlRight);
            this.BarMain.DockControls.Add(this.barDockControl1);
            this.BarMain.Form = this;
            this.BarMain.Images = this.imageCollection1;
            this.BarMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.cmdTimKiem,
            this.cmdXuatExcel,
            this.cmdInAn,
            this.cmdTroGiup,
            this.cmdDong});
            this.BarMain.LargeImages = this.imageCollection1;
            this.BarMain.MainMenu = this.bar2;
            this.BarMain.MaxItemId = 18;
            this.BarMain.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarMain_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarItemHorzIndent = 5;
            this.bar2.BarItemVertIndent = 4;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdTimKiem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdXuatExcel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdInAn),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdTroGiup, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdDong, true)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableClose = true;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // cmdTimKiem
            // 
            this.cmdTimKiem.Caption = "Tìm kiếm";
            this.cmdTimKiem.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdTimKiem.Description = "Ctrl + F";
            this.cmdTimKiem.Hint = "Ctrl + F";
            this.cmdTimKiem.Id = 3;
            this.cmdTimKiem.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.cmdTimKiem.LargeImageIndex = 0;
            this.cmdTimKiem.Name = "cmdTimKiem";
            // 
            // cmdXuatExcel
            // 
            this.cmdXuatExcel.Caption = "Xuất Excel";
            this.cmdXuatExcel.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdXuatExcel.Hint = "Ctrl+E";
            this.cmdXuatExcel.Id = 6;
            this.cmdXuatExcel.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.cmdXuatExcel.LargeImageIndex = 1;
            this.cmdXuatExcel.Name = "cmdXuatExcel";
            // 
            // cmdInAn
            // 
            this.cmdInAn.Caption = "In ấn";
            this.cmdInAn.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdInAn.Hint = "Ctrl+P";
            this.cmdInAn.Id = 7;
            this.cmdInAn.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.cmdInAn.LargeImageIndex = 2;
            this.cmdInAn.Name = "cmdInAn";
            // 
            // cmdTroGiup
            // 
            this.cmdTroGiup.Caption = "Trợ giúp";
            this.cmdTroGiup.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdTroGiup.Hint = "F1";
            this.cmdTroGiup.Id = 10;
            this.cmdTroGiup.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.cmdTroGiup.LargeImageIndex = 3;
            this.cmdTroGiup.Name = "cmdTroGiup";
            // 
            // cmdDong
            // 
            this.cmdDong.Caption = "Đóng";
            this.cmdDong.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.cmdDong.Hint = "Alt+F4";
            this.cmdDong.Id = 11;
            this.cmdDong.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.cmdDong.LargeImageIndex = 4;
            this.cmdDong.Name = "cmdDong";
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 0);
            this.barDockControlBottom.Size = new System.Drawing.Size(849, 30);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Size = new System.Drawing.Size(849, 0);
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
            this.barDockControl1.Location = new System.Drawing.Point(849, 30);
            this.barDockControl1.Size = new System.Drawing.Size(0, 0);
            // 
            // ToolbarBc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlBottom);
            this.Name = "ToolbarBc";
            this.Size = new System.Drawing.Size(849, 28);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.BarManager BarMain;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem cmdTimKiem;
        private DevExpress.XtraBars.BarLargeButtonItem cmdXuatExcel;
        private DevExpress.XtraBars.BarLargeButtonItem cmdInAn;
        private DevExpress.XtraBars.BarLargeButtonItem cmdTroGiup;
        private DevExpress.XtraBars.BarLargeButtonItem cmdDong;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
    }
}

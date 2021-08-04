namespace SMSSC.WinApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.MainTabbedMdi = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.spaceLeft = new DevExpress.XtraBars.BarStaticItem();
            this.spaceRight = new DevExpress.XtraBars.BarStaticItem();
            this.MainBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.MainStatusBar = new DevExpress.XtraBars.Bar();
            this.spNguoiDung = new DevExpress.XtraBars.BarStaticItem();
            this.spSpaceLeft = new DevExpress.XtraBars.BarStaticItem();
            this.spSpaceRight = new DevExpress.XtraBars.BarStaticItem();
            this.spCopyRight = new DevExpress.XtraBars.BarStaticItem();
            this.MainToolBar = new DevExpress.XtraBars.Bar();
            this.cmdThoat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdThietLap = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdTinMau = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdTinNhatKy = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdTaoTin = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmdImportTin = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ImageCollection24 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainTabbedMdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection24)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabbedMdi
            // 
            this.MainTabbedMdi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.MainTabbedMdi.MdiParent = this;
            // 
            // spaceLeft
            // 
            this.spaceLeft.Id = -1;
            this.spaceLeft.Name = "spaceLeft";
            this.spaceLeft.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // spaceRight
            // 
            this.spaceRight.Id = -1;
            this.spaceRight.Name = "spaceRight";
            this.spaceRight.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // MainBarManager
            // 
            this.MainBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.MainStatusBar,
            this.MainToolBar});
            this.MainBarManager.DockControls.Add(this.barDockControlTop);
            this.MainBarManager.DockControls.Add(this.barDockControlBottom);
            this.MainBarManager.DockControls.Add(this.barDockControlLeft);
            this.MainBarManager.DockControls.Add(this.barDockControlRight);
            this.MainBarManager.Form = this;
            this.MainBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.spSpaceLeft,
            this.spSpaceRight,
            this.spNguoiDung,
            this.spCopyRight,
            this.cmdThoat,
            this.cmdThietLap,
            this.cmdTinMau,
            this.cmdTaoTin,
            this.cmdImportTin,
            this.cmdTinNhatKy});
            this.MainBarManager.LargeImages = this.ImageCollection24;
            this.MainBarManager.MaxItemId = 150;
            this.MainBarManager.StatusBar = this.MainStatusBar;
            this.MainBarManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MainBarManager_ItemClick);
            this.MainBarManager.HighlightedLinkChanged += new DevExpress.XtraBars.HighlightedLinkChangedEventHandler(this.MainBarManager_HighlightedLinkChanged);
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.BarName = "Status bar";
            this.MainStatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.MainStatusBar.DockCol = 0;
            this.MainStatusBar.DockRow = 0;
            this.MainStatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.MainStatusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spNguoiDung),
            new DevExpress.XtraBars.LinkPersistInfo(this.spSpaceLeft),
            new DevExpress.XtraBars.LinkPersistInfo(this.spSpaceRight),
            new DevExpress.XtraBars.LinkPersistInfo(this.spCopyRight)});
            this.MainStatusBar.OptionsBar.AllowQuickCustomization = false;
            this.MainStatusBar.OptionsBar.DrawDragBorder = false;
            this.MainStatusBar.OptionsBar.UseWholeRow = true;
            this.MainStatusBar.Text = "Status bar";
            // 
            // spNguoiDung
            // 
            this.spNguoiDung.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.spNguoiDung.Caption = "Phạm Minh Tuấn - K22MCS";
            this.spNguoiDung.Id = 48;
            this.spNguoiDung.Name = "spNguoiDung";
            this.spNguoiDung.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // spSpaceLeft
            // 
            this.spSpaceLeft.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.spSpaceLeft.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.spSpaceLeft.Id = 5;
            this.spSpaceLeft.Name = "spSpaceLeft";
            this.spSpaceLeft.TextAlignment = System.Drawing.StringAlignment.Near;
            this.spSpaceLeft.Width = 32;
            // 
            // spSpaceRight
            // 
            this.spSpaceRight.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.spSpaceRight.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.spSpaceRight.Id = 7;
            this.spSpaceRight.Name = "spSpaceRight";
            this.spSpaceRight.TextAlignment = System.Drawing.StringAlignment.Near;
            this.spSpaceRight.Width = 32;
            // 
            // spCopyRight
            // 
            this.spCopyRight.Caption = "Copyright © 2021";
            this.spCopyRight.Id = 50;
            this.spCopyRight.Name = "spCopyRight";
            this.spCopyRight.TextAlignment = System.Drawing.StringAlignment.Near;
            this.spCopyRight.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.spCopyRight_ItemClick);
            // 
            // MainToolBar
            // 
            this.MainToolBar.BarAppearance.Normal.BackColor = System.Drawing.Color.White;
            this.MainToolBar.BarAppearance.Normal.Options.UseBackColor = true;
            this.MainToolBar.BarItemHorzIndent = 5;
            this.MainToolBar.BarName = "MainToolBar";
            this.MainToolBar.DockCol = 0;
            this.MainToolBar.DockRow = 0;
            this.MainToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MainToolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdThoat),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdThietLap),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdTinMau, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdTinNhatKy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdTaoTin, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdImportTin)});
            this.MainToolBar.OptionsBar.AllowQuickCustomization = false;
            this.MainToolBar.OptionsBar.DisableClose = true;
            this.MainToolBar.OptionsBar.DrawDragBorder = false;
            this.MainToolBar.OptionsBar.DrawSizeGrip = true;
            this.MainToolBar.OptionsBar.UseWholeRow = true;
            this.MainToolBar.Text = "MainToolBar";
            // 
            // cmdThoat
            // 
            this.cmdThoat.Caption = "Thoát";
            this.cmdThoat.Id = 52;
            this.cmdThoat.LargeImageIndex = 0;
            this.cmdThoat.Name = "cmdThoat";
            // 
            // cmdThietLap
            // 
            this.cmdThietLap.Caption = "Thiết lập";
            this.cmdThietLap.Id = 58;
            this.cmdThietLap.LargeImageIndex = 1;
            this.cmdThietLap.Name = "cmdThietLap";
            // 
            // cmdTinMau
            // 
            this.cmdTinMau.Caption = "Tin mẫu";
            this.cmdTinMau.Id = 120;
            this.cmdTinMau.LargeImageIndex = 2;
            this.cmdTinMau.Name = "cmdTinMau";
            // 
            // cmdTinNhatKy
            // 
            this.cmdTinNhatKy.Caption = "Nhật ký";
            this.cmdTinNhatKy.Id = 149;
            this.cmdTinNhatKy.LargeImageIndex = 3;
            this.cmdTinNhatKy.Name = "cmdTinNhatKy";
            // 
            // cmdTaoTin
            // 
            this.cmdTaoTin.Caption = "Tạo tin";
            this.cmdTaoTin.Id = 122;
            this.cmdTaoTin.LargeImageIndex = 4;
            this.cmdTaoTin.Name = "cmdTaoTin";
            // 
            // cmdImportTin
            // 
            this.cmdImportTin.Caption = "Import tin";
            this.cmdImportTin.Id = 128;
            this.cmdImportTin.LargeImageIndex = 5;
            this.cmdImportTin.Name = "cmdImportTin";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1184, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 632);
            this.barDockControlBottom.Size = new System.Drawing.Size(1184, 29);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 579);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1184, 53);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 579);
            // 
            // ImageCollection24
            // 
            this.ImageCollection24.ImageSize = new System.Drawing.Size(24, 24);
            this.ImageCollection24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImageCollection24.ImageStream")));
            this.ImageCollection24.Images.SetKeyName(0, "Shutdown.png");
            this.ImageCollection24.Images.SetKeyName(1, "applications.ico");
            this.ImageCollection24.Images.SetKeyName(2, "Email.png");
            this.ImageCollection24.Images.SetKeyName(3, "smsbackup.png");
            this.ImageCollection24.Images.SetKeyName(4, "notepad-icon.png");
            this.ImageCollection24.Images.SetKeyName(5, "sms-imort.png");
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS Smart Care";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.MainTabbedMdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection24)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MainTabbedMdi;
        private DevExpress.XtraBars.BarStaticItem spaceLeft;
        private DevExpress.XtraBars.BarStaticItem spaceRight;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager MainBarManager;
        private DevExpress.XtraBars.Bar MainStatusBar;
        private DevExpress.XtraBars.BarStaticItem spSpaceLeft;
        private DevExpress.XtraBars.BarStaticItem spSpaceRight;
        private DevExpress.XtraBars.Bar MainToolBar;
        private DevExpress.XtraBars.BarStaticItem spNguoiDung;
        private DevExpress.XtraBars.BarStaticItem spCopyRight;
        private DevExpress.XtraBars.BarLargeButtonItem cmdThoat;
        private DevExpress.XtraBars.BarLargeButtonItem cmdThietLap;
        private DevExpress.Utils.ImageCollection ImageCollection24;
        private DevExpress.XtraBars.BarLargeButtonItem cmdTinMau;
        private DevExpress.XtraBars.BarLargeButtonItem cmdTaoTin;
        private DevExpress.XtraBars.BarLargeButtonItem cmdImportTin;
        private DevExpress.XtraBars.BarLargeButtonItem cmdTinNhatKy;
    }
}
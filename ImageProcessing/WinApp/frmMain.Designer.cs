namespace ImageProcessing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.MainToolbar = new System.Windows.Forms.ToolStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripButton();
            this.mnuOpen = new System.Windows.Forms.ToolStripButton();
            this.mnuZoomOut = new System.Windows.Forms.ToolStripButton();
            this.mnuZoomIn = new System.Windows.Forms.ToolStripButton();
            this.mnuFilter = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBrightness = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContrast = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGamma = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGrayScale = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusBar = new System.Windows.Forms.StatusStrip();
            this.lblImageInfor = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelImage = new System.Windows.Forms.Panel();
            this.MainToolbar.SuspendLayout();
            this.MainStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolbar
            // 
            this.MainToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuOpen,
            this.mnuZoomOut,
            this.mnuZoomIn,
            this.mnuFilter});
            this.MainToolbar.Location = new System.Drawing.Point(0, 0);
            this.MainToolbar.Name = "MainToolbar";
            this.MainToolbar.Size = new System.Drawing.Size(800, 25);
            this.MainToolbar.TabIndex = 0;
            this.MainToolbar.Text = "toolStrip1";
            this.MainToolbar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainToolbar_ItemClicked);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = ((System.Drawing.Image)(resources.GetObject("mnuExit.Image")));
            this.mnuExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(46, 22);
            this.mnuExit.Text = "Exit";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuOpen.Image")));
            this.mnuOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(56, 22);
            this.mnuOpen.Text = "Open";
            // 
            // mnuZoomOut
            // 
            this.mnuZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("mnuZoomOut.Image")));
            this.mnuZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuZoomOut.Name = "mnuZoomOut";
            this.mnuZoomOut.Size = new System.Drawing.Size(82, 22);
            this.mnuZoomOut.Text = "Zoom Out";
            // 
            // mnuZoomIn
            // 
            this.mnuZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("mnuZoomIn.Image")));
            this.mnuZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuZoomIn.Name = "mnuZoomIn";
            this.mnuZoomIn.Size = new System.Drawing.Size(72, 22);
            this.mnuZoomIn.Text = "Zoom In";
            // 
            // mnuFilter
            // 
            this.mnuFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInvert,
            this.mnuBrightness,
            this.mnuContrast,
            this.mnuGamma,
            this.mnuGrayScale});
            this.mnuFilter.Image = ((System.Drawing.Image)(resources.GetObject("mnuFilter.Image")));
            this.mnuFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFilter.Name = "mnuFilter";
            this.mnuFilter.Size = new System.Drawing.Size(62, 22);
            this.mnuFilter.Text = "Filter";
            // 
            // mnuInvert
            // 
            this.mnuInvert.Name = "mnuInvert";
            this.mnuInvert.Size = new System.Drawing.Size(129, 22);
            this.mnuInvert.Text = "Invert";
            this.mnuInvert.Click += new System.EventHandler(this.Filter_ItemClicked);
            // 
            // mnuBrightness
            // 
            this.mnuBrightness.Name = "mnuBrightness";
            this.mnuBrightness.Size = new System.Drawing.Size(129, 22);
            this.mnuBrightness.Text = "Brightness";
            this.mnuBrightness.Click += new System.EventHandler(this.Filter_ItemClicked);
            // 
            // mnuContrast
            // 
            this.mnuContrast.Name = "mnuContrast";
            this.mnuContrast.Size = new System.Drawing.Size(129, 22);
            this.mnuContrast.Text = "Contrast";
            this.mnuContrast.Click += new System.EventHandler(this.Filter_ItemClicked);
            // 
            // mnuGamma
            // 
            this.mnuGamma.Name = "mnuGamma";
            this.mnuGamma.Size = new System.Drawing.Size(129, 22);
            this.mnuGamma.Text = "Gamma";
            this.mnuGamma.Click += new System.EventHandler(this.Filter_ItemClicked);
            // 
            // mnuGrayScale
            // 
            this.mnuGrayScale.Name = "mnuGrayScale";
            this.mnuGrayScale.Size = new System.Drawing.Size(129, 22);
            this.mnuGrayScale.Text = "GrayScale";
            this.mnuGrayScale.Click += new System.EventHandler(this.Filter_ItemClicked);
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblImageInfor});
            this.MainStatusBar.Location = new System.Drawing.Point(0, 547);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Size = new System.Drawing.Size(800, 22);
            this.MainStatusBar.TabIndex = 1;
            this.MainStatusBar.Text = "statusStrip1";
            // 
            // lblImageInfor
            // 
            this.lblImageInfor.Name = "lblImageInfor";
            this.lblImageInfor.Size = new System.Drawing.Size(0, 17);
            // 
            // panelImage
            // 
            this.panelImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelImage.BackgroundImage")));
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImage.Location = new System.Drawing.Point(0, 25);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(800, 522);
            this.panelImage.TabIndex = 2;
            this.panelImage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelImage_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.MainStatusBar);
            this.Controls.Add(this.MainToolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Image Processing";
            this.MainToolbar.ResumeLayout(false);
            this.MainToolbar.PerformLayout();
            this.MainStatusBar.ResumeLayout(false);
            this.MainStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolbar;
        private System.Windows.Forms.StatusStrip MainStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblImageInfor;
        private System.Windows.Forms.ToolStripButton mnuExit;
        private System.Windows.Forms.ToolStripButton mnuOpen;
        private System.Windows.Forms.ToolStripButton mnuZoomOut;
        private System.Windows.Forms.ToolStripButton mnuZoomIn;
        private System.Windows.Forms.ToolStripDropDownButton mnuFilter;
        private System.Windows.Forms.ToolStripMenuItem mnuInvert;
        private System.Windows.Forms.ToolStripMenuItem mnuBrightness;
        private System.Windows.Forms.ToolStripMenuItem mnuContrast;
        private System.Windows.Forms.ToolStripMenuItem mnuGamma;
        private System.Windows.Forms.ToolStripMenuItem mnuGrayScale;
        private System.Windows.Forms.Panel panelImage;
    }
}


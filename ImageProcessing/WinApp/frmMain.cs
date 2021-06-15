using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class frmMain : Form
    {
        private Bitmap mainBitmap;
        private Bitmap sourceBitmap;

        private double zoomSize = 1.0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void MainToolbar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "mnuExit":
                    Application.Exit();
                    break;
                case "mnuOpen":
                    ImageOpen();
                    break;
                case "mnuZoomOut":
                    zoomSize += 0.1;
                    ImageZoom(zoomSize);
                    break;
                case "mnuZoomIn":
                    zoomSize -= 0.1;
                    ImageZoom(zoomSize);
                    break;
            }
        }

        private void Filter_ItemClicked(object sender, EventArgs e)
        {
            if (mainBitmap == null) return;
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            switch (item.Name)
            {
                case "mnuInvert":
                    frmInvert frmInvert = new frmInvert(sourceBitmap);
                    frmInvert.ShowDialog();
                    break;
                case "mnuGrayScale":
                    frmGrayScale frmGrayScale = new frmGrayScale(sourceBitmap);
                    frmGrayScale.ShowDialog();
                    break;
                case "mnuContrast":
                    frmContrast frmContrast = new frmContrast(sourceBitmap);
                    frmContrast.ShowDialog();
                    break;
                case "mnuBrightness":
                    frmBrightness frmBrightness = new frmBrightness(sourceBitmap);
                    frmBrightness.ShowDialog();
                    break;
                case "mnuGamma":
                    frmGamma frmGamma = new frmGamma(sourceBitmap);
                    frmGamma.ShowDialog();
                    break;
            }
        }

        private void panelImage_Paint(object sender, PaintEventArgs e)
        {
            if (mainBitmap == null) return;
            Graphics g = e.Graphics;
            g.DrawImage(mainBitmap, new Rectangle(panelImage.AutoScrollPosition.X, panelImage.AutoScrollPosition.Y, (int)(mainBitmap.Width * zoomSize), (int)(mainBitmap.Height * zoomSize)));
        }

        private void ImageOpen()
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                mainBitmap = Bitmap.FromFile(openFileDialog.FileName, false) as Bitmap;
                sourceBitmap = mainBitmap;

                panelImage.AutoScroll = true;
                panelImage.AutoScrollMinSize = new Size((int)(mainBitmap.Width * zoomSize), (int)(mainBitmap.Height * zoomSize));
                panelImage.Invalidate();

                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

                lblImageInfor.Text = string.Format("File name: {0} - Dimension: {1}x{2} - Size: {3}", fileInfo.Name, sourceBitmap.Width, sourceBitmap.Height, (fileInfo.Length / 1024.0).ToString("0.0") + " KB");
            }
        }

        private void ImageZoom(double zoomSize)
        {
            if (mainBitmap == null) return;

            int newWidth = Convert.ToInt32(mainBitmap.Width * zoomSize);
            int newHeight = Convert.ToInt32(mainBitmap.Height * zoomSize);

            panelImage.AutoScrollMinSize = new Size(newWidth, newHeight);
            panelImage.Invalidate();

            mnuZoomOut.Enabled = !(newWidth >= sourceBitmap.Width * 5);
            mnuZoomIn.Enabled = !(newWidth <= 0);
        }
    }
}

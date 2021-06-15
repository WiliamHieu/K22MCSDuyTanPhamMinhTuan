using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class frmBrightness : Form
    {
        private Bitmap originalBitmap = null;

        public frmBrightness(Bitmap bitmapMain)
        {
            InitializeComponent();

            originalBitmap = bitmapMain;
        }

        private void frmBrightness_Load(object sender, EventArgs e)
        {
            picOriginal.Image = originalBitmap;
            picProcessed.Image = FiltersGDI.Brightness(originalBitmap, 0);
        }

        private void trackBrightness_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBrightness, trackBrightness.Value.ToString());
            picProcessed.Image = FiltersGDI.Brightness(originalBitmap, Convert.ToInt32(trackBrightness.Value));
            picProcessed.Refresh();
        }
    }
}

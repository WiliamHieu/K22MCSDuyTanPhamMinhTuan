using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class frmGamma : Form
    {
        private Bitmap originalBitmap = null;

        public frmGamma(Bitmap bitmapMain)
        {
            InitializeComponent();

            originalBitmap = bitmapMain;
        }

        private void frmGamma_Load(object sender, EventArgs e)
        {
            picOriginal.Image = originalBitmap;
            picProcessed.Image = FiltersGDI.Gamma(originalBitmap, 0.2, 0.2, 0.2);
        }

        private void trackGamma_ValueChanged(object sender, EventArgs e)
        {
            MyTrackBar track = sender as MyTrackBar;

            toolTip1.SetToolTip(track, track.Value.ToString("N1"));
            picProcessed.Image = FiltersGDI.Gamma(originalBitmap, Convert.ToDouble(trackRed.Value), Convert.ToDouble(trackGreen.Value), Convert.ToDouble(trackBlue.Value));
            picProcessed.Refresh();
        }
    }
}

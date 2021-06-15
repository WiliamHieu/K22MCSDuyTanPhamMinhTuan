using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class frmContrast : Form
    {
        private Bitmap originalBitmap = null;

        public frmContrast(Bitmap bitmapMain)
        {
            InitializeComponent();

            originalBitmap = bitmapMain;
        }

        private void frmContrast_Load(object sender, EventArgs e)
        {
            picOriginal.Image = originalBitmap;
            picProcessed.Image = FiltersGDI.Contrast(originalBitmap, 0);
        }

        private void trackContrast_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackContrast, trackContrast.Value.ToString());
            picProcessed.Image = FiltersGDI.Contrast(originalBitmap, Convert.ToInt32(trackContrast.Value));
            picProcessed.Refresh();
        }
    }
}

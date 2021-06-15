using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class frmGrayScale : Form
    {
        private Bitmap originalBitmap = null;

        public frmGrayScale(Bitmap bitmapMain)
        {
            InitializeComponent();

            originalBitmap = bitmapMain;
        }

        private void frmGrayScale_Load(object sender, EventArgs e)
        {
            picOriginal.Image = originalBitmap;
            picProcessed.Image = FiltersGDI.GrayScale(originalBitmap);
        }
    }
}

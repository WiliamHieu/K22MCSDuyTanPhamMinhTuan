using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class frmInvert : Form
    {
        private Bitmap originalBitmap = null;

        public frmInvert(Bitmap bitmapMain)
        {
            InitializeComponent();

            originalBitmap = bitmapMain;
        }

        private void frmInvert_Load(object sender, EventArgs e)
        {
            picOriginal.Image = originalBitmap;
            picProcessed.Image = FiltersGDI.Invert(originalBitmap);
        }
    }
}

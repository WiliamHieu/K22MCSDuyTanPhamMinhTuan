using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageProcessing
{
    public class FiltersGDI
    {
        public static Bitmap Invert(Bitmap sourceBitmap)
        {
            Bitmap invertBitmap = sourceBitmap.Clone() as Bitmap;

            BitmapData bmData = invertBitmap.LockBits(new Rectangle(0, 0, invertBitmap.Width, invertBitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* p = (byte*)(void*)bmData.Scan0;

                int nOffset = bmData.Stride - invertBitmap.Width * 3;
                int nWidth = invertBitmap.Width * 3;

                for (int y = 0; y < invertBitmap.Height; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        p[0] = (byte)(255 - p[0]);
                        p += 1;
                    }
                    p += nOffset;
                }
            }
            invertBitmap.UnlockBits(bmData);

            return invertBitmap;
        }

        public static Bitmap GrayScale(Bitmap sourceBitmap)
        {
            Bitmap grayscaleBitmap = sourceBitmap.Clone() as Bitmap;

            BitmapData bmData = grayscaleBitmap.LockBits(new Rectangle(0, 0, grayscaleBitmap.Width, grayscaleBitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* p = (byte*)(void*)bmData.Scan0;

                int nOffset = bmData.Stride - grayscaleBitmap.Width * 3;
                int nWidth = grayscaleBitmap.Width * 3;

                byte red, green, blue;

                for (int y = 0; y < grayscaleBitmap.Height; ++y)
                {
                    for (int x = 0; x < grayscaleBitmap.Width; ++x)
                    {
                        blue = p[0];
                        green = p[1];
                        red = p[2];

                        p[0] = p[1] = p[2] = (byte)(.299 * red + .587 * green + .114 * blue);

                        p += 3;
                    }
                    p += nOffset;
                }
            }

            grayscaleBitmap.UnlockBits(bmData);

            return grayscaleBitmap;
        }

        public static Bitmap Brightness(Bitmap sourceBitmap, int brightness)
        {
            Bitmap brightnessBitmap = sourceBitmap.Clone() as Bitmap;
            Color color;
            for (int i = 0; i < brightnessBitmap.Width; i++)
            {
                for (int j = 0; j < brightnessBitmap.Height; j++)
                {
                    color = brightnessBitmap.GetPixel(i, j);
                    int cR = color.R + brightness;
                    int cG = color.G + brightness;
                    int cB = color.B + brightness;

                    if (cR < 0) cR = 1;
                    if (cR > 255) cR = 255;

                    if (cG < 0) cG = 1;
                    if (cG > 255) cG = 255;

                    if (cB < 0) cB = 1;
                    if (cB > 255) cB = 255;

                    brightnessBitmap.SetPixel(i, j, Color.FromArgb((byte)cR, (byte)cG, (byte)cB));
                }
            }
            return brightnessBitmap;
        }

        public static Bitmap Contrast(Bitmap sourceBitmap, double contrast)
        {
            Bitmap contrastBitmap = sourceBitmap.Clone() as Bitmap;

            contrast = (100.0 + contrast) / 100.0;
            contrast *= contrast;

            Color color;
            for (int i = 0; i < contrastBitmap.Width; i++)
            {
                for (int j = 0; j < contrastBitmap.Height; j++)
                {
                    color = contrastBitmap.GetPixel(i, j);

                    double pR = color.R / 255.0;
                    pR -= 0.5;
                    pR *= contrast;
                    pR += 0.5;
                    pR *= 255;
                    if (pR < 0) pR = 0;
                    if (pR > 255) pR = 255;

                    double pG = color.G / 255.0;
                    pG -= 0.5;
                    pG *= contrast;
                    pG += 0.5;
                    pG *= 255;
                    if (pG < 0) pG = 0;
                    if (pG > 255) pG = 255;

                    double pB = color.B / 255.0;
                    pB -= 0.5;
                    pB *= contrast;
                    pB += 0.5;
                    pB *= 255;
                    if (pB < 0) pB = 0;
                    if (pB > 255) pB = 255;

                    contrastBitmap.SetPixel(i, j, Color.FromArgb((byte)pR, (byte)pG, (byte)pB));
                }
            }
            return contrastBitmap;
        }

        public static Bitmap Gamma(Bitmap sourceBitmap, double red, double green, double blue)
        {
            byte[] redGamma = new byte[256];
            byte[] greenGamma = new byte[256];
            byte[] blueGamma = new byte[256];

            for (int i = 0; i < 256; ++i)
            {
                redGamma[i] = (byte)Math.Min(255, (int)((255.0 * Math.Pow(i / 255.0, 1.0 / red)) + 0.5));
                greenGamma[i] = (byte)Math.Min(255, (int)((255.0 * Math.Pow(i / 255.0, 1.0 / green)) + 0.5));
                blueGamma[i] = (byte)Math.Min(255, (int)((255.0 * Math.Pow(i / 255.0, 1.0 / blue)) + 0.5));
            }

            Bitmap gammaBitmap = sourceBitmap.Clone() as Bitmap;

            BitmapData bmData = gammaBitmap.LockBits(new Rectangle(0, 0, gammaBitmap.Width, gammaBitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;
            IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - gammaBitmap.Width * 3;

                for (int y = 0; y < gammaBitmap.Height; ++y)
                {
                    for (int x = 0; x < gammaBitmap.Width; ++x)
                    {
                        p[2] = redGamma[p[2]];
                        p[1] = greenGamma[p[1]];
                        p[0] = blueGamma[p[0]];

                        p += 3;
                    }
                    p += nOffset;
                }
            }

            gammaBitmap.UnlockBits(bmData);

            return gammaBitmap;
        }
    }
}

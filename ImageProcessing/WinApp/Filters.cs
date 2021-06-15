using System;
using System.Drawing;

namespace ImageProcessing
{
    public class BitmapFilter
    {
        public static Bitmap Invert(Bitmap sourceBitmap)
        {
            Bitmap invertBitmap = sourceBitmap.Clone() as Bitmap;
            Color color;
            for (int i = 0; i < invertBitmap.Width; i++)
            {
                for (int j = 0; j < invertBitmap.Height; j++)
                {
                    color = invertBitmap.GetPixel(i, j);
                    invertBitmap.SetPixel(i, j, Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B));
                }
            }
            return invertBitmap;
        }

        public static Bitmap GrayScale(Bitmap sourceBitmap)
        {
            Bitmap grayscaleBitmap = sourceBitmap.Clone() as Bitmap;
            Color color;
            for (int i = 0; i < grayscaleBitmap.Width; i++)
            {
                for (int j = 0; j < grayscaleBitmap.Height; j++)
                {
                    color = grayscaleBitmap.GetPixel(i, j);
                    byte gray = (byte)(.299 * color.R + .587 * color.G + .114 * color.B);

                    grayscaleBitmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
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
            Color color;

            for (int i = 0; i < gammaBitmap.Width; i++)
            {
                for (int j = 0; j < gammaBitmap.Height; j++)
                {
                    color = gammaBitmap.GetPixel(i, j);
                    gammaBitmap.SetPixel(i, j, Color.FromArgb(redGamma[color.R], greenGamma[color.G], blueGamma[color.B]));
                }
            }
            return gammaBitmap;
        }
    }
}

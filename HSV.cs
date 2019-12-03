using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Separation
{
    class HSV : ColorModel
    {
        public HSV(Bitmap InitBitmap) : base(InitBitmap)
        {
        }
        public override (Bitmap, Bitmap, Bitmap) Transform()
        {
            for (int i = 0; i < InitBitmap.Width; i++)
            {
                for (int j = 0; j < InitBitmap.Height; j++)
                {

                    double H = 0;
                    double S = 0;
                    double V = 0;
                    Color p = InitBitmap.GetPixel(i, j);

                    double r = (double)p.R / 255;
                    double g = (double)p.G / 255;
                    double b = (double)p.B / 255;
                    double Cmax = Math.Max(r, Math.Max(g, b));
                    double Cmin = Math.Min(Math.Min(r, g), b);
                    double delta = Cmax - Cmin;

                    if (delta == 0)
                        H = 0;
                    else if (Cmax == r)
                        H = ((g - b) / delta % 6) * 60;
                    else if (Cmax == g)
                        H = ((b - r) / delta + 2) * 60;
                    else if (Cmax == b)
                        H = ((r - g) / delta + 4) * 60;

                    if (H < 0) H += 360;


                    if (Cmax == 0)
                        S = 0;
                    else
                        S = delta / Cmax;

                    V = Cmax;
                    S *= 100;
                    V *= 100;

                    if (H > 255)
                        H = H / 255;

                    rbmap.SetPixel(i, j, Color.FromArgb(255, (int)H, (int)H, (int)H));
                    gbmap.SetPixel(i, j, Color.FromArgb(255, (int)S, (int)S, (int)S));
                    bbmap.SetPixel(i, j, Color.FromArgb(255, (int)V, (int)V, (int)V));
                }

            }
            return (rbmap.Bitmap, gbmap.Bitmap, bbmap.Bitmap);
        }
    }

}

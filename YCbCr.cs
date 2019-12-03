using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Separation
{
    class YCbCr : ColorModel
    {
        public YCbCr(Bitmap InitBitmap) : base(InitBitmap)
        {

        }

        public override (Bitmap, Bitmap, Bitmap) Transform()
        {
            for (int i = 0; i < InitBitmap.Width; i++)
            {
                for (int j = 0; j < InitBitmap.Height; j++)
                {
                    Color p = InitBitmap.GetPixel(i, j);
                    double Y = 0.299 * p.R + 0.587 * p.G + 0.114 * p.B;
                    double Cb = -0.1687 * p.R - 0.3313 * p.G + 0.5 * p.B + 128;

                    double Cr = 0.5 * p.R - 0.4187 * p.G - 0.0813 * p.B + 128;


                    rbmap.SetPixel(i, j, Color.FromArgb(255, (int)Y, (int)Y, (int)Y));

                    //Color interpolation
                    var G1 = 255 - Cb;
                    var B1 = Cb;

                    var R1 = Cr;
                    var G2 = 255 - Cr;

                    gbmap.SetPixel(i, j, Color.FromArgb(255, 127, (int)G1, (int)B1));
                    bbmap.SetPixel(i, j, Color.FromArgb(255, (int)R1, (int)G2, 127));

                    //Gray shades

                    //gbmap.SetPixel(i, j, Color.FromArgb(255, (int)Cb, (int)Cb, (int)Cb));
                    //bbmap.SetPixel(i, j, Color.FromArgb(255, (int)Cr, (int)Cr, (int)Cr));


                }
            }

            return (rbmap.Bitmap, gbmap.Bitmap, bbmap.Bitmap);
        }
    }
}

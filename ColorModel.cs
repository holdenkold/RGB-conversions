using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Complex;

namespace RGB_Separation
{
    struct LabSettings
    {
        public (double, double) RedPrimary;
        public (double, double) GreenPrimary;
        public (double, double) BluePrimary;
        public (double, double) WhitePoint;
        public double gamma;
        public string cp;
        public string ci;

        public LabSettings(double rp_x, double rp_y, double gp_x, double gp_y, double bp_x, double bp_y, double wp_x, double wp_y, double gamma, string CP, string CI)
        {
            RedPrimary = (rp_x, rp_y);
            GreenPrimary = (gp_x, gp_y);
            BluePrimary = (bp_x, bp_y);
            WhitePoint = (wp_x, wp_y);
            this.gamma = gamma;
            this.cp = CP;
            this.ci = CI;
        }
    };

    abstract class ColorModel
    {
        protected Bitmap InitBitmap;
        protected Bitmap rbmap;
        protected Bitmap gbmap;
        protected Bitmap bbmap;

        public ColorModel(Bitmap InitBitmap)
        {
            this.InitBitmap = InitBitmap;
            rbmap = new Bitmap(InitBitmap);
            gbmap = new Bitmap(InitBitmap);
            bbmap = new Bitmap(InitBitmap);
        }
        abstract public (Bitmap, Bitmap, Bitmap) Transform();
    }

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
                    //double Cb =(p.B - Y) / 1.772 + 0.5;
                    double Cr = 0.5 * p.R - 0.4187 * p.G -  0.0813 * p.B +128 ;
                    //double Cr = (p.R - Y) / 1.402 + 0.5;


                    //Y = Y > 1 ? 1 : Y;

                    //Cb = Cb < 0 ? 0 : Cb;
                    //Cb = Cb > 1 ? 1 : Cb;

                    //Cr = Cr < 0 ? 0 : Cr;
                    //Cr = Cr > 1 ? 1 : Cr;

                  
                    rbmap.SetPixel(i, j, Color.FromArgb(255, (int)Y, (int)Y, (int)Y));
                    gbmap.SetPixel(i, j, Color.FromArgb(255, (int)Cb, (int)Cb, (int)Cb));
                    bbmap.SetPixel(i, j, Color.FromArgb(255, (int)Cr, (int)Cr, (int)Cr));

                }
            }

            return (rbmap, gbmap, bbmap);
        }
    }

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
            return (rbmap, gbmap, bbmap);
        }
    }

    class Lab : ColorModel
    {
        LabSettings ls;
        public Lab(Bitmap InitBitmap, LabSettings ls) : base(InitBitmap) 
        {
            this.ls = ls;
        }

        public override (Bitmap, Bitmap, Bitmap) Transform()
        {
            List<int> M = new List<int>();
            var Xr = ls.RedPrimary.Item1 / ls.RedPrimary.Item2;
            var Yr = 1;
            var Zr = (1 - ls.RedPrimary.Item1 - ls.RedPrimary.Item2) / ls.RedPrimary.Item2;

            var Xg = ls.GreenPrimary.Item1 / ls.GreenPrimary.Item2;
            var Yg = 1;
            var Zg = (1 - ls.GreenPrimary.Item1 - ls.GreenPrimary.Item2) / ls.GreenPrimary.Item2;

            var Xb = ls.BluePrimary.Item1 / ls.BluePrimary.Item2;
            var Yb = 1;
            var Zb = (1 - ls.BluePrimary.Item1 - ls.BluePrimary.Item2) / ls.BluePrimary.Item2;

            Matrix<double> a = DenseMatrix.OfArray(new double[,] {ls.WhitePoint.Item1, ls.WhitePoint.Item2});
            Matrix<double> b = DenseMatrix.OfArray(new double[,] { { 1 }, { 2 }, { 3 } });
            Matrix<double> S = a * b;

            return (rbmap, gbmap, bbmap);
        }
    }

}

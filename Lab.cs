using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Separation
{

    class Lab : ColorModel
    {
        LabSettings ls;
        public Lab(Bitmap InitBitmap, LabSettings ls) : base(InitBitmap)
        {
            this.ls = ls;
        }

        public override (Bitmap, Bitmap, Bitmap) Transform()
        {
            for (int i = 0; i < InitBitmap.Width; i++)
            {
                for (int j = 0; j < InitBitmap.Height; j++)
                {
                    Color p = InitBitmap.GetPixel(i, j);
                    double R = ((double)p.R / 255.0);
                    double G = ((double)p.G / 255.0);
                    double B = ((double)p.B / 255.0);

                    var XYZ = RGB2XYZ(R, G, B);
                    var lab = XYZ2LAB(XYZ);
                    var L = lab[0];
                    var a = lab[1];
                    var b = lab[2];

                    var r1 = a + 127;
                    var g1 = 127 - a;

                    var r2 = b + 127;
                    var b1 = 127 - b;

                    rbmap.SetPixel(i, j, Color.FromArgb(255, (int)L, (int)L, (int)L));
                    gbmap.SetPixel(i, j, Color.FromArgb(255, (int)r1, (int)g1, 127));
                    bbmap.SetPixel(i, j, Color.FromArgb(255, (int)r2, 127, (int)b1));
                }

            }


            return (rbmap.Bitmap, gbmap.Bitmap, bbmap.Bitmap);
        }

        public Vector<double> RGB2XYZ(double r, double g, double b)
        {
            var Xr = ls.RedPrimary.Item1 / ls.RedPrimary.Item2;
            var Yr = 1;
            var Zr = (1 - ls.RedPrimary.Item1 - ls.RedPrimary.Item2) / ls.RedPrimary.Item2;

            var Xg = ls.GreenPrimary.Item1 / ls.GreenPrimary.Item2;
            var Yg = 1;
            var Zg = (1 - ls.GreenPrimary.Item1 - ls.GreenPrimary.Item2) / ls.GreenPrimary.Item2;

            var Xb = ls.BluePrimary.Item1 / ls.BluePrimary.Item2;
            var Yb = 1;
            var Zb = (1 - ls.BluePrimary.Item1 - ls.BluePrimary.Item2) / ls.BluePrimary.Item2;

            var Zw = 1 - ls.WhitePoint.Item1 - ls.WhitePoint.Item2;

            Matrix<double> XYZ = Matrix<double>.Build.DenseOfArray(new double[,]
            {
                { Xr, Xg, Xb },
                { Yr, Yg, Yb },
                { Zr, Zg, Zb }
            });

            Vector<double> W = Vector<double>.Build.DenseOfArray(new double[] { ls.WhitePoint.Item1, ls.WhitePoint.Item2, Zw });
            Vector<double> S = XYZ.Inverse().Multiply(W);
            Matrix<double> M = Matrix<double>.Build.DenseOfArray(new double[,]
            {
                { S[0] * Xr, S[1] * Xg, S[2] * Xb },
                { S[0] * Yr, S[1] * Yg, S[2] * Yb },
                { S[0] * Zr, S[1] * Zg, S[2] * Zb }
            });

            Vector<double> x = M.Multiply(Vector<double>.Build.DenseOfArray(new double[] { r, g, b }));
            return x;
        }

        public Vector<double> XYZ2LAB(Vector<double> x)
        {
            double L, a, b;

            var e = 0.008856;
            var k = 903.3;

            double[] xr = new double[3];
            double[] f = new double[3];
            xr[0] = x[0] / ls.WhitePoint.Item1;
            xr[1] = x[1] / ls.WhitePoint.Item2;
            xr[2] = x[2] / (1 - ls.WhitePoint.Item1 - ls.WhitePoint.Item2);

            for (int i = 0; i < 3; i++)
            {
                if (xr[i] > e)
                    f[i] = Math.Pow(xr[i], 1.0 / 3.0);
                else
                    f[i] = (k * xr[i] + 16.0) / 116.0;
            }

            L = 116 * f[1] - 16.0;
            a = 500.0 * (f[0] - f[1]);
            b = 200.0 * (f[1] - f[2]);
            return Vector<double>.Build.DenseOfArray(new double[] { L, a, b });
        }
    }
    }

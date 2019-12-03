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
    abstract class ColorModel
    {
        protected Bitmap InitBitmap;
        protected DirectBitmap rbmap;
        protected DirectBitmap gbmap;
        protected DirectBitmap bbmap;

        public ColorModel(Bitmap InitBitmap)
        {
            this.InitBitmap = InitBitmap;
            rbmap = new DirectBitmap(InitBitmap.Width, InitBitmap.Height);
            gbmap = new DirectBitmap(InitBitmap.Width, InitBitmap.Height);
            bbmap = new DirectBitmap(InitBitmap.Width, InitBitmap.Height);
        }
        abstract public (Bitmap, Bitmap, Bitmap) Transform();
    }

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





}

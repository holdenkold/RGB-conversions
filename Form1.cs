using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_Separation
{
    public partial class Form1 : Form
    {
        Bitmap InitBitmap;
        Bitmap RedBitmap;
        Bitmap GreenBitmap;
        Bitmap BlueBitmap;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitImage.SizeMode = PictureBoxSizeMode.StretchImage;
            Image1.SizeMode = PictureBoxSizeMode.StretchImage;
            Image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Image3.SizeMode = PictureBoxSizeMode.StretchImage;
            LabBox.Enabled = false;
            D65.Checked = true;
            sRGB.Checked = true;
            SeparateChannels.Enabled = false;
            YCbCr.Enabled = false;
            HSV.Enabled = false;
            Lab.Enabled = false;
            SaveButton.Enabled = false;
            gamma.Value = (decimal)2.2;
        }

        private void InitImage_Click(object sender, EventArgs e)
        {
            //getting the image

            OpenFileDialog d = new OpenFileDialog();
            d.Title = "Choose image";
            //d.Filter = "bmp files (*.bmp)|*.bmp";

            if (d.ShowDialog() == DialogResult.OK)
            {
                InitImage.Image = Image.FromFile(d.FileName);//bitmap;
                InitBitmap = new Bitmap(d.FileName);
                RedBitmap = new Bitmap(InitBitmap);
                GreenBitmap = new Bitmap(InitBitmap);
                BlueBitmap = new Bitmap(InitBitmap);
            }

            SeparateChannels.Enabled = true;
            YCbCr.Enabled = true;
            HSV.Enabled = true;
            Lab.Enabled = true;
            SaveButton.Enabled = true;

        }

        private void SeparateChannels_Click(object sender, EventArgs e)
        {
            int width = InitBitmap.Width;
            int height = InitBitmap.Height;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color p = InitBitmap.GetPixel(i, j);
                    RedBitmap.SetPixel(i, j, Color.FromArgb(p.R, 0, 0));
                    GreenBitmap.SetPixel(i, j, Color.FromArgb(0, p.G, 0));
                    BlueBitmap.SetPixel(i, j, Color.FromArgb(0, 0, p.B));

                }
            }
            Image1.Image = RedBitmap;
            Image2.Image = GreenBitmap;
            Image3.Image = BlueBitmap;
        }

        private void YCbCr_Click(object sender, EventArgs e)
        {
            var cm = new YCbCr(InitBitmap);
            var imgs = cm.Transform();
            Image1.Image = imgs.Item1;
            Image2.Image = imgs.Item2;
            Image3.Image = imgs.Item3;
        }

        private void HSV_Click(object sender, EventArgs e)
        {
            var cm = new HSV(InitBitmap);
            var imgs = cm.Transform();
            Image1.Image = imgs.Item1;
            Image2.Image = imgs.Item2;
            Image3.Image = imgs.Item3;
        }

        private void Lab_Click(object sender, EventArgs e)
        {
            if (LabBox.Enabled)
            {
                var ls = new LabSettings((double)rp_x.Value, (double)rp_y.Value, (double)gp_x.Value, (double)gp_y.Value, (double)bp_x.Value, (double)bp_y.Value, (double)wp_x.Value, (double)wp_y.Value, (double)gamma.Value, "sRGB", "D65");
                var cm = new Lab(InitBitmap, ls);
                var imgs = cm.Transform();
                Image1.Image = imgs.Item1;
                Image2.Image = imgs.Item2;
                Image3.Image = imgs.Item3;
                LabBox.Enabled = false;
            }
            else
                LabBox.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //SaveFileDialog dialog = new SaveFileDialog();
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
                //Image1.Image.Save("Image1", ImageFormat.Jpeg);
                //Image2.Image.Save("Image2", ImageFormat.Jpeg);
                //Image3.Image.Save("Image3", ImageFormat.Jpeg);
            //}
        }

        private void sRGB_CheckedChanged(object sender, EventArgs e)
        {
            if (sRGB.Checked)
            {
                rp_x.Value = (decimal)0.64;
                rp_y.Value = (decimal)0.33;
                gp_x.Value = (decimal)0.3;
                gp_y.Value = (decimal)0.6;
                bp_x.Value = (decimal)0.15;
                bp_y.Value = (decimal)0.06;

                gamma.Value = (decimal)2.2;

            }

        }

        private void D65_CheckedChanged(object sender, EventArgs e)
        {
            if (D65.Checked)
            {
                wp_x.Value = (decimal)0.3127;
                wp_y.Value = (decimal)0.329;
            }
        }

        private void AdobeRGB_CheckedChanged(object sender, EventArgs e)
        {
            if (AdobeRGB.Checked)
            {
                rp_x.Value = (decimal)0.64;
                rp_y.Value = (decimal)0.33;
                gp_x.Value = (decimal)0.21;
                gp_y.Value = (decimal)0.71;
                bp_x.Value = (decimal)0.15;
                bp_y.Value = (decimal)0.06;

                gamma.Value = (decimal)2.2;

            }
        }

        private void AppleRGB_CheckedChanged(object sender, EventArgs e)
        {

            if (AppleRGB.Checked)
            {
                rp_x.Value = (decimal)0.625;
                rp_y.Value = (decimal)0.34;
                gp_x.Value = (decimal)0.28;
                gp_y.Value = (decimal)0.595;
                bp_x.Value = (decimal)0.155;
                bp_y.Value = (decimal)0.07;

                gamma.Value = (decimal)1.8;

            }

        }

        private void CIE_RGB_CheckedChanged(object sender, EventArgs e)
        {
            if (CIE_RGB.Checked)
            {
                rp_x.Value = (decimal)0.735;
                rp_y.Value = (decimal)0.265;
                gp_x.Value = (decimal)0.274;
                gp_y.Value = (decimal)0.717;
                bp_x.Value = (decimal)0.167;
                bp_y.Value = (decimal)0.009;

                gamma.Value = (decimal)2.2;

            }
        }

        private void Wide_Gamut_CheckedChanged(object sender, EventArgs e)
        {

            if (Wide_Gamut.Checked)
            {
                rp_x.Value = (decimal)0.7347;
                rp_y.Value = (decimal)0.2653;
                gp_x.Value = (decimal)0.1152;
                gp_y.Value = (decimal)0.8264;
                bp_x.Value = (decimal)0.1566;
                bp_y.Value = (decimal)0.0177;

                gamma.Value = (decimal)1.2;

            }
        }

        private void PAL_SECAM_CheckedChanged(object sender, EventArgs e)
        {
            if (PAL_SECAM.Checked)
            {
                rp_x.Value = (decimal)0.64;
                rp_y.Value = (decimal)0.33;
                gp_x.Value = (decimal)0.29;
                gp_y.Value = (decimal)0.6;
                bp_x.Value = (decimal)0.15;
                bp_y.Value = (decimal)0.06;

                gamma.Value = (decimal)1.95;
            }
        }
    }
}

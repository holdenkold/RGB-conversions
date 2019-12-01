﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
namespace RGB_Separation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InitImage = new System.Windows.Forms.PictureBox();
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.Image2 = new System.Windows.Forms.PictureBox();
            this.Image3 = new System.Windows.Forms.PictureBox();
            this.SeparateChannels = new System.Windows.Forms.Button();
            this.YCbCr = new System.Windows.Forms.Button();
            this.HSV = new System.Windows.Forms.Button();
            this.Lab = new System.Windows.Forms.Button();
            this.LabBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rp_x = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sRGB = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rp_y = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.gp_x = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.gp_y = new System.Windows.Forms.NumericUpDown();
            this.bp_x = new System.Windows.Forms.NumericUpDown();
            this.bp_y = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.D65 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.wp_x = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.wp_y = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gamma = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.AdobeRGB = new System.Windows.Forms.RadioButton();
            this.AppleRGB = new System.Windows.Forms.RadioButton();
            this.CIE_RGB = new System.Windows.Forms.RadioButton();
            this.Wide_Gamut = new System.Windows.Forms.RadioButton();
            this.PAL_SECAM = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.InitImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image3)).BeginInit();
            this.LabBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rp_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp_y)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wp_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wp_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamma)).BeginInit();
            this.SuspendLayout();
            // 
            // InitImage
            // 
            this.InitImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InitImage.Location = new System.Drawing.Point(21, 16);
            this.InitImage.Name = "InitImage";
            this.InitImage.Size = new System.Drawing.Size(181, 160);
            this.InitImage.TabIndex = 1;
            this.InitImage.TabStop = false;
            this.InitImage.Click += new System.EventHandler(this.InitImage_Click);
            // 
            // Image1
            // 
            this.Image1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Image1.Location = new System.Drawing.Point(21, 337);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(181, 160);
            this.Image1.TabIndex = 2;
            this.Image1.TabStop = false;
            // 
            // Image2
            // 
            this.Image2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Image2.Location = new System.Drawing.Point(297, 337);
            this.Image2.Name = "Image2";
            this.Image2.Size = new System.Drawing.Size(181, 160);
            this.Image2.TabIndex = 3;
            this.Image2.TabStop = false;
            // 
            // Image3
            // 
            this.Image3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Image3.Location = new System.Drawing.Point(581, 337);
            this.Image3.Name = "Image3";
            this.Image3.Size = new System.Drawing.Size(181, 160);
            this.Image3.TabIndex = 4;
            this.Image3.TabStop = false;
            // 
            // SeparateChannels
            // 
            this.SeparateChannels.Location = new System.Drawing.Point(21, 278);
            this.SeparateChannels.Name = "SeparateChannels";
            this.SeparateChannels.Size = new System.Drawing.Size(139, 30);
            this.SeparateChannels.TabIndex = 5;
            this.SeparateChannels.Text = "Separate Channels";
            this.SeparateChannels.UseVisualStyleBackColor = true;
            this.SeparateChannels.Click += new System.EventHandler(this.SeparateChannels_Click);
            // 
            // YCbCr
            // 
            this.YCbCr.Location = new System.Drawing.Point(193, 278);
            this.YCbCr.Name = "YCbCr";
            this.YCbCr.Size = new System.Drawing.Size(118, 30);
            this.YCbCr.TabIndex = 6;
            this.YCbCr.Text = "YCbCr";
            this.YCbCr.UseVisualStyleBackColor = true;
            this.YCbCr.Click += new System.EventHandler(this.YCbCr_Click);
            // 
            // HSV
            // 
            this.HSV.Location = new System.Drawing.Point(346, 278);
            this.HSV.Name = "HSV";
            this.HSV.Size = new System.Drawing.Size(113, 30);
            this.HSV.TabIndex = 7;
            this.HSV.Text = "HSV";
            this.HSV.UseVisualStyleBackColor = true;
            this.HSV.Click += new System.EventHandler(this.HSV_Click);
            // 
            // Lab
            // 
            this.Lab.Location = new System.Drawing.Point(498, 278);
            this.Lab.Name = "Lab";
            this.Lab.Size = new System.Drawing.Size(114, 30);
            this.Lab.TabIndex = 8;
            this.Lab.Text = "L*a*b*";
            this.Lab.UseVisualStyleBackColor = true;
            this.Lab.Click += new System.EventHandler(this.Lab_Click);
            // 
            // LabBox
            // 
            this.LabBox.Controls.Add(this.groupBox2);
            this.LabBox.Controls.Add(this.groupBox1);
            this.LabBox.Controls.Add(this.label8);
            this.LabBox.Controls.Add(this.gamma);
            this.LabBox.Location = new System.Drawing.Point(224, 12);
            this.LabBox.Name = "LabBox";
            this.LabBox.Size = new System.Drawing.Size(553, 244);
            this.LabBox.TabIndex = 9;
            this.LabBox.TabStop = false;
            this.LabBox.Text = "L*a*b* Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PAL_SECAM);
            this.groupBox2.Controls.Add(this.Wide_Gamut);
            this.groupBox2.Controls.Add(this.CIE_RGB);
            this.groupBox2.Controls.Add(this.AppleRGB);
            this.groupBox2.Controls.Add(this.AdobeRGB);
            this.groupBox2.Controls.Add(this.rp_x);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.sRGB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rp_y);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.gp_x);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.gp_y);
            this.groupBox2.Controls.Add(this.bp_x);
            this.groupBox2.Controls.Add(this.bp_y);
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 202);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Predefined color profile";
            // 
            // rp_x
            // 
            this.rp_x.DecimalPlaces = 4;
            this.rp_x.Location = new System.Drawing.Point(72, 111);
            this.rp_x.Name = "rp_x";
            this.rp_x.Size = new System.Drawing.Size(67, 20);
            this.rp_x.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-21, -29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Predefined color profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // sRGB
            // 
            this.sRGB.AutoSize = true;
            this.sRGB.Location = new System.Drawing.Point(10, 19);
            this.sRGB.Name = "sRGB";
            this.sRGB.Size = new System.Drawing.Size(53, 17);
            this.sRGB.TabIndex = 2;
            this.sRGB.TabStop = true;
            this.sRGB.Text = "sRGB";
            this.sRGB.UseVisualStyleBackColor = true;
            this.sRGB.CheckedChanged += new System.EventHandler(this.sRGB_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Blue";
            // 
            // rp_y
            // 
            this.rp_y.DecimalPlaces = 4;
            this.rp_y.Location = new System.Drawing.Point(146, 111);
            this.rp_y.Name = "rp_y";
            this.rp_y.Size = new System.Drawing.Size(67, 20);
            this.rp_y.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Green";
            // 
            // gp_x
            // 
            this.gp_x.DecimalPlaces = 4;
            this.gp_x.Location = new System.Drawing.Point(72, 137);
            this.gp_x.Name = "gp_x";
            this.gp_x.Size = new System.Drawing.Size(67, 20);
            this.gp_x.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Red";
            // 
            // gp_y
            // 
            this.gp_y.DecimalPlaces = 4;
            this.gp_y.Location = new System.Drawing.Point(146, 137);
            this.gp_y.Name = "gp_y";
            this.gp_y.Size = new System.Drawing.Size(67, 20);
            this.gp_y.TabIndex = 6;
            // 
            // bp_x
            // 
            this.bp_x.DecimalPlaces = 4;
            this.bp_x.Location = new System.Drawing.Point(72, 163);
            this.bp_x.Name = "bp_x";
            this.bp_x.Size = new System.Drawing.Size(67, 20);
            this.bp_x.TabIndex = 7;
            // 
            // bp_y
            // 
            this.bp_y.DecimalPlaces = 4;
            this.bp_y.Location = new System.Drawing.Point(145, 163);
            this.bp_y.Name = "bp_y";
            this.bp_y.Size = new System.Drawing.Size(67, 20);
            this.bp_y.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.D65);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.wp_x);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.wp_y);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(304, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 140);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Predefined illuminant";
            // 
            // D65
            // 
            this.D65.AutoSize = true;
            this.D65.Location = new System.Drawing.Point(13, 19);
            this.D65.Name = "D65";
            this.D65.Size = new System.Drawing.Size(45, 17);
            this.D65.TabIndex = 20;
            this.D65.TabStop = true;
            this.D65.Text = "D65";
            this.D65.UseVisualStyleBackColor = true;
            this.D65.CheckedChanged += new System.EventHandler(this.D65_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(169, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Y";
            // 
            // wp_x
            // 
            this.wp_x.DecimalPlaces = 4;
            this.wp_x.Location = new System.Drawing.Point(79, 63);
            this.wp_x.Name = "wp_x";
            this.wp_x.Size = new System.Drawing.Size(67, 20);
            this.wp_x.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(100, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "X";
            // 
            // wp_y
            // 
            this.wp_y.DecimalPlaces = 4;
            this.wp_y.Location = new System.Drawing.Point(152, 63);
            this.wp_y.Name = "wp_y";
            this.wp_y.Size = new System.Drawing.Size(67, 20);
            this.wp_y.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "White point";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Gamma";
            // 
            // gamma
            // 
            this.gamma.DecimalPlaces = 4;
            this.gamma.Location = new System.Drawing.Point(372, 188);
            this.gamma.Name = "gamma";
            this.gamma.Size = new System.Drawing.Size(67, 20);
            this.gamma.TabIndex = 11;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(648, 278);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(114, 30);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AdobeRGB
            // 
            this.AdobeRGB.AutoSize = true;
            this.AdobeRGB.Location = new System.Drawing.Point(86, 19);
            this.AdobeRGB.Name = "AdobeRGB";
            this.AdobeRGB.Size = new System.Drawing.Size(79, 17);
            this.AdobeRGB.TabIndex = 19;
            this.AdobeRGB.TabStop = true;
            this.AdobeRGB.Text = "AdobeRGB";
            this.AdobeRGB.UseVisualStyleBackColor = true;
            this.AdobeRGB.CheckedChanged += new System.EventHandler(this.AdobeRGB_CheckedChanged);
            // 
            // AppleRGB
            // 
            this.AppleRGB.AutoSize = true;
            this.AppleRGB.Location = new System.Drawing.Point(186, 19);
            this.AppleRGB.Name = "AppleRGB";
            this.AppleRGB.Size = new System.Drawing.Size(75, 17);
            this.AppleRGB.TabIndex = 20;
            this.AppleRGB.TabStop = true;
            this.AppleRGB.Text = "AppleRGB";
            this.AppleRGB.UseVisualStyleBackColor = true;
            this.AppleRGB.CheckedChanged += new System.EventHandler(this.AppleRGB_CheckedChanged);
            // 
            // CIE_RGB
            // 
            this.CIE_RGB.AutoSize = true;
            this.CIE_RGB.Location = new System.Drawing.Point(6, 52);
            this.CIE_RGB.Name = "CIE_RGB";
            this.CIE_RGB.Size = new System.Drawing.Size(68, 17);
            this.CIE_RGB.TabIndex = 21;
            this.CIE_RGB.TabStop = true;
            this.CIE_RGB.Text = "CIE RGB";
            this.CIE_RGB.UseVisualStyleBackColor = true;
            this.CIE_RGB.CheckedChanged += new System.EventHandler(this.CIE_RGB_CheckedChanged);
            // 
            // Wide_Gamut
            // 
            this.Wide_Gamut.AutoSize = true;
            this.Wide_Gamut.Location = new System.Drawing.Point(86, 52);
            this.Wide_Gamut.Name = "Wide_Gamut";
            this.Wide_Gamut.Size = new System.Drawing.Size(84, 17);
            this.Wide_Gamut.TabIndex = 22;
            this.Wide_Gamut.TabStop = true;
            this.Wide_Gamut.Text = "Wide Gamut";
            this.Wide_Gamut.UseVisualStyleBackColor = true;
            this.Wide_Gamut.CheckedChanged += new System.EventHandler(this.Wide_Gamut_CheckedChanged);
            // 
            // PAL_SECAM
            // 
            this.PAL_SECAM.AutoSize = true;
            this.PAL_SECAM.Location = new System.Drawing.Point(185, 52);
            this.PAL_SECAM.Name = "PAL_SECAM";
            this.PAL_SECAM.Size = new System.Drawing.Size(87, 17);
            this.PAL_SECAM.TabIndex = 23;
            this.PAL_SECAM.TabStop = true;
            this.PAL_SECAM.Text = "PAL/SECAM";
            this.PAL_SECAM.UseVisualStyleBackColor = true;
            this.PAL_SECAM.CheckedChanged += new System.EventHandler(this.PAL_SECAM_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 525);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LabBox);
            this.Controls.Add(this.Lab);
            this.Controls.Add(this.HSV);
            this.Controls.Add(this.YCbCr);
            this.Controls.Add(this.SeparateChannels);
            this.Controls.Add(this.Image3);
            this.Controls.Add(this.Image2);
            this.Controls.Add(this.Image1);
            this.Controls.Add(this.InitImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InitImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image3)).EndInit();
            this.LabBox.ResumeLayout(false);
            this.LabBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rp_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp_y)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wp_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wp_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox InitImage;
        private System.Windows.Forms.PictureBox Image1;
        private System.Windows.Forms.PictureBox Image2;
        private System.Windows.Forms.PictureBox Image3;
        private System.Windows.Forms.Button SeparateChannels;
        private System.Windows.Forms.Button YCbCr;
        private System.Windows.Forms.Button HSV;
        private System.Windows.Forms.Button Lab;
        private System.Windows.Forms.GroupBox LabBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown gamma;
        private System.Windows.Forms.NumericUpDown wp_y;
        private System.Windows.Forms.NumericUpDown wp_x;
        private System.Windows.Forms.NumericUpDown bp_y;
        private System.Windows.Forms.NumericUpDown bp_x;
        private System.Windows.Forms.NumericUpDown gp_y;
        private System.Windows.Forms.NumericUpDown gp_x;
        private System.Windows.Forms.NumericUpDown rp_y;
        private System.Windows.Forms.NumericUpDown rp_x;
        private System.Windows.Forms.RadioButton sRGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton D65;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.RadioButton AppleRGB;
        private System.Windows.Forms.RadioButton AdobeRGB;
        private System.Windows.Forms.RadioButton PAL_SECAM;
        private System.Windows.Forms.RadioButton Wide_Gamut;
        private System.Windows.Forms.RadioButton CIE_RGB;
    }
}


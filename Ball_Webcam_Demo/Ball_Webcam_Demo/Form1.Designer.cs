namespace Ball_Webcam_Demo
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
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.HueMin_trackBar1 = new System.Windows.Forms.TrackBar();
            this.ValMax_trackBar2 = new System.Windows.Forms.TrackBar();
            this.ValMin_trackBar3 = new System.Windows.Forms.TrackBar();
            this.SatMax_trackBar4 = new System.Windows.Forms.TrackBar();
            this.SatMin_trackBar5 = new System.Windows.Forms.TrackBar();
            this.HueMax_trackBar6 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueMin_trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValMax_trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValMin_trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatMax_trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatMin_trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueMax_trackBar6)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 11);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(416, 323);
            this.imageBox1.TabIndex = 3;
            this.imageBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Number of Contours";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(469, 123);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ball?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(469, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 22);
            this.textBox1.TabIndex = 7;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(13, 392);
            this.imageBox2.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(416, 323);
            this.imageBox2.TabIndex = 11;
            this.imageBox2.TabStop = false;
            // 
            // HueMin_trackBar1
            // 
            this.HueMin_trackBar1.Location = new System.Drawing.Point(670, 23);
            this.HueMin_trackBar1.Maximum = 255;
            this.HueMin_trackBar1.Name = "HueMin_trackBar1";
            this.HueMin_trackBar1.Size = new System.Drawing.Size(359, 56);
            this.HueMin_trackBar1.TabIndex = 12;
            this.HueMin_trackBar1.ValueChanged += new System.EventHandler(this.HueMin_trackBar1_ValueChanged);
            // 
            // ValMax_trackBar2
            // 
            this.ValMax_trackBar2.Location = new System.Drawing.Point(670, 337);
            this.ValMax_trackBar2.Maximum = 255;
            this.ValMax_trackBar2.Name = "ValMax_trackBar2";
            this.ValMax_trackBar2.Size = new System.Drawing.Size(359, 56);
            this.ValMax_trackBar2.TabIndex = 13;
            this.ValMax_trackBar2.Value = 255;
            this.ValMax_trackBar2.ValueChanged += new System.EventHandler(this.ValMax_trackBar2_ValueChanged);
            // 
            // ValMin_trackBar3
            // 
            this.ValMin_trackBar3.Location = new System.Drawing.Point(670, 275);
            this.ValMin_trackBar3.Maximum = 255;
            this.ValMin_trackBar3.Name = "ValMin_trackBar3";
            this.ValMin_trackBar3.Size = new System.Drawing.Size(359, 56);
            this.ValMin_trackBar3.TabIndex = 14;
            this.ValMin_trackBar3.ValueChanged += new System.EventHandler(this.ValMin_trackBar3_ValueChanged);
            // 
            // SatMax_trackBar4
            // 
            this.SatMax_trackBar4.Location = new System.Drawing.Point(670, 213);
            this.SatMax_trackBar4.Maximum = 255;
            this.SatMax_trackBar4.Name = "SatMax_trackBar4";
            this.SatMax_trackBar4.Size = new System.Drawing.Size(359, 56);
            this.SatMax_trackBar4.TabIndex = 15;
            this.SatMax_trackBar4.Value = 255;
            this.SatMax_trackBar4.ValueChanged += new System.EventHandler(this.SatMax_trackBar4_ValueChanged);
            // 
            // SatMin_trackBar5
            // 
            this.SatMin_trackBar5.Location = new System.Drawing.Point(670, 151);
            this.SatMin_trackBar5.Maximum = 255;
            this.SatMin_trackBar5.Name = "SatMin_trackBar5";
            this.SatMin_trackBar5.Size = new System.Drawing.Size(359, 56);
            this.SatMin_trackBar5.TabIndex = 16;
            this.SatMin_trackBar5.ValueChanged += new System.EventHandler(this.SatMin_trackBar5_ValueChanged);
            // 
            // HueMax_trackBar6
            // 
            this.HueMax_trackBar6.Location = new System.Drawing.Point(670, 89);
            this.HueMax_trackBar6.Maximum = 255;
            this.HueMax_trackBar6.Name = "HueMax_trackBar6";
            this.HueMax_trackBar6.Size = new System.Drawing.Size(359, 56);
            this.HueMax_trackBar6.TabIndex = 17;
            this.HueMax_trackBar6.Value = 255;
            this.HueMax_trackBar6.ValueChanged += new System.EventHandler(this.HueMax_trackBar6_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1036, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hue Min";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1036, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Hue Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1036, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Saturation Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1036, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Saturation Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1035, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Value Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1036, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Value Max";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 756);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HueMax_trackBar6);
            this.Controls.Add(this.SatMin_trackBar5);
            this.Controls.Add(this.SatMax_trackBar4);
            this.Controls.Add(this.ValMin_trackBar3);
            this.Controls.Add(this.ValMax_trackBar2);
            this.Controls.Add(this.HueMin_trackBar1);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.imageBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueMin_trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValMax_trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValMin_trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatMax_trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatMin_trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueMax_trackBar6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.TrackBar HueMin_trackBar1;
        private System.Windows.Forms.TrackBar ValMax_trackBar2;
        private System.Windows.Forms.TrackBar ValMin_trackBar3;
        private System.Windows.Forms.TrackBar SatMax_trackBar4;
        private System.Windows.Forms.TrackBar SatMin_trackBar5;
        private System.Windows.Forms.TrackBar HueMax_trackBar6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}


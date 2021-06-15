namespace ImageProcessing
{
    partial class frmGamma
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picProcessed = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackRed = new ImageProcessing.MyTrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trackGreen = new ImageProcessing.MyTrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.trackBlue = new ImageProcessing.MyTrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessed)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel1.Size = new System.Drawing.Size(784, 404);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picProcessed);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(398, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 394);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Processed Image";
            // 
            // picProcessed
            // 
            this.picProcessed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picProcessed.Location = new System.Drawing.Point(3, 16);
            this.picProcessed.Name = "picProcessed";
            this.picProcessed.Size = new System.Drawing.Size(370, 375);
            this.picProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProcessed.TabIndex = 1;
            this.picProcessed.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picOriginal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(10, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original Image";
            // 
            // picOriginal
            // 
            this.picOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picOriginal.Location = new System.Drawing.Point(3, 16);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(370, 375);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 57);
            this.panel2.TabIndex = 1;
            // 
            // trackRed
            // 
            this.trackRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackRed.Factor = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trackRed.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.trackRed.Location = new System.Drawing.Point(33, 16);
            this.trackRed.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            this.trackRed.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.trackRed.Name = "trackRed";
            this.trackRed.Size = new System.Drawing.Size(196, 38);
            this.trackRed.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trackRed.TabIndex = 0;
            this.trackRed.TickFrequency = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trackRed.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.trackRed.ValueChanged += new System.EventHandler(this.trackGamma_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trackRed);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 57);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Red Value";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(229, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "5";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "0.2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trackGreen);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(262, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 57);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Green Value";
            // 
            // trackGreen
            // 
            this.trackGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackGreen.Factor = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trackGreen.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.trackGreen.Location = new System.Drawing.Point(33, 16);
            this.trackGreen.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            this.trackGreen.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.trackGreen.Name = "trackGreen";
            this.trackGreen.Size = new System.Drawing.Size(194, 38);
            this.trackGreen.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trackGreen.TabIndex = 0;
            this.trackGreen.TickFrequency = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trackGreen.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.trackGreen.ValueChanged += new System.EventHandler(this.trackGamma_ValueChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(227, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "5";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "0.2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.trackBlue);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Location = new System.Drawing.Point(522, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(262, 57);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Blue Value";
            // 
            // trackBlue
            // 
            this.trackBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBlue.Factor = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trackBlue.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.trackBlue.Location = new System.Drawing.Point(33, 16);
            this.trackBlue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            this.trackBlue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.trackBlue.Name = "trackBlue";
            this.trackBlue.Size = new System.Drawing.Size(196, 38);
            this.trackBlue.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trackBlue.TabIndex = 0;
            this.trackBlue.TickFrequency = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trackBlue.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.trackBlue.ValueChanged += new System.EventHandler(this.trackGamma_ValueChanged);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(229, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "0.2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGamma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGamma";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gamma Form";
            this.Load += new System.EventHandler(this.frmGamma_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProcessed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.PictureBox picProcessed;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private MyTrackBar trackRed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private MyTrackBar trackGreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private MyTrackBar trackBlue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
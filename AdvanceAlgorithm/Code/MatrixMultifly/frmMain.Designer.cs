
namespace MatrixMultifly
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSelectMatrix2File = new System.Windows.Forms.Button();
            this.btnSelectMatrix1File = new System.Windows.Forms.Button();
            this.txtMatrix2FilePath = new System.Windows.Forms.TextBox();
            this.txtMatrix1FilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupMatrixMultiply = new System.Windows.Forms.GroupBox();
            this.btnResetMatrix2File = new System.Windows.Forms.Button();
            this.btnResetMatrix1File = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupResultStrassen = new System.Windows.Forms.GroupBox();
            this.btnSaveStrassen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExecuteStrassen = new System.Windows.Forms.Button();
            this.txtTimeStrassen = new System.Windows.Forms.TextBox();
            this.groupResultNormal = new System.Windows.Forms.GroupBox();
            this.btnSaveNormal = new System.Windows.Forms.Button();
            this.btnExecuteNormal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimeNormal = new System.Windows.Forms.TextBox();
            this.groupCreateMatrix = new System.Windows.Forms.GroupBox();
            this.chkLimit = new System.Windows.Forms.CheckBox();
            this.txtColumn = new System.Windows.Forms.NumericUpDown();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.txtRow = new System.Windows.Forms.NumericUpDown();
            this.btnCreateMatrix = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.brgWorker = new System.ComponentModel.BackgroundWorker();
            this.groupMatrixMultiply.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupResultStrassen.SuspendLayout();
            this.groupResultNormal.SuspendLayout();
            this.groupCreateMatrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectMatrix2File
            // 
            this.btnSelectMatrix2File.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectMatrix2File.Location = new System.Drawing.Point(363, 45);
            this.btnSelectMatrix2File.Name = "btnSelectMatrix2File";
            this.btnSelectMatrix2File.Size = new System.Drawing.Size(90, 23);
            this.btnSelectMatrix2File.TabIndex = 3;
            this.btnSelectMatrix2File.Text = "Chọn tập tin";
            this.btnSelectMatrix2File.UseVisualStyleBackColor = true;
            this.btnSelectMatrix2File.Click += new System.EventHandler(this.btnSelectMatrixFile_Click);
            // 
            // btnSelectMatrix1File
            // 
            this.btnSelectMatrix1File.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectMatrix1File.Location = new System.Drawing.Point(363, 18);
            this.btnSelectMatrix1File.Name = "btnSelectMatrix1File";
            this.btnSelectMatrix1File.Size = new System.Drawing.Size(90, 23);
            this.btnSelectMatrix1File.TabIndex = 1;
            this.btnSelectMatrix1File.Text = "Chọn tập tin";
            this.btnSelectMatrix1File.UseVisualStyleBackColor = true;
            this.btnSelectMatrix1File.Click += new System.EventHandler(this.btnSelectMatrixFile_Click);
            // 
            // txtMatrix2FilePath
            // 
            this.txtMatrix2FilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatrix2FilePath.Location = new System.Drawing.Point(83, 46);
            this.txtMatrix2FilePath.Name = "txtMatrix2FilePath";
            this.txtMatrix2FilePath.ReadOnly = true;
            this.txtMatrix2FilePath.Size = new System.Drawing.Size(274, 21);
            this.txtMatrix2FilePath.TabIndex = 2;
            this.txtMatrix2FilePath.TabStop = false;
            // 
            // txtMatrix1FilePath
            // 
            this.txtMatrix1FilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatrix1FilePath.Location = new System.Drawing.Point(83, 19);
            this.txtMatrix1FilePath.Name = "txtMatrix1FilePath";
            this.txtMatrix1FilePath.ReadOnly = true;
            this.txtMatrix1FilePath.Size = new System.Drawing.Size(274, 21);
            this.txtMatrix1FilePath.TabIndex = 0;
            this.txtMatrix1FilePath.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ma trận 2 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma trận 1 :";
            // 
            // groupMatrixMultiply
            // 
            this.groupMatrixMultiply.Controls.Add(this.btnResetMatrix2File);
            this.groupMatrixMultiply.Controls.Add(this.btnResetMatrix1File);
            this.groupMatrixMultiply.Controls.Add(this.panel1);
            this.groupMatrixMultiply.Controls.Add(this.btnSelectMatrix2File);
            this.groupMatrixMultiply.Controls.Add(this.txtMatrix1FilePath);
            this.groupMatrixMultiply.Controls.Add(this.label1);
            this.groupMatrixMultiply.Controls.Add(this.label2);
            this.groupMatrixMultiply.Controls.Add(this.txtMatrix2FilePath);
            this.groupMatrixMultiply.Controls.Add(this.btnSelectMatrix1File);
            this.groupMatrixMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupMatrixMultiply.Location = new System.Drawing.Point(10, 66);
            this.groupMatrixMultiply.Name = "groupMatrixMultiply";
            this.groupMatrixMultiply.Size = new System.Drawing.Size(564, 171);
            this.groupMatrixMultiply.TabIndex = 1;
            this.groupMatrixMultiply.TabStop = false;
            this.groupMatrixMultiply.Text = "Nhân ma trận";
            // 
            // btnResetMatrix2File
            // 
            this.btnResetMatrix2File.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetMatrix2File.Enabled = false;
            this.btnResetMatrix2File.Location = new System.Drawing.Point(459, 45);
            this.btnResetMatrix2File.Name = "btnResetMatrix2File";
            this.btnResetMatrix2File.Size = new System.Drawing.Size(90, 23);
            this.btnResetMatrix2File.TabIndex = 2;
            this.btnResetMatrix2File.Text = "Chọn lại";
            this.btnResetMatrix2File.UseVisualStyleBackColor = true;
            this.btnResetMatrix2File.Click += new System.EventHandler(this.btnResetMatrixFile_Click);
            // 
            // btnResetMatrix1File
            // 
            this.btnResetMatrix1File.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetMatrix1File.Enabled = false;
            this.btnResetMatrix1File.Location = new System.Drawing.Point(459, 18);
            this.btnResetMatrix1File.Name = "btnResetMatrix1File";
            this.btnResetMatrix1File.Size = new System.Drawing.Size(90, 23);
            this.btnResetMatrix1File.TabIndex = 2;
            this.btnResetMatrix1File.Text = "Chọn lại";
            this.btnResetMatrix1File.UseVisualStyleBackColor = true;
            this.btnResetMatrix1File.Click += new System.EventHandler(this.btnResetMatrixFile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupResultStrassen);
            this.panel1.Controls.Add(this.groupResultNormal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 88);
            this.panel1.TabIndex = 6;
            // 
            // groupResultStrassen
            // 
            this.groupResultStrassen.Controls.Add(this.btnSaveStrassen);
            this.groupResultStrassen.Controls.Add(this.label7);
            this.groupResultStrassen.Controls.Add(this.btnExecuteStrassen);
            this.groupResultStrassen.Controls.Add(this.txtTimeStrassen);
            this.groupResultStrassen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupResultStrassen.Location = new System.Drawing.Point(279, 0);
            this.groupResultStrassen.Name = "groupResultStrassen";
            this.groupResultStrassen.Size = new System.Drawing.Size(279, 88);
            this.groupResultStrassen.TabIndex = 1;
            this.groupResultStrassen.TabStop = false;
            this.groupResultStrassen.Text = "Nhân bằng Strassen ";
            // 
            // btnSaveStrassen
            // 
            this.btnSaveStrassen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveStrassen.Enabled = false;
            this.btnSaveStrassen.Location = new System.Drawing.Point(170, 51);
            this.btnSaveStrassen.Name = "btnSaveStrassen";
            this.btnSaveStrassen.Size = new System.Drawing.Size(85, 23);
            this.btnSaveStrassen.TabIndex = 2;
            this.btnSaveStrassen.Text = "Lưu kết quả";
            this.btnSaveStrassen.UseVisualStyleBackColor = true;
            this.btnSaveStrassen.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thời gian :";
            // 
            // btnExecuteStrassen
            // 
            this.btnExecuteStrassen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecuteStrassen.Enabled = false;
            this.btnExecuteStrassen.Location = new System.Drawing.Point(80, 51);
            this.btnExecuteStrassen.Name = "btnExecuteStrassen";
            this.btnExecuteStrassen.Size = new System.Drawing.Size(84, 23);
            this.btnExecuteStrassen.TabIndex = 1;
            this.btnExecuteStrassen.Text = "Thực hiện";
            this.btnExecuteStrassen.UseVisualStyleBackColor = true;
            this.btnExecuteStrassen.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtTimeStrassen
            // 
            this.txtTimeStrassen.Enabled = false;
            this.txtTimeStrassen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeStrassen.Location = new System.Drawing.Point(80, 24);
            this.txtTimeStrassen.Name = "txtTimeStrassen";
            this.txtTimeStrassen.ReadOnly = true;
            this.txtTimeStrassen.Size = new System.Drawing.Size(175, 21);
            this.txtTimeStrassen.TabIndex = 0;
            // 
            // groupResultNormal
            // 
            this.groupResultNormal.Controls.Add(this.btnSaveNormal);
            this.groupResultNormal.Controls.Add(this.btnExecuteNormal);
            this.groupResultNormal.Controls.Add(this.label4);
            this.groupResultNormal.Controls.Add(this.txtTimeNormal);
            this.groupResultNormal.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupResultNormal.Location = new System.Drawing.Point(0, 0);
            this.groupResultNormal.Name = "groupResultNormal";
            this.groupResultNormal.Size = new System.Drawing.Size(279, 88);
            this.groupResultNormal.TabIndex = 0;
            this.groupResultNormal.TabStop = false;
            this.groupResultNormal.Text = "Nhân thông thường";
            // 
            // btnSaveNormal
            // 
            this.btnSaveNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveNormal.Enabled = false;
            this.btnSaveNormal.Location = new System.Drawing.Point(170, 51);
            this.btnSaveNormal.Name = "btnSaveNormal";
            this.btnSaveNormal.Size = new System.Drawing.Size(85, 23);
            this.btnSaveNormal.TabIndex = 2;
            this.btnSaveNormal.Text = "Lưu kết quả";
            this.btnSaveNormal.UseVisualStyleBackColor = true;
            this.btnSaveNormal.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExecuteNormal
            // 
            this.btnExecuteNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecuteNormal.Enabled = false;
            this.btnExecuteNormal.Location = new System.Drawing.Point(80, 51);
            this.btnExecuteNormal.Name = "btnExecuteNormal";
            this.btnExecuteNormal.Size = new System.Drawing.Size(84, 23);
            this.btnExecuteNormal.TabIndex = 1;
            this.btnExecuteNormal.Text = "Thực hiện";
            this.btnExecuteNormal.UseVisualStyleBackColor = true;
            this.btnExecuteNormal.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thời gian :";
            // 
            // txtTimeNormal
            // 
            this.txtTimeNormal.Enabled = false;
            this.txtTimeNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeNormal.Location = new System.Drawing.Point(80, 24);
            this.txtTimeNormal.Name = "txtTimeNormal";
            this.txtTimeNormal.ReadOnly = true;
            this.txtTimeNormal.Size = new System.Drawing.Size(175, 21);
            this.txtTimeNormal.TabIndex = 0;
            // 
            // groupCreateMatrix
            // 
            this.groupCreateMatrix.Controls.Add(this.chkLimit);
            this.groupCreateMatrix.Controls.Add(this.txtColumn);
            this.groupCreateMatrix.Controls.Add(this.txtLimit);
            this.groupCreateMatrix.Controls.Add(this.txtRow);
            this.groupCreateMatrix.Controls.Add(this.btnCreateMatrix);
            this.groupCreateMatrix.Controls.Add(this.label3);
            this.groupCreateMatrix.Controls.Add(this.label6);
            this.groupCreateMatrix.Controls.Add(this.label5);
            this.groupCreateMatrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupCreateMatrix.Location = new System.Drawing.Point(10, 5);
            this.groupCreateMatrix.Name = "groupCreateMatrix";
            this.groupCreateMatrix.Size = new System.Drawing.Size(564, 61);
            this.groupCreateMatrix.TabIndex = 0;
            this.groupCreateMatrix.TabStop = false;
            this.groupCreateMatrix.Text = "Tạo ma trận";
            // 
            // chkLimit
            // 
            this.chkLimit.AutoSize = true;
            this.chkLimit.Checked = true;
            this.chkLimit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLimit.Location = new System.Drawing.Point(313, 27);
            this.chkLimit.Name = "chkLimit";
            this.chkLimit.Size = new System.Drawing.Size(111, 17);
            this.chkLimit.TabIndex = 2;
            this.chkLimit.Text = "Giới hạn giá trị 0-9";
            this.chkLimit.UseVisualStyleBackColor = true;
            // 
            // txtColumn
            // 
            this.txtColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumn.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.txtColumn.Location = new System.Drawing.Point(162, 24);
            this.txtColumn.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(53, 21);
            this.txtColumn.TabIndex = 1;
            this.txtColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtColumn.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // txtLimit
            // 
            this.txtLimit.Enabled = false;
            this.txtLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimit.Location = new System.Drawing.Point(308, 24);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.ReadOnly = true;
            this.txtLimit.Size = new System.Drawing.Size(125, 21);
            this.txtLimit.TabIndex = 0;
            this.txtLimit.TabStop = false;
            // 
            // txtRow
            // 
            this.txtRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRow.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.txtRow.Location = new System.Drawing.Point(83, 24);
            this.txtRow.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(53, 21);
            this.txtRow.TabIndex = 0;
            this.txtRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRow.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // btnCreateMatrix
            // 
            this.btnCreateMatrix.Location = new System.Drawing.Point(439, 23);
            this.btnCreateMatrix.Name = "btnCreateMatrix";
            this.btnCreateMatrix.Size = new System.Drawing.Size(110, 23);
            this.btnCreateMatrix.TabIndex = 1;
            this.btnCreateMatrix.Text = "Tạo ma trận";
            this.btnCreateMatrix.UseVisualStyleBackColor = true;
            this.btnCreateMatrix.Click += new System.EventHandler(this.btnCreateMatrix_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới hạn <10 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kích thước :";
            // 
            // brgWorker
            // 
            this.brgWorker.WorkerReportsProgress = true;
            this.brgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.brgWorker_DoWork);
            this.brgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.brgWorker_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 247);
            this.Controls.Add(this.groupMatrixMultiply);
            this.Controls.Add(this.groupCreateMatrix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân ma trận";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.groupMatrixMultiply.ResumeLayout(false);
            this.groupMatrixMultiply.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupResultStrassen.ResumeLayout(false);
            this.groupResultStrassen.PerformLayout();
            this.groupResultNormal.ResumeLayout(false);
            this.groupResultNormal.PerformLayout();
            this.groupCreateMatrix.ResumeLayout(false);
            this.groupCreateMatrix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatrix2FilePath;
        private System.Windows.Forms.Button btnSelectMatrix1File;
        private System.Windows.Forms.Button btnSelectMatrix2File;
        private System.Windows.Forms.TextBox txtMatrix1FilePath;
        private System.Windows.Forms.GroupBox groupMatrixMultiply;
        private System.Windows.Forms.GroupBox groupCreateMatrix;
        private System.Windows.Forms.Button btnCreateMatrix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtColumn;
        private System.Windows.Forms.NumericUpDown txtRow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkLimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Button btnExecuteNormal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupResultNormal;
        private System.Windows.Forms.GroupBox groupResultStrassen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimeNormal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimeStrassen;
        private System.Windows.Forms.Button btnSaveNormal;
        private System.Windows.Forms.Button btnSaveStrassen;
        private System.Windows.Forms.Button btnExecuteStrassen;
        private System.Windows.Forms.Button btnResetMatrix1File;
        private System.Windows.Forms.Button btnResetMatrix2File;
        private System.ComponentModel.BackgroundWorker brgWorker;
    }
}


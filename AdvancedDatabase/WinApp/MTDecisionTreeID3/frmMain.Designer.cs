
namespace MTDecisionTreeID3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridMain = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.cmdLoadData = new System.Windows.Forms.Button();
            this.ExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BrgWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRuleContent = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboDecisionColumn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdAnalysic = new System.Windows.Forms.Button();
            this.mainStatus = new System.Windows.Forms.StatusStrip();
            this.mnuTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mainStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridMain);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 539);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ liệu";
            // 
            // gridMain
            // 
            this.gridMain.AllowUserToAddRows = false;
            this.gridMain.AllowUserToDeleteRows = false;
            this.gridMain.AllowUserToResizeRows = false;
            this.gridMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(3, 56);
            this.gridMain.Name = "gridMain";
            this.gridMain.ReadOnly = true;
            this.gridMain.Size = new System.Drawing.Size(501, 480);
            this.gridMain.TabIndex = 0;
            this.gridMain.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridMain_RowPostPaint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDuongDan);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmdBrowse);
            this.panel2.Controls.Add(this.cmdLoadData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 40);
            this.panel2.TabIndex = 3;
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(71, 10);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.ReadOnly = true;
            this.txtDuongDan.Size = new System.Drawing.Size(248, 20);
            this.txtDuongDan.TabIndex = 0;
            this.txtDuongDan.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đường dẫn";
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBrowse.Location = new System.Drawing.Point(325, 9);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(60, 22);
            this.cmdBrowse.TabIndex = 1;
            this.cmdBrowse.Text = "Tìm";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // cmdLoadData
            // 
            this.cmdLoadData.Enabled = false;
            this.cmdLoadData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoadData.Location = new System.Drawing.Point(391, 9);
            this.cmdLoadData.Name = "cmdLoadData";
            this.cmdLoadData.Size = new System.Drawing.Size(100, 22);
            this.cmdLoadData.TabIndex = 2;
            this.cmdLoadData.Text = "Trích dữ liệu";
            this.cmdLoadData.UseVisualStyleBackColor = true;
            this.cmdLoadData.Click += new System.EventHandler(this.cmdLoadData_Click);
            // 
            // ExcelFileDialog
            // 
            this.ExcelFileDialog.DefaultExt = "Excel file|*.xls;*.xlsx";
            this.ExcelFileDialog.Filter = "Excel file|*.xls;*.xlsx";
            // 
            // BrgWorker
            // 
            this.BrgWorker.WorkerSupportsCancellation = true;
            this.BrgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BrgWorker_DoWork);
            this.BrgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BrgWorker_RunWorkerCompleted);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRuleContent);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(507, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 539);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // txtRuleContent
            // 
            this.txtRuleContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRuleContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRuleContent.Location = new System.Drawing.Point(3, 56);
            this.txtRuleContent.Name = "txtRuleContent";
            this.txtRuleContent.ReadOnly = true;
            this.txtRuleContent.Size = new System.Drawing.Size(371, 480);
            this.txtRuleContent.TabIndex = 3;
            this.txtRuleContent.Text = "";
            this.txtRuleContent.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboDecisionColumn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmdAnalysic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 40);
            this.panel1.TabIndex = 2;
            // 
            // cboDecisionColumn
            // 
            this.cboDecisionColumn.DisplayMember = "Name";
            this.cboDecisionColumn.Enabled = false;
            this.cboDecisionColumn.FormattingEnabled = true;
            this.cboDecisionColumn.Location = new System.Drawing.Point(90, 10);
            this.cboDecisionColumn.Name = "cboDecisionColumn";
            this.cboDecisionColumn.Size = new System.Drawing.Size(166, 21);
            this.cboDecisionColumn.TabIndex = 7;
            this.cboDecisionColumn.ValueMember = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cột quyết định";
            // 
            // cmdAnalysic
            // 
            this.cmdAnalysic.Enabled = false;
            this.cmdAnalysic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnalysic.Location = new System.Drawing.Point(262, 9);
            this.cmdAnalysic.Name = "cmdAnalysic";
            this.cmdAnalysic.Size = new System.Drawing.Size(100, 22);
            this.cmdAnalysic.TabIndex = 2;
            this.cmdAnalysic.Text = "Phân tích luật";
            this.cmdAnalysic.UseVisualStyleBackColor = true;
            this.cmdAnalysic.Click += new System.EventHandler(this.cmdAnalysic_Click);
            // 
            // mainStatus
            // 
            this.mainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTitle,
            this.toolStripStatusLabel3,
            this.mnuAuthor});
            this.mainStatus.Location = new System.Drawing.Point(0, 539);
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Size = new System.Drawing.Size(884, 22);
            this.mainStatus.TabIndex = 6;
            this.mainStatus.Text = "statusStrip1";
            // 
            // mnuTitle
            // 
            this.mnuTitle.Name = "mnuTitle";
            this.mnuTitle.Size = new System.Drawing.Size(202, 17);
            this.mnuTitle.Text = "Tìm hiểu và Ứng dụng thuật toán ID3";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(195, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // mnuAuthor
            // 
            this.mnuAuthor.Name = "mnuAuthor";
            this.mnuAuthor.Size = new System.Drawing.Size(441, 17);
            this.mnuAuthor.Text = "Tác giả: Phạm Minh Tuấn, Võ Đình Hiếu, Nguyễn Anh Quân, Phạm Thị Thanh Thúy";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuật toán ID3";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainStatus.ResumeLayout(false);
            this.mainStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdLoadData;
        private System.Windows.Forms.OpenFileDialog ExcelFileDialog;
        private System.ComponentModel.BackgroundWorker BrgWorker;
        private System.Windows.Forms.DataGridView gridMain;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboDecisionColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdAnalysic;
        private System.Windows.Forms.RichTextBox txtRuleContent;
        private System.Windows.Forms.StatusStrip mainStatus;
        private System.Windows.Forms.ToolStripStatusLabel mnuTitle;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel mnuAuthor;
    }
}


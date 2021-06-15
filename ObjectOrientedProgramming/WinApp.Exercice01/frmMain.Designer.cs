
namespace Exercice01
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridMain = new System.Windows.Forms.DataGridView();
            this.AntName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AntHealth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AntDead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdAttack = new System.Windows.Forms.Button();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridMain);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ant List";
            // 
            // gridMain
            // 
            this.gridMain.AllowUserToAddRows = false;
            this.gridMain.AllowUserToDeleteRows = false;
            this.gridMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AntName,
            this.AntHealth,
            this.AntDead});
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(3, 16);
            this.gridMain.Name = "gridMain";
            this.gridMain.ReadOnly = true;
            this.gridMain.Size = new System.Drawing.Size(344, 247);
            this.gridMain.TabIndex = 0;
            this.gridMain.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridMain_RowPostPaint);
            // 
            // AntName
            // 
            this.AntName.DataPropertyName = "Name";
            this.AntName.HeaderText = "Name";
            this.AntName.Name = "AntName";
            this.AntName.ReadOnly = true;
            // 
            // AntHealth
            // 
            this.AntHealth.DataPropertyName = "Health";
            this.AntHealth.HeaderText = "Health";
            this.AntHealth.Name = "AntHealth";
            this.AntHealth.ReadOnly = true;
            // 
            // AntDead
            // 
            this.AntDead.DataPropertyName = "Dead";
            this.AntDead.HeaderText = "Dead";
            this.AntDead.Name = "AntDead";
            this.AntDead.ReadOnly = true;
            this.AntDead.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdAttack);
            this.panel1.Controls.Add(this.cmdCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 35);
            this.panel1.TabIndex = 1;
            // 
            // cmdAttack
            // 
            this.cmdAttack.Location = new System.Drawing.Point(178, 6);
            this.cmdAttack.Name = "cmdAttack";
            this.cmdAttack.Size = new System.Drawing.Size(160, 23);
            this.cmdAttack.TabIndex = 0;
            this.cmdAttack.Text = "Attack Ants";
            this.cmdAttack.UseVisualStyleBackColor = true;
            this.cmdAttack.Click += new System.EventHandler(this.cmdAttack_Click);
            // 
            // cmdCreate
            // 
            this.cmdCreate.Location = new System.Drawing.Point(12, 6);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(160, 23);
            this.cmdCreate.TabIndex = 0;
            this.cmdCreate.Text = "Create Ant List";
            this.cmdCreate.UseVisualStyleBackColor = true;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercice01 - Phạm Minh Tuấn, K22MCS";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.Button cmdAttack;
        private System.Windows.Forms.DataGridView gridMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn AntName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AntHealth;
        private System.Windows.Forms.DataGridViewTextBoxColumn AntDead;
    }
}


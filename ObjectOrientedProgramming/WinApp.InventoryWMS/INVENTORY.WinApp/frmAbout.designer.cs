namespace INVENTORY.WinApp
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.GroupInfor = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.cmdDong = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupInfor)).BeginInit();
            this.GroupInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupInfor
            // 
            this.GroupInfor.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupInfor.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.GroupInfor.AppearanceCaption.Options.UseFont = true;
            this.GroupInfor.Controls.Add(this.cmdDong);
            this.GroupInfor.Controls.Add(this.labelControl2);
            this.GroupInfor.Controls.Add(this.memoEdit1);
            this.GroupInfor.Controls.Add(this.labelControl1);
            this.GroupInfor.Controls.Add(this.pictureEdit1);
            this.GroupInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupInfor.Location = new System.Drawing.Point(0, 0);
            this.GroupInfor.LookAndFeel.SkinName = "Blue";
            this.GroupInfor.Name = "GroupInfor";
            this.GroupInfor.Size = new System.Drawing.Size(463, 341);
            this.GroupInfor.TabIndex = 1;
            this.GroupInfor.Text = "Giới thiệu";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(196, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(227, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Inventory WMS";
            // 
            // memoEdit1
            // 
            this.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue");
            this.memoEdit1.Location = new System.Drawing.Point(182, 68);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.memoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.memoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.memoEdit1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoEdit1.Size = new System.Drawing.Size(272, 230);
            this.memoEdit1.TabIndex = 2;
            this.memoEdit1.TabStop = false;
            this.memoEdit1.UseOptimizedRendering = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(182, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(269, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Inventory Warehouse Management System";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = global::INVENTORY.WinApp.Properties.Resources.LogoProduct;
            this.pictureEdit1.Location = new System.Drawing.Point(2, 21);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(162, 318);
            this.pictureEdit1.TabIndex = 0;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // cmdDong
            // 
            this.cmdDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDong.Location = new System.Drawing.Point(380, 304);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.Size = new System.Drawing.Size(74, 20);
            this.cmdDong.TabIndex = 4;
            this.cmdDong.Text = "Đóng";
            this.cmdDong.Click += new System.EventHandler(this.cmdDong_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 341);
            this.Controls.Add(this.GroupInfor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAbout";
            ((System.ComponentModel.ISupportInitialize)(this.GroupInfor)).EndInit();
            this.GroupInfor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GroupInfor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton cmdDong;
    }
}
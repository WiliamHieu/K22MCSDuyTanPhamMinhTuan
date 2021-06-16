namespace INVENTORY.WinApp
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.GroupInfor = new DevExpress.XtraEditors.GroupControl();
            this.PanelError = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmdDong = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.cmdExit = new DevExpress.XtraEditors.SimpleButton();
            this.chkRemember = new DevExpress.XtraEditors.CheckEdit();
            this.cmdLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblSecurityCode = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.cboServer = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSupport = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupInfor)).BeginInit();
            this.GroupInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelError)).BeginInit();
            this.PanelError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRemember.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "unlocked.ico");
            this.imageCollection1.Images.SetKeyName(1, "close.png");
            // 
            // GroupInfor
            // 
            this.GroupInfor.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupInfor.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.GroupInfor.AppearanceCaption.Options.UseFont = true;
            this.GroupInfor.Controls.Add(this.PanelError);
            this.GroupInfor.Controls.Add(this.txtUsername);
            this.GroupInfor.Controls.Add(this.cmdExit);
            this.GroupInfor.Controls.Add(this.chkRemember);
            this.GroupInfor.Controls.Add(this.cmdLogin);
            this.GroupInfor.Controls.Add(this.labelControl6);
            this.GroupInfor.Controls.Add(this.lblSecurityCode);
            this.GroupInfor.Controls.Add(this.labelControl1);
            this.GroupInfor.Controls.Add(this.labelControl2);
            this.GroupInfor.Controls.Add(this.txtPassword);
            this.GroupInfor.Controls.Add(this.cboServer);
            this.GroupInfor.Controls.Add(this.lblSupport);
            this.GroupInfor.Controls.Add(this.labelControl3);
            this.GroupInfor.Controls.Add(this.pictureEdit1);
            this.GroupInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupInfor.Location = new System.Drawing.Point(0, 0);
            this.GroupInfor.LookAndFeel.SkinName = "Blue";
            this.GroupInfor.Name = "GroupInfor";
            this.GroupInfor.Size = new System.Drawing.Size(463, 224);
            this.GroupInfor.TabIndex = 0;
            this.GroupInfor.Text = "Inventory WMS";
            // 
            // PanelError
            // 
            this.PanelError.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelError.Controls.Add(this.labelControl5);
            this.PanelError.Controls.Add(this.cmdDong);
            this.PanelError.Controls.Add(this.labelControl4);
            this.PanelError.Location = new System.Drawing.Point(12, 24);
            this.PanelError.Name = "PanelError";
            this.PanelError.Size = new System.Drawing.Size(439, 167);
            this.PanelError.TabIndex = 7;
            this.PanelError.Visible = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(85, 61);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(294, 45);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Hệ thống không thể kết nối được máy chủ, xin vui lòng liên hệ quản trị để xử lý";
            // 
            // cmdDong
            // 
            this.cmdDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdDong.ImageIndex = 1;
            this.cmdDong.ImageList = this.imageCollection1;
            this.cmdDong.Location = new System.Drawing.Point(181, 115);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.Size = new System.Drawing.Size(91, 20);
            this.cmdDong.TabIndex = 4;
            this.cmdDong.Text = "Thoát  ";
            this.cmdDong.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(168, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(132, 23);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "THÔNG BÁO LỖI";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(264, 80);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtUsername.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtUsername.Properties.MaxLength = 50;
            this.txtUsername.Size = new System.Drawing.Size(160, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // cmdExit
            // 
            this.cmdExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdExit.ImageIndex = 1;
            this.cmdExit.ImageList = this.imageCollection1;
            this.cmdExit.Location = new System.Drawing.Point(334, 157);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(90, 20);
            this.cmdExit.TabIndex = 6;
            this.cmdExit.Text = "Thoát  ";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // chkRemember
            // 
            this.chkRemember.Location = new System.Drawing.Point(262, 132);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Properties.Caption = "Ghi nhớ thông tin";
            this.chkRemember.Size = new System.Drawing.Size(162, 19);
            this.chkRemember.TabIndex = 4;
            // 
            // cmdLogin
            // 
            this.cmdLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLogin.ImageIndex = 0;
            this.cmdLogin.ImageList = this.imageCollection1;
            this.cmdLogin.Location = new System.Drawing.Point(238, 157);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(90, 20);
            this.cmdLogin.TabIndex = 5;
            this.cmdLogin.Text = "Đăng nhập";
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(187, 57);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Máy chủ";
            // 
            // lblSecurityCode
            // 
            this.lblSecurityCode.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSecurityCode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSecurityCode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSecurityCode.Location = new System.Drawing.Point(24, 170);
            this.lblSecurityCode.Name = "lblSecurityCode";
            this.lblSecurityCode.Size = new System.Drawing.Size(141, 19);
            this.lblSecurityCode.TabIndex = 11;
            this.lblSecurityCode.Text = "SecurityCode";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(187, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Tên truy cập";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(187, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(264, 106);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtPassword.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPassword.Properties.MaxLength = 50;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(160, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // cboServer
            // 
            this.cboServer.Location = new System.Drawing.Point(264, 54);
            this.cboServer.Name = "cboServer";
            this.cboServer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboServer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên")});
            this.cboServer.Properties.DisplayMember = "Ten";
            this.cboServer.Properties.DropDownRows = 3;
            this.cboServer.Properties.ImmediatePopup = true;
            this.cboServer.Properties.NullText = "-- Máy chủ --";
            this.cboServer.Properties.PopupFormMinSize = new System.Drawing.Size(138, 0);
            this.cboServer.Properties.PopupWidth = 138;
            this.cboServer.Properties.ShowFooter = false;
            this.cboServer.Properties.ShowHeader = false;
            this.cboServer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboServer.Properties.ValueMember = "Id";
            this.cboServer.Size = new System.Drawing.Size(160, 20);
            this.cboServer.TabIndex = 0;
            // 
            // lblSupport
            // 
            this.lblSupport.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblSupport.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSupport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSupport.Location = new System.Drawing.Point(366, 197);
            this.lblSupport.Name = "lblSupport";
            this.lblSupport.Size = new System.Drawing.Size(91, 19);
            this.lblSupport.TabIndex = 6;
            this.lblSupport.Text = "Hỗ trợ Trực tuyến";
            this.lblSupport.ToolTip = "Kích vào để Mở ứng dụng hỗ trợ trực tuyến";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 195);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(348, 23);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Thiết kế và Phát triển bởi MTSoftware";
            this.labelControl3.ToolTip = "Kích vào đây để Cập nhật phiên bản mới";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::INVENTORY.WinApp.Properties.Resources.login_icon;
            this.pictureEdit1.Location = new System.Drawing.Point(24, 38);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(141, 132);
            this.pictureEdit1.TabIndex = 5;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 224);
            this.Controls.Add(this.GroupInfor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupInfor)).EndInit();
            this.GroupInfor.ResumeLayout(false);
            this.GroupInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelError)).EndInit();
            this.PanelError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRemember.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.GroupControl GroupInfor;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl PanelError;
        private DevExpress.XtraEditors.SimpleButton cmdDong;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.SimpleButton cmdExit;
        private DevExpress.XtraEditors.CheckEdit chkRemember;
        private DevExpress.XtraEditors.SimpleButton cmdLogin;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LookUpEdit cboServer;
        private DevExpress.XtraEditors.LabelControl lblSupport;
        private DevExpress.XtraEditors.LabelControl lblSecurityCode;
    }
}
namespace INVENTORY.WinApp.HETHONG
{
    partial class frmVaiTroAdd
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
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkTrangThai = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.txtThuTu = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtChuThich = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ToolbarDm = new INVENTORY.CONTROL.ToolbarDm();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThuTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.EditValue = "";
            this.txtTen.EnterMoveNextControl = true;
            this.txtTen.Location = new System.Drawing.Point(70, 30);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.MaxLength = 100;
            this.txtTen.Size = new System.Drawing.Size(280, 20);
            this.txtTen.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkTrangThai);
            this.groupControl1.Controls.Add(this.txtThuTu);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtChuThich);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(384, 139);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkTrangThai.Appearance.Options.UseForeColor = true;
            this.chkTrangThai.CheckOnClick = true;
            this.chkTrangThai.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Standard;
            this.chkTrangThai.HorizontalScrollbar = true;
            this.chkTrangThai.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(true, "Đánh dấu nếu còn sử dụng", System.Windows.Forms.CheckState.Checked)});
            this.chkTrangThai.Location = new System.Drawing.Point(70, 108);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(280, 20);
            this.chkTrangThai.TabIndex = 3;
            this.chkTrangThai.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(this.chkTrangThai_DrawItem);
            // 
            // txtThuTu
            // 
            this.txtThuTu.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtThuTu.EnterMoveNextControl = true;
            this.txtThuTu.Location = new System.Drawing.Point(70, 56);
            this.txtThuTu.Name = "txtThuTu";
            this.txtThuTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtThuTu.Properties.IsFloatValue = false;
            this.txtThuTu.Properties.Mask.EditMask = "N00";
            this.txtThuTu.Size = new System.Drawing.Size(280, 20);
            this.txtThuTu.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Thứ tự";
            // 
            // txtChuThich
            // 
            this.txtChuThich.EditValue = "";
            this.txtChuThich.EnterMoveNextControl = true;
            this.txtChuThich.Location = new System.Drawing.Point(70, 82);
            this.txtChuThich.Name = "txtChuThich";
            this.txtChuThich.Properties.MaxLength = 100;
            this.txtChuThich.Size = new System.Drawing.Size(280, 20);
            this.txtChuThich.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Trạng thái";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Chú thích";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Tên (*)";
            // 
            // ToolbarDm
            // 
            this.ToolbarDm.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarDm.Appearance.Options.UseBackColor = true;
            this.ToolbarDm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolbarDm.Location = new System.Drawing.Point(0, 139);
            this.ToolbarDm.Name = "ToolbarDm";
            this.ToolbarDm.SenderName = INVENTORY.CONTROL.ToolbarDm.Action.None;
            this.ToolbarDm.Size = new System.Drawing.Size(384, 28);
            this.ToolbarDm.TabIndex = 1;
            this.ToolbarDm.Clicked += new System.EventHandler(this.ToolbarDm_Clicked);
            // 
            // frmVaiTroAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 167);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ToolbarDm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVaiTroAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật Vai trò";
            this.Load += new System.EventHandler(this.frmVaiTroAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThuTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtChuThich;
        private DevExpress.XtraEditors.SpinEdit txtThuTu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckedListBoxControl chkTrangThai;
        private INVENTORY.CONTROL.ToolbarDm ToolbarDm;
    }
}
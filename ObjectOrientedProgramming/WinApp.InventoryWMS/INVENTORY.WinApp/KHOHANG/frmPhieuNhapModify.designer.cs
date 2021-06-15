namespace INVENTORY.WinApp.KHOHANG
{
    partial class frmPhieuNhapModify
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboLoaiVatTu = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cboLoaiVatTuView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chkLoaiVatTu = new DevExpress.XtraEditors.CheckEdit();
            this.chkChuThich = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtChuThich = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboLoaiVatTu_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboLoaiVatTu_QuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboLoaiVatTu_TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToolbarLd = new INVENTORY.CONTROL.ToolbarLd();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatTuView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLoaiVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkChuThich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cboLoaiVatTu);
            this.groupControl1.Controls.Add(this.chkLoaiVatTu);
            this.groupControl1.Controls.Add(this.chkChuThich);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.txtChuThich);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(484, 87);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // cboLoaiVatTu
            // 
            this.cboLoaiVatTu.EnterMoveNextControl = true;
            this.cboLoaiVatTu.Location = new System.Drawing.Point(70, 30);
            this.cboLoaiVatTu.Name = "cboLoaiVatTu";
            this.cboLoaiVatTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiVatTu.Properties.ImmediatePopup = true;
            this.cboLoaiVatTu.Properties.NullText = " -- Loại vật tư --";
            this.cboLoaiVatTu.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboLoaiVatTu.Properties.PopupFormMinSize = new System.Drawing.Size(586, 0);
            this.cboLoaiVatTu.Properties.PopupFormSize = new System.Drawing.Size(586, 0);
            this.cboLoaiVatTu.Properties.ShowFooter = false;
            this.cboLoaiVatTu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboLoaiVatTu.Properties.ValidateOnEnterKey = true;
            this.cboLoaiVatTu.Properties.View = this.cboLoaiVatTuView;
            this.cboLoaiVatTu.Size = new System.Drawing.Size(330, 20);
            this.cboLoaiVatTu.TabIndex = 0;
            this.cboLoaiVatTu.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.cboLoaiVatTu_CloseUp);
            // 
            // cboLoaiVatTuView
            // 
            this.cboLoaiVatTuView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cboLoaiVatTuView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cboLoaiVatTu_Ten,
            this.cboLoaiVatTu_QuyCach,
            this.cboLoaiVatTu_TenDonViTinh});
            this.cboLoaiVatTuView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboLoaiVatTuView.FooterPanelHeight = 5;
            this.cboLoaiVatTuView.IndicatorWidth = 10;
            this.cboLoaiVatTuView.Name = "cboLoaiVatTuView";
            this.cboLoaiVatTuView.OptionsBehavior.Editable = false;
            this.cboLoaiVatTuView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboLoaiVatTuView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboLoaiVatTuView.OptionsView.ShowDetailButtons = false;
            this.cboLoaiVatTuView.OptionsView.ShowGroupPanel = false;
            // 
            // chkLoaiVatTu
            // 
            this.chkLoaiVatTu.Location = new System.Drawing.Point(406, 30);
            this.chkLoaiVatTu.Name = "chkLoaiVatTu";
            this.chkLoaiVatTu.Properties.Caption = "Thay đổi";
            this.chkLoaiVatTu.Size = new System.Drawing.Size(66, 19);
            this.chkLoaiVatTu.TabIndex = 1;
            this.chkLoaiVatTu.CheckedChanged += new System.EventHandler(this.chkLoaiVatTu_CheckedChanged);
            // 
            // chkChuThich
            // 
            this.chkChuThich.Location = new System.Drawing.Point(406, 56);
            this.chkChuThich.Name = "chkChuThich";
            this.chkChuThich.Properties.Caption = "Thay đổi";
            this.chkChuThich.Size = new System.Drawing.Size(66, 19);
            this.chkChuThich.TabIndex = 3;
            this.chkChuThich.CheckedChanged += new System.EventHandler(this.chkChuThich_CheckedChanged);
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(19, 59);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(45, 13);
            this.labelControl14.TabIndex = 33;
            this.labelControl14.Text = "Chú thích";
            // 
            // txtChuThich
            // 
            this.txtChuThich.Location = new System.Drawing.Point(70, 56);
            this.txtChuThich.Name = "txtChuThich";
            this.txtChuThich.Size = new System.Drawing.Size(330, 20);
            this.txtChuThich.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Loại vật tư";
            // 
            // cboLoaiVatTu_Ten
            // 
            this.cboLoaiVatTu_Ten.Caption = "Tên";
            this.cboLoaiVatTu_Ten.FieldName = "Ten";
            this.cboLoaiVatTu_Ten.Name = "cboLoaiVatTu_Ten";
            this.cboLoaiVatTu_Ten.OptionsFilter.AllowFilter = false;
            this.cboLoaiVatTu_Ten.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.cboLoaiVatTu_Ten.Visible = true;
            this.cboLoaiVatTu_Ten.VisibleIndex = 0;
            this.cboLoaiVatTu_Ten.Width = 213;
            // 
            // cboLoaiVatTu_QuyCach
            // 
            this.cboLoaiVatTu_QuyCach.Caption = "Quy cách";
            this.cboLoaiVatTu_QuyCach.FieldName = "QuyCach";
            this.cboLoaiVatTu_QuyCach.Name = "cboLoaiVatTu_QuyCach";
            this.cboLoaiVatTu_QuyCach.OptionsColumn.FixedWidth = true;
            this.cboLoaiVatTu_QuyCach.OptionsFilter.AllowFilter = false;
            this.cboLoaiVatTu_QuyCach.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.cboLoaiVatTu_QuyCach.Visible = true;
            this.cboLoaiVatTu_QuyCach.VisibleIndex = 1;
            this.cboLoaiVatTu_QuyCach.Width = 200;
            // 
            // cboLoaiVatTu_TenDonViTinh
            // 
            this.cboLoaiVatTu_TenDonViTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.cboLoaiVatTu_TenDonViTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cboLoaiVatTu_TenDonViTinh.Caption = "ĐVT";
            this.cboLoaiVatTu_TenDonViTinh.FieldName = "TenDonViTinh";
            this.cboLoaiVatTu_TenDonViTinh.Name = "cboLoaiVatTu_TenDonViTinh";
            this.cboLoaiVatTu_TenDonViTinh.OptionsColumn.FixedWidth = true;
            this.cboLoaiVatTu_TenDonViTinh.OptionsFilter.AllowFilter = false;
            this.cboLoaiVatTu_TenDonViTinh.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.cboLoaiVatTu_TenDonViTinh.Visible = true;
            this.cboLoaiVatTu_TenDonViTinh.VisibleIndex = 2;
            this.cboLoaiVatTu_TenDonViTinh.Width = 50;
            // 
            // ToolbarLd
            // 
            this.ToolbarLd.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarLd.Appearance.Options.UseBackColor = true;
            this.ToolbarLd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolbarLd.Location = new System.Drawing.Point(0, 87);
            this.ToolbarLd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ToolbarLd.Name = "ToolbarLd";
            this.ToolbarLd.SenderName = INVENTORY.CONTROL.ToolbarLd.Action.None;
            this.ToolbarLd.Size = new System.Drawing.Size(484, 28);
            this.ToolbarLd.TabIndex = 1;
            this.ToolbarLd.Clicked += new System.EventHandler(this.ToolbarLd_Clicked);
            // 
            // frmPhieuNhapModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 115);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ToolbarLd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhieuNhapModify";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thay đổi Thông tin";
            this.Load += new System.EventHandler(this.frmPhieuNhapModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVatTuView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLoaiVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkChuThich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtChuThich;
        private DevExpress.XtraEditors.CheckEdit chkChuThich;
        private INVENTORY.CONTROL.ToolbarLd ToolbarLd;
        private DevExpress.XtraEditors.CheckEdit chkLoaiVatTu;
        private DevExpress.XtraEditors.GridLookUpEdit cboLoaiVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView cboLoaiVatTuView;
        private DevExpress.XtraGrid.Columns.GridColumn cboLoaiVatTu_Ten;
        private DevExpress.XtraGrid.Columns.GridColumn cboLoaiVatTu_QuyCach;
        private DevExpress.XtraGrid.Columns.GridColumn cboLoaiVatTu_TenDonViTinh;
    }
}
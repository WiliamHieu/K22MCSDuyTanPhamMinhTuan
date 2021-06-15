namespace INVENTORY.WinApp.DANHMUC
{
    partial class frmLoaiVatTuAdd
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cboNhomVatTu = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cboNhomVatTuView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboNhomVatTu_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboDonViTinh = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cboDonViTinhView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboDonViTinh_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkTrangThai = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuyCach = new DevExpress.XtraEditors.TextEdit();
            this.txtChuThich = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ToolbarDm = new INVENTORY.CONTROL.ToolbarDm();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhomVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhomVatTuView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDonViTinhView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuyCach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.cboNhomVatTu);
            this.groupControl1.Controls.Add(this.cboDonViTinh);
            this.groupControl1.Controls.Add(this.chkTrangThai);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtQuyCach);
            this.groupControl1.Controls.Add(this.txtChuThich);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(384, 191);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Nhóm (*)";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 85);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 13);
            this.labelControl8.TabIndex = 26;
            this.labelControl8.Text = "Đơn vị (*)";
            // 
            // cboNhomVatTu
            // 
            this.cboNhomVatTu.EnterMoveNextControl = true;
            this.cboNhomVatTu.Location = new System.Drawing.Point(67, 30);
            this.cboNhomVatTu.Name = "cboNhomVatTu";
            this.cboNhomVatTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNhomVatTu.Properties.ImmediatePopup = true;
            this.cboNhomVatTu.Properties.NullText = " -- Nhóm vật tư --";
            this.cboNhomVatTu.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboNhomVatTu.Properties.PopupFormMinSize = new System.Drawing.Size(276, 0);
            this.cboNhomVatTu.Properties.PopupFormSize = new System.Drawing.Size(276, 0);
            this.cboNhomVatTu.Properties.ShowFooter = false;
            this.cboNhomVatTu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboNhomVatTu.Properties.ValidateOnEnterKey = true;
            this.cboNhomVatTu.Properties.View = this.cboNhomVatTuView;
            this.cboNhomVatTu.Size = new System.Drawing.Size(280, 20);
            this.cboNhomVatTu.TabIndex = 0;
            // 
            // cboNhomVatTuView
            // 
            this.cboNhomVatTuView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cboNhomVatTuView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cboNhomVatTu_Ten});
            this.cboNhomVatTuView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboNhomVatTuView.FooterPanelHeight = 5;
            this.cboNhomVatTuView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Ten", this.cboNhomVatTu_Ten, "Tổng cộng: {0} loại vật tư")});
            this.cboNhomVatTuView.IndicatorWidth = 10;
            this.cboNhomVatTuView.Name = "cboNhomVatTuView";
            this.cboNhomVatTuView.OptionsBehavior.Editable = false;
            this.cboNhomVatTuView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboNhomVatTuView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboNhomVatTuView.OptionsView.ShowColumnHeaders = false;
            this.cboNhomVatTuView.OptionsView.ShowGroupPanel = false;
            this.cboNhomVatTuView.OptionsView.ShowIndicator = false;
            // 
            // cboNhomVatTu_Ten
            // 
            this.cboNhomVatTu_Ten.Caption = "Tên";
            this.cboNhomVatTu_Ten.FieldName = "Ten";
            this.cboNhomVatTu_Ten.Name = "cboNhomVatTu_Ten";
            this.cboNhomVatTu_Ten.OptionsFilter.AllowFilter = false;
            this.cboNhomVatTu_Ten.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.cboNhomVatTu_Ten.Visible = true;
            this.cboNhomVatTu_Ten.VisibleIndex = 0;
            this.cboNhomVatTu_Ten.Width = 220;
            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.EnterMoveNextControl = true;
            this.cboDonViTinh.Location = new System.Drawing.Point(67, 82);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDonViTinh.Properties.ImmediatePopup = true;
            this.cboDonViTinh.Properties.NullText = " -- Đơn vị tính --";
            this.cboDonViTinh.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboDonViTinh.Properties.PopupFormMinSize = new System.Drawing.Size(276, 0);
            this.cboDonViTinh.Properties.PopupFormSize = new System.Drawing.Size(276, 0);
            this.cboDonViTinh.Properties.ShowFooter = false;
            this.cboDonViTinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboDonViTinh.Properties.ValidateOnEnterKey = true;
            this.cboDonViTinh.Properties.View = this.cboDonViTinhView;
            this.cboDonViTinh.Size = new System.Drawing.Size(280, 20);
            this.cboDonViTinh.TabIndex = 2;
            // 
            // cboDonViTinhView
            // 
            this.cboDonViTinhView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cboDonViTinhView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cboDonViTinh_Ten});
            this.cboDonViTinhView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboDonViTinhView.FooterPanelHeight = 5;
            this.cboDonViTinhView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Ten", this.cboDonViTinh_Ten, "Tổng cộng: {0} loại vật tư")});
            this.cboDonViTinhView.IndicatorWidth = 10;
            this.cboDonViTinhView.Name = "cboDonViTinhView";
            this.cboDonViTinhView.OptionsBehavior.Editable = false;
            this.cboDonViTinhView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboDonViTinhView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboDonViTinhView.OptionsView.ShowColumnHeaders = false;
            this.cboDonViTinhView.OptionsView.ShowGroupPanel = false;
            this.cboDonViTinhView.OptionsView.ShowIndicator = false;
            // 
            // cboDonViTinh_Ten
            // 
            this.cboDonViTinh_Ten.Caption = "Tên";
            this.cboDonViTinh_Ten.FieldName = "Ten";
            this.cboDonViTinh_Ten.Name = "cboDonViTinh_Ten";
            this.cboDonViTinh_Ten.OptionsFilter.AllowFilter = false;
            this.cboDonViTinh_Ten.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.cboDonViTinh_Ten.Visible = true;
            this.cboDonViTinh_Ten.VisibleIndex = 0;
            this.cboDonViTinh_Ten.Width = 220;
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.EditValue = true;
            this.chkTrangThai.EnterMoveNextControl = true;
            this.chkTrangThai.Location = new System.Drawing.Point(67, 160);
            this.chkTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.chkTrangThai.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(222)))));
            this.chkTrangThai.Properties.Appearance.Options.UseBackColor = true;
            this.chkTrangThai.Properties.Appearance.Options.UseBorderColor = true;
            this.chkTrangThai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.chkTrangThai.Properties.Caption = "Đánh dấu nếu còn sử dụng";
            this.chkTrangThai.Size = new System.Drawing.Size(280, 21);
            this.chkTrangThai.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 164);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Trạng thái";
            // 
            // txtQuyCach
            // 
            this.txtQuyCach.EditValue = "";
            this.txtQuyCach.EnterMoveNextControl = true;
            this.txtQuyCach.Location = new System.Drawing.Point(67, 108);
            this.txtQuyCach.Name = "txtQuyCach";
            this.txtQuyCach.Properties.MaxLength = 300;
            this.txtQuyCach.Size = new System.Drawing.Size(280, 20);
            this.txtQuyCach.TabIndex = 3;
            // 
            // txtChuThich
            // 
            this.txtChuThich.EditValue = "";
            this.txtChuThich.EnterMoveNextControl = true;
            this.txtChuThich.Location = new System.Drawing.Point(67, 134);
            this.txtChuThich.Name = "txtChuThich";
            this.txtChuThich.Properties.MaxLength = 300;
            this.txtChuThich.Size = new System.Drawing.Size(280, 20);
            this.txtChuThich.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 111);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Quy cách";
            // 
            // txtTen
            // 
            this.txtTen.EnterMoveNextControl = true;
            this.txtTen.Location = new System.Drawing.Point(67, 56);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(280, 20);
            this.txtTen.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 137);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Chú thích";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên (*)";
            // 
            // ToolbarDm
            // 
            this.ToolbarDm.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarDm.Appearance.Options.UseBackColor = true;
            this.ToolbarDm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolbarDm.Location = new System.Drawing.Point(0, 191);
            this.ToolbarDm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ToolbarDm.Name = "ToolbarDm";
            this.ToolbarDm.SenderName = INVENTORY.CONTROL.ToolbarDm.Action.None;
            this.ToolbarDm.Size = new System.Drawing.Size(384, 28);
            this.ToolbarDm.TabIndex = 2;
            this.ToolbarDm.Clicked += new System.EventHandler(this.ToolbarDm_Clicked);
            // 
            // frmLoaiVatTuAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 219);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ToolbarDm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoaiVatTuAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật Loại vật tư";
            this.Load += new System.EventHandler(this.frmLoaiVatTuAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhomVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhomVatTuView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDonViTinhView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuyCach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuThich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtChuThich;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private INVENTORY.CONTROL.ToolbarDm ToolbarDm;
        private DevExpress.XtraEditors.CheckEdit chkTrangThai;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.GridLookUpEdit cboNhomVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView cboNhomVatTuView;
        private DevExpress.XtraGrid.Columns.GridColumn cboNhomVatTu_Ten;
        private DevExpress.XtraEditors.GridLookUpEdit cboDonViTinh;
        private DevExpress.XtraGrid.Views.Grid.GridView cboDonViTinhView;
        private DevExpress.XtraGrid.Columns.GridColumn cboDonViTinh_Ten;
        private DevExpress.XtraEditors.TextEdit txtQuyCach;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
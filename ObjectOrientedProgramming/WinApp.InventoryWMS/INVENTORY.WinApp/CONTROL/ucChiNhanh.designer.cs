namespace INVENTORY.WinApp.CONTROL
{
    partial class ucChiNhanh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChiNhanh));
            this.TreeMain = new DevExpress.XtraTreeList.TreeList();
            this.TreeMain_Id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.TreeMain_Ten = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ImageCollection16 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TreeMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection16)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeMain
            // 
            this.TreeMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TreeMain.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.TreeMain_Id,
            this.TreeMain_Ten});
            this.TreeMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeMain.ImageIndexFieldName = "-1";
            this.TreeMain.Location = new System.Drawing.Point(0, 5);
            this.TreeMain.Name = "TreeMain";
            this.TreeMain.OptionsBehavior.AutoChangeParent = false;
            this.TreeMain.OptionsBehavior.AutoNodeHeight = false;
            this.TreeMain.OptionsBehavior.AutoSelectAllInEditor = false;
            this.TreeMain.OptionsBehavior.Editable = false;
            this.TreeMain.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.TreeMain.OptionsView.ShowColumns = false;
            this.TreeMain.OptionsView.ShowHorzLines = false;
            this.TreeMain.OptionsView.ShowIndicator = false;
            this.TreeMain.OptionsView.ShowVertLines = false;
            this.TreeMain.RowHeight = 20;
            this.TreeMain.SelectImageList = this.ImageCollection16;
            this.TreeMain.Size = new System.Drawing.Size(427, 588);
            this.TreeMain.TabIndex = 1;
            this.TreeMain.GetSelectImage += new DevExpress.XtraTreeList.GetSelectImageEventHandler(this.TreeMain_GetSelectImage);
            this.TreeMain.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.TreeMain_FocusedNodeChanged);
            // 
            // TreeMain_Id
            // 
            this.TreeMain_Id.Caption = "Id";
            this.TreeMain_Id.FieldName = "Id";
            this.TreeMain_Id.Name = "TreeMain_Id";
            // 
            // TreeMain_Ten
            // 
            this.TreeMain_Ten.Caption = "Tên";
            this.TreeMain_Ten.FieldName = "Ten";
            this.TreeMain_Ten.MinWidth = 35;
            this.TreeMain_Ten.Name = "TreeMain_Ten";
            this.TreeMain_Ten.OptionsColumn.AllowSort = false;
            this.TreeMain_Ten.Visible = true;
            this.TreeMain_Ten.VisibleIndex = 0;
            this.TreeMain_Ten.Width = 156;
            // 
            // ImageCollection16
            // 
            this.ImageCollection16.ImageSize = new System.Drawing.Size(18, 18);
            this.ImageCollection16.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImageCollection16.ImageStream")));
            this.ImageCollection16.Images.SetKeyName(0, "home.ico");
            this.ImageCollection16.Images.SetKeyName(1, "soft_folder_open.png");
            // 
            // ucChiNhanh
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TreeMain);
            this.Name = "ucChiNhanh";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Size = new System.Drawing.Size(427, 593);
            ((System.ComponentModel.ISupportInitialize)(this.TreeMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection16)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList TreeMain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn TreeMain_Id;
        private DevExpress.XtraTreeList.Columns.TreeListColumn TreeMain_Ten;
        private DevExpress.Utils.ImageCollection ImageCollection16;
    }
}

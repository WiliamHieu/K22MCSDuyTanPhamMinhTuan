namespace INVENTORY.WinApp.CONTROL
{
    partial class ucThoiGian
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
            this.cboDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.cboTuNgay = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDenNgay
            // 
            this.cboDenNgay.EditValue = null;
            this.cboDenNgay.EnterMoveNextControl = true;
            this.cboDenNgay.Location = new System.Drawing.Point(92, 0);
            this.cboDenNgay.Name = "cboDenNgay";
            this.cboDenNgay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cboDenNgay.Properties.NullText = " -- Ngày xem --";
            this.cboDenNgay.Properties.ShowToday = false;
            this.cboDenNgay.Size = new System.Drawing.Size(86, 20);
            this.cboDenNgay.TabIndex = 4;
            // 
            // cboTuNgay
            // 
            this.cboTuNgay.EditValue = null;
            this.cboTuNgay.EnterMoveNextControl = true;
            this.cboTuNgay.Location = new System.Drawing.Point(0, 0);
            this.cboTuNgay.Name = "cboTuNgay";
            this.cboTuNgay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cboTuNgay.Properties.NullText = " -- Ngày xem --";
            this.cboTuNgay.Properties.ShowToday = false;
            this.cboTuNgay.Size = new System.Drawing.Size(86, 20);
            this.cboTuNgay.TabIndex = 3;
            // 
            // ucThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboDenNgay);
            this.Controls.Add(this.cboTuNgay);
            this.Name = "ucThoiGian";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Size = new System.Drawing.Size(178, 20);
            ((System.ComponentModel.ISupportInitialize)(this.cboDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuNgay.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevExpress.XtraEditors.DateEdit cboDenNgay;
        private DevExpress.XtraEditors.DateEdit cboTuNgay;
    }
}

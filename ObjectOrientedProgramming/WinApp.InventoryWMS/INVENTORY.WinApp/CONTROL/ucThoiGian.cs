using System;

namespace INVENTORY.WinApp.CONTROL
{
    public partial class ucThoiGian : DevExpress.XtraEditors.XtraUserControl
    {
        public ucThoiGian()
        {
            InitializeComponent();
        }

        public DateTime ThoiGian
        {
            set
            {
                cboTuNgay.EditValue = value;
                cboDenNgay.EditValue = value;
            }
        }

        public DateTime TuNgay
        {
            get
            {
                return Convert.ToDateTime(cboTuNgay.EditValue);
            }
            set
            {
                cboTuNgay.EditValue = value;
            }
        }

        public DateTime DenNgay
        {
            get
            {
                return Convert.ToDateTime(cboDenNgay.EditValue);
            }
            set
            {
                cboDenNgay.EditValue = value;
            }
        }
    }
}

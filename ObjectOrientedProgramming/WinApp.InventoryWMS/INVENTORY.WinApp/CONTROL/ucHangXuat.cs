using System;
using System.Data;
using System.Windows.Forms;

namespace INVENTORY.WinApp.CONTROL
{
    public partial class ucHangXuat : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler EnterPress;

        public ucHangXuat()
        {
            InitializeComponent();
        }

        public DateTime ThoiGian
        {
            set
            {
                cboDenNgay.EditValue = value;
            }
        }

        public void LoadData(object oIdBoPhan)
        {
            if (oIdBoPhan == null)
            {
                gridMain.DataSource = null;
            }
            else
            {
            }
        }

        public DateTime TuNgay
        {
            get
            {
                if (cboTuNgay.EditValue == null) return DateTime.Now;
                return ((DateTime)cboTuNgay.EditValue).Date;
            }
        }

        public DateTime DenNgay
        {
            get
            {
                if (cboDenNgay.EditValue == null) return DateTime.Now;
                return ((DateTime)cboDenNgay.EditValue).Date;
            }
        }

        public DataRow rowHangXuat { get; private set; } = null;

        public int SoLuong
        {
            get
            {
                return Convert.ToInt32(spSoLuong.EditValue);
            }
        }

        public void FocusLoaiVatTu()
        {
            rowHangXuat = null;
            spSoLuong.EditValue = null;

            pceMain.EditValue = null;
            pceMain.Focus();
        }

        private void gridMainView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                int rowIndex = e.RowHandle;
                if (rowIndex >= 0)
                {
                    rowIndex++;
                    e.Info.DisplayText = rowIndex.ToString();
                }
            }
        }

        private void gridMainView_DoubleClick(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo rowInfor = gridMainView.CalcHitInfo((e as MouseEventArgs).Location);
            if (rowInfor.InRowCell == true)
            {
                if (gridMainView.IsDataRow(gridMainView.FocusedRowHandle))
                {
                    SelectData();
                }
            }
        }

        private void gridMain_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gridMainView.IsDataRow(gridMainView.FocusedRowHandle))
                {
                    SelectData();
                }
            }
        }

        private void pceMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterPress?.Invoke(this, new System.EventArgs());
            }
        }

        private void SelectData()
        {
            if (gridMainView.GetSelectedRows().Length > 0 && gridMainView.IsDataRow(gridMainView.FocusedRowHandle))
            {
                rowHangXuat = gridMainView.GetDataRow(gridMainView.FocusedRowHandle);
                spSoLuong.EditValue = rowHangXuat["SoLuong"];
                pceMain.EditValue = rowHangXuat["TenLoaiVatTu"];
            }
            else
            {
                rowHangXuat = null;
                spSoLuong.EditValue = null;
                pceMain.EditValue = null;
            }
            pceMain.ClosePopup();
        }
    }
}

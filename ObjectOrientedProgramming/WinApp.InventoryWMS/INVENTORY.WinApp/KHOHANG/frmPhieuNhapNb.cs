using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.KHOHANG
{
    public partial class frmPhieuNhapNb : DevExpress.XtraEditors.XtraForm
    {
        private List<CustomKhPhieuNhapNbGetListResult> lstPhieuNhapNb = null;
        private int firstLoad = 0;

        public frmPhieuNhapNb()
        {
            InitializeComponent();
            ToolbarGia.EditCaption = "Kiểm hàng";
            ToolbarGia.HideTool = INVENTORY.CONTROL.ToolbarGia.Action.Delete;
            ToolbarGia.HideTool = INVENTORY.CONTROL.ToolbarGia.Action.Save;
        }

        private void frmPhieuNhapNb_Activated(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            if (brgWorker.IsBusy)
            {
                XtraMessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            firstLoad = 0;
            brgWorker.RunWorkerAsync("View");         
        }

        private void EditData()
        {
            Guid IdPhieuNhapNb = new Guid(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id").ToString());
            frmPhieuNhapNbAdd frm = new frmPhieuNhapNbAdd(this);
            frm.IdPhieuNhapNb = IdPhieuNhapNb;
            frm.ShowDialog();
        }

        private void FocusData()
        {
            if (gridMainView.IsDataRow(gridMainView.FocusedRowHandle))
            {
                Guid IdPhieuNhapNb = MTValue.Guid(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id"));
                gridChiTiet.DataSource = oFunction.KhNhapXuat_Get_ListChiTiet("NhapNb", null, IdPhieuNhapNb);
            }
            else
            {
                gridChiTiet.DataSource = null;
            }
        }

        private void ToolbarGia_Clicked(object sender, EventArgs e)
        {
            switch (ToolbarGia.SenderName)
            {
                case INVENTORY.CONTROL.ToolbarGia.Action.Edit:
                    try
                    {
                        if (gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                        {
                            XtraMessageBox.Show("Chưa chọn Phiếu nhận hàng để Kiểm hàng", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        EditData();
                    }
                    catch (Exception)
                    {
                        XtraMessageBox.Show("Có lỗi xảy ra trong quá trình Xem chi tiết bản ghi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case INVENTORY.CONTROL.ToolbarGia.Action.Refresh:
                    BindData();
                    break;
                case INVENTORY.CONTROL.ToolbarGia.Action.Export:
                    oXtraGrid.ExportXLSX(gridMainView, "PhieuNhapNb");
                    break;
                case INVENTORY.CONTROL.ToolbarGia.Action.Print:
                    oXtraGrid.Print(gridMain, this.Text);
                    break;
                case INVENTORY.CONTROL.ToolbarGia.Action.Close:
                    this.Close();
                    break;
            }
        }

        private void MenuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "mnuThayDoi":
                    if (gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                    {
                        XtraMessageBox.Show("Chưa chọn Phiếu nhận hàng để Thay đổi kho nhận", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Guid IdPhieuNhapNb = new Guid(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id").ToString());
                    using (var dbContext = new InventoryDbContext())
                    {
                        KhPhieuNhapNb entPhieuNhapNb = dbContext.KhPhieuNhapNb.ById(IdPhieuNhapNb).FirstOrDefault();
                        if (entPhieuNhapNb == null || entPhieuNhapNb.TrangThai != 0)
                        {
                            XtraMessageBox.Show("Phiếu nhận hàng đã nhận hàng nên không thể Thay đổi kho nhận", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        frmPhieuNhapNbEdit frm = new frmPhieuNhapNbEdit(this);
                        frm.entPhieuNhapNb = entPhieuNhapNb;
                        frm.ShowDialog();
                    }
                    break;
            }
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

        private void gridMainView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (firstLoad == 0) return;
            FocusData();
        }

        private void gridMainView_DoubleClick(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo rowInfor = gridMainView.CalcHitInfo((e as MouseEventArgs).Location);
            if (rowInfor.InRowCell == true)
            {
                if (gridMainView.IsDataRow(gridMainView.FocusedRowHandle))
                {
                    EditData();
                }
            }
        }

        private void gridMain_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gridMainView.IsDataRow(gridMainView.FocusedRowHandle))
                {
                    EditData();
                }
            }
        }

        private void brgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            using (var dbContext = new InventoryDbContext())
            {
                lstPhieuNhapNb = dbContext.CustomKhPhieuNhapNbGetList(AppSetting.entKhoHang.Id).ToList();
            }
        }

        private void brgWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            gridMain.DataSource = lstPhieuNhapNb;

            firstLoad = 1;
            FocusData();
        }
    }
}
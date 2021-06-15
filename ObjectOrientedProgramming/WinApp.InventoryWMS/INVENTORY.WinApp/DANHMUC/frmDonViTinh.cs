using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.DANHMUC
{
    public partial class frmDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        List<DmDonViTinh> lstDonViTinh = null;

        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            Toolbar.FormName = this.Name;
            gridMain_cboTrangThai.DataSource = oInitData.TrangThai_InitTable();
        }

        private void frmDonViTinh_Activated(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            using (var dbContext = new InventoryDbContext())
            {
                dbContext.DeferredLoadingEnabled = false;
                lstDonViTinh = (from tt in dbContext.DmDonViTinh
                                where (Toolbar.TrangThai == 0 || tt.TrangThai == -1) &&
                                     (Toolbar.TrangThai == -1 || tt.TrangThai != -1)
                                select tt).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();
            }
            gridMain.DataSource = lstDonViTinh;
        }

        private void EditData()
        {
            DmDonViTinh entCatalog = (DmDonViTinh)gridMainView.GetRow(gridMainView.FocusedRowHandle);
            frmDonViTinhAdd frm = new frmDonViTinhAdd(this);
            frm.entCatalogOld = entCatalog;
            frm.ShowDialog();
        }

        private void Toolbar_Clicked(object sender, EventArgs e)
        {
            switch (Toolbar.SenderName)
            {
                case INVENTORY.CONTROL.Toolbar.Action.Add:
                    frmDonViTinhAdd frm = new frmDonViTinhAdd(this);
                    frm.ShowDialog();
                    break;
                case INVENTORY.CONTROL.Toolbar.Action.Edit:
                    try
                    {
                        if (gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                        {
                            XtraMessageBox.Show("Chưa chọn Thông tin Đơn vị tính để Sửa đổi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        EditData();
                    }
                    catch (Exception)
                    {
                        XtraMessageBox.Show("Có lỗi xảy ra trong quá trình Sửa đổi bản ghi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case INVENTORY.CONTROL.Toolbar.Action.Delete:
                    try
                    {
                        if (gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                        {
                            XtraMessageBox.Show("Chưa chọn Thông tin Đơn vị tính để Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        Guid IdDonViTinh = new Guid(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id").ToString());
                        using (var dbContext = new InventoryDbContext())
                        {
                            if (dbContext.DmLoaiVatTu.Any(d => d.IdDonViTinh == IdDonViTinh))
                            {
                                XtraMessageBox.Show("Thông tin Đơn vị tính đã được sử dụng nên không thể Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            DialogResult drResult = XtraMessageBox.Show("Bạn có muốn xóa Thông tin những Đơn vị tính đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (drResult == DialogResult.No) return;
                            try
                            {
                                dbContext.DmDonViTinh.Delete(IdDonViTinh);
                                dbContext.SubmitChanges();

                                BindData();
                            }
                            catch (Exception)
                            {
                                XtraMessageBox.Show("Xóa Thông tin Đơn vị tính Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        XtraMessageBox.Show("Có lỗi xảy ra trong quá trình Xóa bản ghi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case INVENTORY.CONTROL.Toolbar.Action.Hide:
                    try
                    {
                        if (gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                        {
                            XtraMessageBox.Show("Chưa chọn Thông tin Đơn vị tính để Ẩn", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        Guid IdDonViTinh = new Guid(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id").ToString());
                        using (var dbContext = new InventoryDbContext())
                        {
                            if (dbContext.DmLoaiVatTu.ByTrangThai(1).Any(d => d.IdDonViTinh == IdDonViTinh))
                            {
                                XtraMessageBox.Show("Thông tin Đơn vị tính đã được sử dụng nên không thể Ẩn", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            DialogResult drResult = XtraMessageBox.Show("Bạn có muốn Ẩn Thông tin Đơn vị tính đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (drResult == DialogResult.No) return;
                            try
                            {
                                DmDonViTinh entDonViTinh = dbContext.DmDonViTinh.ById(IdDonViTinh).FirstOrDefault();
                                entDonViTinh.TrangThai = -1;
                                dbContext.SubmitChanges();

                                BindData();
                            }
                            catch (Exception)
                            {
                                XtraMessageBox.Show("Ẩn Thông tin Đơn vị tính Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        XtraMessageBox.Show("Có lỗi xảy ra trong quá trình Ẩn bản ghi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case INVENTORY.CONTROL.Toolbar.Action.Refresh:
                    BindData();
                    break;
                case INVENTORY.CONTROL.Toolbar.Action.Export:
                    oXtraGrid.ExportXLSX(gridMainView, "DonViTinh");
                    break;
                case INVENTORY.CONTROL.Toolbar.Action.Print:
                    oXtraGrid.Print(gridMain, this.Text);
                    break;
                case INVENTORY.CONTROL.Toolbar.Action.Close:
                    this.Close();
                    break;
            }
        }

        private void Toolbar_Changed(object sender, EventArgs e)
        {
            Toolbar.SenderName = INVENTORY.CONTROL.Toolbar.Action.Refresh;
            Toolbar_Clicked(sender, e);
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
    }
}
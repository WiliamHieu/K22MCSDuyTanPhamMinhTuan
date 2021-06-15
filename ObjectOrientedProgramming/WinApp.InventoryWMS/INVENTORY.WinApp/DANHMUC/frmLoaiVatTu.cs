using System;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.DANHMUC
{
    public partial class frmLoaiVatTu : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiVatTu()
        {
            InitializeComponent();
        }

        private void frmLoaiVatTu_Load(object sender, EventArgs e)
        {
            gridMain_cboTrangThai.DataSource = oInitData.TrangThai_InitTable();
            ucNhomVatTu.LoadData(false);
            Toolbar.FormName = this.Name;
        }

        private void frmLoaiVatTu_Activated(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            if (!ucNhomVatTu.Loaded) return;
            using (var dbContext = new InventoryDbContext())
            {
                Guid? IdNhomVatTu = null;
                if (ucNhomVatTu.IdNhomVatTu != DBNull.Value) IdNhomVatTu = (Guid)ucNhomVatTu.IdNhomVatTu;
                gridMain.DataSource = dbContext.CustomDmLoaiVatTuGetList(IdNhomVatTu, Toolbar.TrangThai).ToList();
            }
        }

        private void EditData()
        {
            if (gridMainView.IsDataRow(gridMainView.FocusedRowHandle))
            {
                using (var dbContext = new InventoryDbContext())
                {
                    Guid IdLoaiVatTu = new Guid(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id").ToString());

                    DmLoaiVatTu entCatalog = dbContext.DmLoaiVatTu.ById(IdLoaiVatTu).FirstOrDefault();
                    frmLoaiVatTuAdd frm = new frmLoaiVatTuAdd(this);
                    frm.entCatalogOld = entCatalog;
                    frm.ShowDialog();
                }
            }
        }

        private void Toolbar_Clicked(object sender, EventArgs e)
        {
            switch (Toolbar.SenderName)
            {
                case INVENTORY.CONTROL.Toolbar.Action.Add:
                    frmLoaiVatTuAdd frm = new frmLoaiVatTuAdd(this);
                    if(!Convert.IsDBNull(ucNhomVatTu.IdNhomVatTu))
                        frm.IdNhomVatTu = ucNhomVatTu.IdNhomVatTu;
                    frm.ShowDialog();
                    break;
                case INVENTORY.CONTROL.Toolbar.Action.Edit:
                    try
                    {
                        if (gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                        {
                            XtraMessageBox.Show("Chưa chọn Thông tin Loại vật tư để Sửa đổi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            XtraMessageBox.Show("Chưa chọn Thông tin Loại vật tư để Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        Guid IdLoaiVatTu = new Guid(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id").ToString());
                        using (var dbContext = new InventoryDbContext())
                        {
                            if (dbContext.KhSanPham.Any(d => d.IdLoaiVatTu == IdLoaiVatTu))
                            {
                                XtraMessageBox.Show("Thông tin Loại vật tư đã được sử dụng nên không thể Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            DialogResult drResult = XtraMessageBox.Show("Bạn có muốn xóa Thông tin những Loại vật tư đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (drResult == DialogResult.No) return;
                            try
                            {
                                dbContext.DmLoaiVatTu.Delete(IdLoaiVatTu);
                                dbContext.SubmitChanges();

                                BindData();
                            }
                            catch (Exception)
                            {
                                XtraMessageBox.Show("Xóa Thông tin Loại vật tư Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            XtraMessageBox.Show("Chưa chọn Thông tin Loại vật tư để Ẩn", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        Guid IdLoaiVatTu = new Guid(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id").ToString());
                        using (var dbContext = new InventoryDbContext())
                        {
                            if (dbContext.KhSanPham.Where(d => d.SoLuongTon > 0).Any(d => d.IdLoaiVatTu == IdLoaiVatTu))
                            {
                                XtraMessageBox.Show("Thông tin Loại vật tư đang có Hàng tồn nên không thể Ẩn", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            DialogResult drResult = XtraMessageBox.Show("Bạn có muốn Ẩn Thông tin Loại vật tư đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (drResult == DialogResult.No) return;
                            try
                            {
                                DmLoaiVatTu entLoaiVatTu = dbContext.DmLoaiVatTu.ById(IdLoaiVatTu).FirstOrDefault();
                                entLoaiVatTu.TrangThai = -1;
                                dbContext.SubmitChanges();

                                BindData();
                            }
                            catch (Exception)
                            {
                                XtraMessageBox.Show("Ẩn Thông tin Loại vật tư Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        XtraMessageBox.Show("Có lỗi xảy ra trong quá trình Ẩn bản ghi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case INVENTORY.CONTROL.Toolbar.Action.Refresh:
                    ucNhomVatTu.LoadData(false);
                    BindData();
                    break;
                case INVENTORY.CONTROL.Toolbar.Action.Export:
                    oXtraGrid.ExportXLSX(gridMainView, "LoaiVatTu");
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

        private void ucNhomVatTu_FocusedNodeChanged(object sender, EventArgs e)
        {
            BindData();
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
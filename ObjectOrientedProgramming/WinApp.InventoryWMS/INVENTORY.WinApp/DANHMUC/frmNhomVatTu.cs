using System;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.DANHMUC
{
    public partial class frmNhomVatTu : DevExpress.XtraEditors.XtraForm
    {
        public frmNhomVatTu()
        {
            InitializeComponent();
        }

        private void frmNhomVatTu_Load(object sender, EventArgs e)
        {
            Toolbar.FormName = this.Name;
            gridMain_cboTrangThai.DataSource = oInitData.TrangThai_InitTable();
        }

        private void frmNhomVatTu_Activated(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            using (var dbContext = new InventoryDbContext())
            {
                dbContext.DeferredLoadingEnabled = false;
                var lstKhoHang = (from tt in dbContext.DmNhomVatTu
                                  where (Toolbar.TrangThai == 0 || tt.TrangThai == -1) &&
                                        (Toolbar.TrangThai == -1 || tt.TrangThai != -1)
                                  select tt).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();

                gridMain.DataSource = lstKhoHang;
            }
        }

        private void EditData()
        {
            DmNhomVatTu entCatalog = (DmNhomVatTu)gridMainView.GetRow(gridMainView.FocusedRowHandle);
            frmNhomVatTuAdd frm = new frmNhomVatTuAdd(this);
            frm.entCatalogOld = entCatalog;
            frm.ShowDialog();
        }

        private void Toolbar_Clicked(object sender, EventArgs e)
        {
            switch (Toolbar.SenderName)
            {
                case INVENTORY.CONTROL.Toolbar.Action.Add:
                    frmNhomVatTuAdd frm = new frmNhomVatTuAdd(this);
                    frm.ShowDialog();
                    break;
                case INVENTORY.CONTROL.Toolbar.Action.Edit:
                    try
                    {
                        if (gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                        {
                            XtraMessageBox.Show("Chưa chọn Thông tin Nhóm vật tư để Sửa đổi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            XtraMessageBox.Show("Chưa chọn Thông tin Nhóm vật tư để Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        Guid IdNhomVatTu = new Guid(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id").ToString());
                        using (var dbContext = new InventoryDbContext())
                        {
                            if (dbContext.DmLoaiVatTu.Any(d => d.IdNhomVatTu == IdNhomVatTu))
                            {
                                XtraMessageBox.Show("Thông tin Nhóm vật tư đã được sử dụng nên không thể Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            DialogResult drResult = XtraMessageBox.Show("Bạn có muốn xóa Thông tin những Nhóm vật tư đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (drResult == DialogResult.No) return;
                            try
                            {
                                dbContext.DmNhomVatTu.Delete(IdNhomVatTu);
                                dbContext.SubmitChanges();

                                BindData();
                            }
                            catch (Exception)
                            {
                                XtraMessageBox.Show("Xóa Thông tin Nhóm vật tư Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            XtraMessageBox.Show("Chưa chọn Thông tin Nhóm vật tư để Ẩn", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        Guid IdNhomVatTu = new Guid(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id").ToString());
                        using (var dbContext = new InventoryDbContext())
                        {
                            if (dbContext.DmLoaiVatTu.Where(d => d.TrangThai == 1).Any(d => d.IdNhomVatTu == IdNhomVatTu))
                            {
                                XtraMessageBox.Show("Thông tin Nhóm vật tư đã được sử dụng nên không thể Ẩn", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            DialogResult drResult = XtraMessageBox.Show("Bạn có muốn ẩn Thông tin những Nhóm vật tư đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (drResult == DialogResult.No) return;
                            try
                            {
                                DmNhomVatTu entCatalog = dbContext.DmNhomVatTu.ById(IdNhomVatTu).FirstOrDefault();
                                entCatalog.TrangThai = -1;
                                dbContext.SubmitChanges();

                                BindData();
                            }
                            catch (Exception)
                            {
                                XtraMessageBox.Show("Ẩn Thông tin Nhóm vật tư Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    oXtraGrid.ExportXLSX(gridMainView, "NhomVatTu");
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
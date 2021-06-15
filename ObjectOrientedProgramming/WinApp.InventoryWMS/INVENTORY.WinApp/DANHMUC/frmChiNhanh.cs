using System;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.DANHMUC
{
    public partial class frmChiNhanh : XtraForm
    {
        public frmChiNhanh()
        {
            InitializeComponent();
        }

        private void frmChiNhanh_Load(object sender, EventArgs e)
        {
            Toolbar.FormName = this.Name;
            gridMain_cboTrangThai.DataSource = oInitData.TrangThai_InitTable();
        }

        private void frmChiNhanh_Activated(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            using (var dbContext = new InventoryDbContext())
            {
                dbContext.DeferredLoadingEnabled = false;
                var lstChiNhanh = (from tt in dbContext.DmChiNhanh
                                   where (Toolbar.TrangThai == 0 || tt.TrangThai == -1) &&
                                         (Toolbar.TrangThai == -1 || tt.TrangThai != -1)
                                   select tt).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();
                gridMain.DataSource = lstChiNhanh;
            }
        }

        private void EditData()
        {
            DmChiNhanh entCatalog = (DmChiNhanh)gridMainView.GetRow(gridMainView.FocusedRowHandle);
            frmChiNhanhAdd frm = new frmChiNhanhAdd(this);
            frm.entCatalogOld = entCatalog;
            frm.ShowDialog();
        }

        private void Toolbar_Clicked(object sender, EventArgs e)
        {
            switch (Toolbar.SenderName)
            {
                case INVENTORY.CONTROL.Toolbar.Action.Add:
                    frmChiNhanhAdd frm = new frmChiNhanhAdd(this);
                    frm.ShowDialog();
                    break;
                case INVENTORY.CONTROL.Toolbar.Action.Edit:
                    try
                    {
                        if(gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                        {
                            XtraMessageBox.Show("Chưa chọn Thông tin Chi nhánh để Sửa đổi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            XtraMessageBox.Show("Chưa chọn Thông tin Chi nhánh để Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        int IdChiNhanh = Convert.ToInt32(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id"));
                        using (var dbContext = new InventoryDbContext())
                        {
                            if (dbContext.DmKhoHang.Any(d => d.IdChiNhanh == IdChiNhanh))
                            {
                                XtraMessageBox.Show("Thông tin Chi nhánh đã được sử dụng nên không thể Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            DialogResult drResult = XtraMessageBox.Show("Bạn có muốn xóa Thông tin những Chi nhánh đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (drResult == DialogResult.No) return;
                            try
                            {
                                dbContext.DmChiNhanh.Delete(IdChiNhanh);
                                dbContext.SubmitChanges();

                                BindData();
                            }
                            catch (Exception)
                            {
                                XtraMessageBox.Show("Xóa Thông tin Bộ phận Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            XtraMessageBox.Show("Chưa chọn Thông tin Chi nhánh để Ẩn", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        int IdChiNhanh = Convert.ToInt32(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id"));
                        using (var dbContext = new InventoryDbContext())
                        {
                            if (dbContext.DmKhoHang.ByTrangThai(1).Any(d => d.IdChiNhanh == IdChiNhanh))
                            {
                                XtraMessageBox.Show("Thông tin Chi nhánh đang được sử dụng nên không thể Ẩn", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            DialogResult drResult = XtraMessageBox.Show("Bạn có muốn Ẩn Thông tin Chi nhánh đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (drResult == DialogResult.No) return;
                            try
                            {
                                DmChiNhanh entCatalog = dbContext.DmChiNhanh.ById(IdChiNhanh).FirstOrDefault();
                                entCatalog.TrangThai = -1;
                                dbContext.SubmitChanges();

                                BindData();
                            }
                            catch (Exception)
                            {
                                XtraMessageBox.Show("Ẩn Thông tin Chi nhánh Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    oXtraGrid.ExportXLSX(gridMainView, "ChiNhanh");
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
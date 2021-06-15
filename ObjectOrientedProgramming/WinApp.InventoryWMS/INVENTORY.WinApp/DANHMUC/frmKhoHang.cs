using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.DANHMUC
{
    public partial class frmKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoHang()
        {
            InitializeComponent();
            Toolbar.HideTool = INVENTORY.CONTROL.Toolbar.Action.Add;
            Toolbar.HideTool = INVENTORY.CONTROL.Toolbar.Action.Delete;
        }

        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            Toolbar.FormName = this.Name;
            gridMain_cboTrangThai.DataSource = oInitData.TrangThai_InitTable();
            ucChiNhanh.LoadData();
        }

        private void frmKhoHang_Activated(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            if (!ucChiNhanh.Loaded) return;
            using (var dbContext = new InventoryDbContext())
            {
                dbContext.DeferredLoadingEnabled = false;
                var lstKhoHang = (from tt in dbContext.DmKhoHang
                                  where (Toolbar.TrangThai == 0 || tt.TrangThai == -1) &&
                                        (Toolbar.TrangThai == -1 || tt.TrangThai != -1) &&
                                        (ucChiNhanh.IdChiNhanh == 0 || tt.IdChiNhanh == ucChiNhanh.IdChiNhanh)
                                  select tt).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();

                gridMain.DataSource = lstKhoHang;
            }
        }

        private void EditData()
        {
            DmKhoHang entCatalog = (DmKhoHang)gridMainView.GetRow(gridMainView.FocusedRowHandle);
            frmKhoHangAdd frm = new frmKhoHangAdd(this);
            frm.entCatalogOld = entCatalog;
            frm.ShowDialog();
        }

        private void Toolbar_Clicked(object sender, EventArgs e)
        {
            switch (Toolbar.SenderName)
            {
                case INVENTORY.CONTROL.Toolbar.Action.Edit:
                    try
                    {
                        if (gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                        {
                            XtraMessageBox.Show("Chưa chọn Thông tin Kho hàng để Sửa đổi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        EditData();
                    }
                    catch (Exception)
                    {
                        XtraMessageBox.Show("Có lỗi xảy ra trong quá trình Sửa đổi bản ghi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case INVENTORY.CONTROL.Toolbar.Action.Hide:
                    try
                    {
                        if (gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                        {
                            XtraMessageBox.Show("Chưa chọn Thông tin Kho hàng để Ẩn", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        int IdKhoHang = Convert.ToInt32(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id"));
                        using (var dbContext = new InventoryDbContext())
                        {
                            if (dbContext.KhSanPham.Where(d => d.SoLuongTon > 0).Any(d => d.IdKhoHang == IdKhoHang))
                            {
                                XtraMessageBox.Show("Thông tin Kho hàng đang có Hàng tồn kho nên không thể Ẩn", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            DialogResult drResult = XtraMessageBox.Show("Bạn có muốn Ẩn Thông tin Kho hàng đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (drResult == DialogResult.No) return;
                            try
                            {
                                DmKhoHang entCatalog = dbContext.DmKhoHang.ById(IdKhoHang).FirstOrDefault();
                                entCatalog.TrangThai = -1;
                                dbContext.SubmitChanges();

                                BindData();
                            }
                            catch (Exception)
                            {
                                XtraMessageBox.Show("Ẩn Thông tin Kho hàng Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    oXtraGrid.ExportXLSX(gridMainView, "KhoHang");
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
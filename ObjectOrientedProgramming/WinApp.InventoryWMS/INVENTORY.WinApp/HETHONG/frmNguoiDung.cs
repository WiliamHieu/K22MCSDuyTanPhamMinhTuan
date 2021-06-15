using System;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.HETHONG
{
    public partial class frmNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            Toolbar.FormName = this.Name;
            gridMain_cboTrangThai.DataSource = oInitData.TrangThai_InitTable();
            ucKhoHang.LoadData();
        }

        private void frmNguoiDung_Activated(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            if (!ucKhoHang.Loaded) return;
            using (var dbContext = new InventoryDbContext())
            {
                gridMain.DataSource = dbContext.CustomHtNguoiDungGetList(ucKhoHang.IdChiNhanh, ucKhoHang.IdKhoHang, ucKhoHang.IdVaiTro, Toolbar.TrangThai).ToList();
            }
        }

        private void EditData()
        {
            int IdNguoiDung = Convert.ToInt32(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id"));
            using (var dbContext = new InventoryDbContext())
            {
                frmNguoiDungAdd frm = new frmNguoiDungAdd(this);
                frm.entCatalogOld = dbContext.HtNguoiDung.ById(IdNguoiDung).FirstOrDefault();
                frm.ShowDialog();
            }
        }

        private void Toolbar_Clicked(object sender, EventArgs e)
        {
            switch (Toolbar.SenderName)
            {
                case INVENTORY.CONTROL.Toolbar.Action.Add:
                    frmNguoiDungAdd frm = new frmNguoiDungAdd(this);
                    frm.ShowDialog();
                    break;
                case INVENTORY.CONTROL.Toolbar.Action.Edit:
                    try
                    {
                        if (gridMainView.GetSelectedRows().Length == 0 || gridMainView.IsFilterRow(gridMainView.FocusedRowHandle))
                        {
                            XtraMessageBox.Show("Chưa chọn Thông tin Người dùng để Sửa đổi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            XtraMessageBox.Show("Chưa chọn Thông tin Người dùng để Xóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        DialogResult drResult = XtraMessageBox.Show("Bạn có muốn xóa Thông tin Người dùng đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (drResult == DialogResult.No) return;
                        using (var dbContext = new InventoryDbContext())
                        {
                            try
                            {
                                int IdNguoiDung = Convert.ToInt32(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id"));
                                dbContext.HtNguoiDung.Delete(IdNguoiDung);
                                dbContext.SubmitChanges();

                                BindData();
                            }
                            catch (Exception)
                            {
                                XtraMessageBox.Show("Xóa Thông tin Người dùng Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        BindData();
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
                            XtraMessageBox.Show("Chưa chọn Thông tin Người dùng để Ẩn", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        DialogResult drResult = XtraMessageBox.Show("Bạn có muốn Ẩn Thông tin Người dùng đã chọn?", AppSetting.MessageCaption(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (drResult == DialogResult.No) return;
                        using (var dbContext = new InventoryDbContext())
                        {
                            try
                            {
                                int IdNguoiDung = Convert.ToInt32(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "Id"));
                                HtNguoiDung entNguoiDung = dbContext.HtNguoiDung.ById(IdNguoiDung).FirstOrDefault();
                                entNguoiDung.TrangThai = -1;
                                dbContext.SubmitChanges();

                                BindData();
                            }
                            catch (Exception)
                            {
                                XtraMessageBox.Show("Ẩn Thông tin Người dùng Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    oXtraGrid.ExportXLSX(gridMainView, "NguoiDung");
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

        private void ucKhoHang_FocusedNodeChanged(object sender, EventArgs e)
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
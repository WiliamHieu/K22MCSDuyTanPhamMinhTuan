using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

using INVENTORY.Data;

namespace INVENTORY.WinApp.HETHONG
{
    public partial class frmNguoiDungAdd : DevExpress.XtraEditors.XtraForm
    {
        frmNguoiDung frmParent = null;

        private DataTable dtNguoiDungVaiTro = null;
        public HtNguoiDung entCatalogOld = null;

        public frmNguoiDungAdd(frmNguoiDung frm)
        {
            InitializeComponent();
            frmParent = frm;
        }

        private void frmNguoiDungAdd_Load(object sender, EventArgs e)
        {
            chkThuocTinh.Items[0].CheckState = CheckState.Checked;
            BindCatalog.HtVaiTro_BindDropDown(gridMain_cboVaiTro);
            using (var dbContext = new InventoryDbContext())
            {
                if (entCatalogOld != null)
                {
                    txtTen.EditValue = entCatalogOld.Ten;
                    txtTenTruyCap.EditValue = entCatalogOld.TenTruyCap;
                    chkThuocTinh.Items[0].CheckState = (CheckState)Convert.ToInt32(entCatalogOld.DangNhap);
                    txtChuThich.EditValue = entCatalogOld.ChuThich;
                    chkTrangThai.Items[0].CheckState = MTCheckbox.State(entCatalogOld.TrangThai);
                }
                dtNguoiDungVaiTro = oFunction.ToDataTable(dbContext.CustomHtNguoiDungGetListVaiTro(entCatalogOld == null ? 0 : entCatalogOld.Id).ToList());
                gridMain.DataSource = dtNguoiDungVaiTro;
            }

            ToolbarDm.Permission_Set(this.Name, entCatalogOld != null);
            txtTen.Focus();
        }

        private void ToolbarDm_Clicked(object sender, EventArgs e)
        {
            switch (ToolbarDm.SenderName)
            {
                case INVENTORY.CONTROL.ToolbarDm.Action.Save:
                    if (!SaveRecord()) return;
                    break;
                case INVENTORY.CONTROL.ToolbarDm.Action.SaveAdd:
                    if (!SaveRecord()) return;
                    break;
                case INVENTORY.CONTROL.ToolbarDm.Action.SaveClose:
                    if (!SaveRecord()) return;
                    this.Close();
                    break;
                case INVENTORY.CONTROL.ToolbarDm.Action.Close:
                    this.Close();
                    break;
            }
        }

        private void chkTrangThai_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            e.Appearance.BackColor = System.Drawing.Color.White;
            e.Appearance.ForeColor = System.Drawing.Color.Black;
        }

        private void chkTrangThai_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void gridMain_chkMacDinh_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                gridMainView.PostEditor();
                if (Convert.ToBoolean(gridMainView.GetRowCellValue(gridMainView.FocusedRowHandle, "MacDinh")))
                {
                    foreach (DataRow row in dtNguoiDungVaiTro.Rows)
                    {
                        row["MacDinh"] = false;
                    }
                    gridMainView.SetRowCellValue(gridMainView.FocusedRowHandle, "MacDinh", true);
                }
                gridMainView.PostEditor();
            }
            catch (Exception)
            {
            }
        }

        private void gridMain_cboVaiTro_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                gridMainView.SetRowCellValue(gridMainView.FocusedRowHandle, "IdVaiTro", DBNull.Value);
            }
        }

        private bool SaveRecord()
        {
            string Ten = MTString.TextClean(txtTen.EditValue);
            if (Ten.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Tên người dùng", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            string TenTruyCap = MTString.TextClean(txtTenTruyCap.EditValue);
            if (TenTruyCap.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Tên truy cập", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTruyCap.Focus();
                return false;
            }
            string MatKhau = MTString.TextClean(txtMatKhau.EditValue);
            if (MatKhau.Length == 0 && entCatalogOld == null)
            {
                XtraMessageBox.Show("Chưa nhập Mật khẩu", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return false;
            }
            ColumnView viewMain = gridMain.FocusedView as ColumnView;
            viewMain.CloseEditor();
            if (!viewMain.UpdateCurrentRow())
            {
                XtraMessageBox.Show("Không thể cập nhật Dữ liệu trên Danh sách Vai trò", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtNguoiDungVaiTro.Select("IdVaiTro IS NOT NULL").Length == 0)
            {
                XtraMessageBox.Show("Chưa chọn Quyền hạn cho Người dùng", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtNguoiDungVaiTro.Select("MacDinh=0").Length == 0)
            {
                XtraMessageBox.Show("Chưa chọn Kho mặc định cho Người dùng", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            bool updateStatus = false;
            using (var dbContext = new InventoryDbContext())
            {
                if (entCatalogOld == null)
                {
                    if (dbContext.HtNguoiDung.ByTen(Ten).Count() > 0)
                    {
                        XtraMessageBox.Show("Tên người dùng đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTen.Focus();
                        return false;
                    }
                    if (dbContext.HtNguoiDung.ByTenTruyCap(TenTruyCap).Count() > 0)
                    {
                        XtraMessageBox.Show("Tên truy cập đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTenTruyCap.Focus();
                        return false;
                    }
                }
                else
                {
                    if (dbContext.HtNguoiDung.ByTen(Ten).Where(d => d.Id != entCatalogOld.Id).Count() > 0)
                    {
                        XtraMessageBox.Show("Tên người dùng đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTen.Focus();
                        return false;
                    }
                    if (dbContext.HtNguoiDung.ByTenTruyCap(TenTruyCap).Where(d => d.Id != entCatalogOld.Id).Count() > 0)
                    {
                        XtraMessageBox.Show("Tên truy cập đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTenTruyCap.Focus();
                        return false;
                    }
                }

                dbContext.Connection.Open();
                dbContext.Transaction = dbContext.Connection.BeginTransaction(IsolationLevel.Snapshot);

                try
                {
                    int IdNguoiDung = 0;
                    if (entCatalogOld == null)
                    {
                        HtNguoiDung entCatalog = new HtNguoiDung
                        {
                            Ten = Ten,
                            TenTruyCap = TenTruyCap,
                            MatKhau = MTString.TextEncrypt(MatKhau),
                            DangNhap = Convert.ToBoolean(chkThuocTinh.Items[0].CheckState),
                            TrangThai = MTCheckbox.Int32Value(chkTrangThai.Items[0].CheckState),
                            ChuThich = MTString.TextClean(txtChuThich.Text)
                        };
                        dbContext.HtNguoiDung.InsertOnSubmit(entCatalog);
                        dbContext.SubmitChanges();

                        IdNguoiDung = entCatalog.Id;
                    }
                    else
                    {
                        entCatalogOld.Detach();
                        dbContext.HtNguoiDung.Attach(entCatalogOld);

                        entCatalogOld.Ten = Ten;
                        entCatalogOld.TenTruyCap = TenTruyCap;
                        if (MatKhau.Length == 0) entCatalogOld.MatKhau = entCatalogOld.MatKhau;
                        else entCatalogOld.MatKhau = MTString.TextEncrypt(MatKhau);
                        entCatalogOld.ChuThich = MTString.TextClean(txtChuThich.EditValue);
                        entCatalogOld.TrangThai = MTCheckbox.Int32Value(chkTrangThai.Items[0].CheckState);
                        dbContext.SubmitChanges();

                        IdNguoiDung = entCatalogOld.Id;
                    }

                    var lstNguoiDungVaiTro = dbContext.HtNguoiDungVaiTro.ByIdNguoiDung(IdNguoiDung);
                    dbContext.HtNguoiDungVaiTro.DeleteAllOnSubmit(lstNguoiDungVaiTro);
                    dbContext.SubmitChanges();

                    HtNguoiDungVaiTro entNguoiDungVaiTro = null;
                    foreach (DataRow row in dtNguoiDungVaiTro.Rows)
                    {
                        if (!Convert.IsDBNull(row["IdVaiTro"]))
                        {
                            entNguoiDungVaiTro = new HtNguoiDungVaiTro
                            {
                                IdNguoiDung = IdNguoiDung,
                                IdKhoHang = Convert.ToInt32(row["IdKhoHang"]),
                                IdVaiTro = Convert.ToInt32(row["IdVaiTro"]),
                                MacDinh = Convert.ToBoolean(row["MacDinh"])
                            };
                            dbContext.HtNguoiDungVaiTro.InsertOnSubmit(entNguoiDungVaiTro);
                        }
                    }
                    dbContext.SubmitChanges();

                    dbContext.Transaction.Commit();

                    updateStatus = true;
                }
                catch (Exception)
                {
                    dbContext.Transaction.Rollback();

                    updateStatus = false;
                }
            }
            if (updateStatus)
            {
                frmParent.BindData();

                if (ToolbarDm.SenderName == INVENTORY.CONTROL.ToolbarDm.Action.Save)
                {
                    ToolbarDm.DisableTool = INVENTORY.CONTROL.ToolbarDm.Action.Save;
                }
                else if (ToolbarDm.SenderName == INVENTORY.CONTROL.ToolbarDm.Action.SaveAdd)
                {
                    dtNguoiDungVaiTro.Clear();
                    dtNguoiDungVaiTro.AcceptChanges();
                    gridMain.DataSource = dtNguoiDungVaiTro;

                    txtTen.EditValue = null;
                    txtTenTruyCap.EditValue = null;
                    txtMatKhau.EditValue = null;
                    chkTrangThai.Items[0].CheckState = CheckState.Checked;
                    chkThuocTinh.Items[0].CheckState = CheckState.Checked;
                    txtChuThich.EditValue = null;
                    txtTen.Focus();
                }
                return true;
            }
            else
            {
                XtraMessageBox.Show("Cập nhật Thông tin Người dùng Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
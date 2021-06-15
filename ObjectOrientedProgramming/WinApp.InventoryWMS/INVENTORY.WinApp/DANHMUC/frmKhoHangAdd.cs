using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.DANHMUC
{
    public partial class frmKhoHangAdd : DevExpress.XtraEditors.XtraForm
    {
        private frmKhoHang frmParent = null;
        public DmKhoHang entCatalogOld = null;

        public frmKhoHangAdd(frmKhoHang frm)
        {
            InitializeComponent();
            frmParent = frm;
        }

        private void frmKhoHangAdd_Load(object sender, EventArgs e)
        {
            BindCatalog.DmChiNhanh_BindDropDown(cboChiNhanh);
            if (entCatalogOld != null)
            {
                cboChiNhanh.EditValue = entCatalogOld.IdChiNhanh;
                txtTen.EditValue = entCatalogOld.Ten;
                txtThuTu.EditValue = entCatalogOld.ThuTu;
                txtChuThich.EditValue = entCatalogOld.ChuThich;
                chkTrangThai.CheckState = MTCheckbox.State(entCatalogOld.TrangThai);
            }
            ToolbarLd.Permission_Set(this.Name, entCatalogOld != null);
            txtTen.Focus();
        }

        private void ToolbarLd_Clicked(object sender, EventArgs e)
        {
            switch (ToolbarLd.SenderName)
            {
                case INVENTORY.CONTROL.ToolbarLd.Action.SaveClose:
                    if (!SaveRecord()) return;
                    this.Close();
                    break;
                case INVENTORY.CONTROL.ToolbarLd.Action.Close:
                    this.Close();
                    break;
            }
        }

        private bool SaveRecord()
        {
            if (cboChiNhanh.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn Chi nhánh", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboChiNhanh.Focus();
                return false;
            }
            string storeName = MTString.TextClean(txtTen.EditValue);
            if (storeName.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Tên", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            
            bool updateStatus = false;
            using (var dbContext = new InventoryDbContext())
            {
                if (dbContext.DmKhoHang.ByTen(storeName).Where(d => d.Id != entCatalogOld.Id).Count() > 0)
                {
                    XtraMessageBox.Show("Tên kho hàng đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTen.Focus();
                    return false;
                }
                dbContext.Connection.Open();
                dbContext.Transaction = dbContext.Connection.BeginTransaction(System.Data.IsolationLevel.Snapshot);
                try
                {
                    entCatalogOld.Detach();
                    dbContext.DmKhoHang.Attach(entCatalogOld);

                    entCatalogOld.IdChiNhanh = Convert.ToInt32(cboChiNhanh.EditValue);
                    entCatalogOld.Ten = storeName;
                    entCatalogOld.ThuTu = Convert.ToInt32(txtThuTu.EditValue);
                    entCatalogOld.ChuThich = MTString.TextClean(txtChuThich.EditValue);
                    entCatalogOld.TrangThai = MTCheckbox.Int32Value(chkTrangThai.CheckState);
                    dbContext.SubmitChanges();

                    List<DmNguonKho> lstNguonKho = dbContext.DmNguonKho.ByIdKhoHang(entCatalogOld.Id).ToList();
                    DmNguonNhap entNguonNhap = dbContext.DmNguonNhap.ById(lstNguonKho[0].IdNguonNhap).FirstOrDefault();
                    entNguonNhap.Ten = entCatalogOld.Ten;
                    dbContext.SubmitChanges();

                    if (AppSetting.entKhoHang.Id == entCatalogOld.Id)
                    {
                        AppSetting.entChiNhanh = dbContext.DmChiNhanh.ById(entCatalogOld.IdChiNhanh).FirstOrDefault();
                        AppSetting.entKhoHang = entCatalogOld;
                    }

                    foreach (var entKhoHang in AppSetting.lstKhoHang)
                    {
                        if (entKhoHang.Id == entCatalogOld.Id)
                        {
                            entKhoHang.Ten = entCatalogOld.Ten;
                            entKhoHang.TenVietTat = entCatalogOld.TenVietTat;
                        }
                    }

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
                return true;
            }
            else
            {
                XtraMessageBox.Show("Cập nhật Thông tin Kho hàng Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                ToolbarLd.EnableTool = INVENTORY.CONTROL.ToolbarLd.Action.SaveClose;
                return false;
            }
        }
    }
}
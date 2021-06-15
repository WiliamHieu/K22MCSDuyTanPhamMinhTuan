using System;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.DANHMUC
{
    public partial class frmLoaiVatTuAdd : DevExpress.XtraEditors.XtraForm
    {
        private Form frmParent = null;

        public object IdNhomVatTu = null;
        public DmLoaiVatTu entCatalogOld = null;

        public frmLoaiVatTuAdd(Form frm)
        {
            InitializeComponent();
            frmParent = frm;
        }

        protected override void OnShown(EventArgs e)
        {
            if (IdNhomVatTu == null) cboNhomVatTu.Focus();
            else txtTen.Focus();
            base.OnShown(e);
        }

        private void frmLoaiVatTuAdd_Load(object sender, EventArgs e)
        {
            BindCatalog.DmNhomVatTu_BindDropDown(cboNhomVatTu);
            BindCatalog.DmDonViTinh_BindDropDown(cboDonViTinh);

            if (entCatalogOld != null)
            {
                cboNhomVatTu.EditValue = entCatalogOld.IdNhomVatTu;
                cboDonViTinh.EditValue = entCatalogOld.IdDonViTinh;
                txtTen.EditValue = entCatalogOld.Ten;
                txtQuyCach.EditValue = entCatalogOld.QuyCach;
                txtChuThich.EditValue = entCatalogOld.ChuThich;
                chkTrangThai.CheckState = MTCheckbox.State(entCatalogOld.TrangThai);
            }
            else
            {
                cboNhomVatTu.EditValue = IdNhomVatTu;
            }    
            ToolbarDm.Permission_Set(this.Name, entCatalogOld != null);
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

        private bool SaveRecord()
        {
            if (cboNhomVatTu.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn Nhóm vật tư", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNhomVatTu.Focus();
                return false;
            }
            string Ten = MTString.TextClean(txtTen.EditValue);
            if (Ten.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Tên loại vật tư", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            if (cboDonViTinh.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn Đơn vị tính", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDonViTinh.Focus();
                return false;
            }
            Guid IdLoaiVatTu = Guid.Empty;
            bool updateStatus = false;
            try
            {
                using (var dbContext = new InventoryDbContext())
                {
                    if (entCatalogOld == null)
                    {
                        if (dbContext.DmLoaiVatTu.ByTen(Ten).Count() > 0)
                        {
                            XtraMessageBox.Show("Tên loại vật tư đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTen.Focus();
                            return false;
                        }
                        DmLoaiVatTu entCatalog = new DmLoaiVatTu
                        { 
                            Id = Guid.NewGuid(),
                            IdNhomVatTu = new Guid(cboNhomVatTu.EditValue.ToString()),
                            IdDonViTinh = new Guid(cboDonViTinh.EditValue.ToString()),
                            Ten = Ten,
                            QuyCach = MTString.TextClean(txtQuyCach.EditValue),
                            ChuThich = MTString.TextClean(txtChuThich.EditValue),
                            TrangThai = MTCheckbox.Int32Value(chkTrangThai.CheckState)
                        };
                        dbContext.DmLoaiVatTu.InsertOnSubmit(entCatalog);
                        dbContext.SubmitChanges();

                        IdLoaiVatTu = entCatalog.Id;
                    }
                    else
                    {
                        if (dbContext.DmLoaiVatTu.ByTen(Ten).Where(d => d.Id != entCatalogOld.Id).Count() > 0)
                        {
                            XtraMessageBox.Show("Tên loại vật tư đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTen.Focus();
                            return false;
                        }
                        if (chkTrangThai.CheckState == CheckState.Unchecked && dbContext.KhSanPham.Where(d => d.SoLuongTon > 0).Any(d => d.IdLoaiVatTu == entCatalogOld.Id))
                        {
                            XtraMessageBox.Show("Thông tin Loại vật tư đang chọn có Hàng tồn nên không thể Khóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTen.Focus();
                            return false;
                        }
                        entCatalogOld.Detach();
                        dbContext.DmLoaiVatTu.Attach(entCatalogOld);

                        entCatalogOld.IdNhomVatTu = new Guid(cboNhomVatTu.EditValue.ToString());
                        entCatalogOld.IdDonViTinh = new Guid(cboDonViTinh.EditValue.ToString());
                        entCatalogOld.Ten = Ten;
                        entCatalogOld.QuyCach = MTString.TextClean(txtQuyCach.EditValue);
                        entCatalogOld.ChuThich = MTString.TextClean(txtChuThich.EditValue);
                        entCatalogOld.TrangThai = MTCheckbox.Int32Value(chkTrangThai.CheckState);
                        dbContext.SubmitChanges();

                        IdLoaiVatTu = entCatalogOld.Id;
                    }
                }
                updateStatus = true;
            }
            catch (Exception)
            {
                updateStatus = false;
            }
            if (updateStatus)
            {
                if (frmParent.GetType() == typeof(frmLoaiVatTu))
                    ((frmLoaiVatTu)frmParent).BindData();

                if (ToolbarDm.SenderName == INVENTORY.CONTROL.ToolbarDm.Action.Save)
                {
                    ToolbarDm.DisableTool = INVENTORY.CONTROL.ToolbarDm.Action.Save;
                }
                else if (ToolbarDm.SenderName == INVENTORY.CONTROL.ToolbarDm.Action.SaveAdd)
                {
                    entCatalogOld = null;
                    txtTen.EditValue = null;
                    txtQuyCach.EditValue = null;
                    chkTrangThai.CheckState = CheckState.Checked;
                    txtChuThich.EditValue = string.Empty;
                }
                txtTen.Focus();
                return true;
            }
            else
            {
                XtraMessageBox.Show("Cập nhật Thông tin Loại vật tư Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
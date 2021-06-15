using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.DANHMUC
{
    public partial class frmChiNhanhAdd : XtraForm
    {
        frmChiNhanh frmParent = null;
        public DmChiNhanh entCatalogOld = null;

        public frmChiNhanhAdd(frmChiNhanh frm)
        {
            InitializeComponent();
            frmParent = frm;
        }

        private void frmChiNhanhAdd_Load(object sender, EventArgs e)
        {
            if (entCatalogOld != null)
            {
                txtTen.EditValue = entCatalogOld.Ten;
                txtTenVietTat.EditValue = entCatalogOld.TenVietTat;
                txtDiaChi.EditValue = entCatalogOld.DiaChi;
                txtLienHe.EditValue = entCatalogOld.LienHe;
                txtThuTu.EditValue = entCatalogOld.ThuTu;
                txtChuThich.EditValue = entCatalogOld.ChuThich;
                chkTrangThai.CheckState = MTCheckbox.State(entCatalogOld.TrangThai);
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

        private bool SaveRecord()
        {
            string branchName = MTString.TextClean(txtTen.EditValue);
            if (branchName.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Tên chi nhánh", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            string branchShortName = MTString.TextClean(txtTenVietTat.EditValue);
            if (branchShortName.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Tên viết tắt", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenVietTat.Focus();
                return false;
            }
            string branchAddress = MTString.TextClean(txtDiaChi.EditValue);
            if (branchAddress.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Địa chỉ", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }
            string branchContact = MTString.TextClean(txtLienHe.EditValue);
            if (branchContact.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Liên hệ", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLienHe.Focus();
                return false;
            }
            bool updateStatus = false;
            try
            {
                using (var dbContext = new InventoryDbContext())
                {
                    dbContext.DeferredLoadingEnabled = false;
                    var lstChiNhanh = (from tt in dbContext.DmChiNhanh
                                       where (tt.Ten == branchName) &&
                                             (entCatalogOld == null || tt.Id != entCatalogOld.Id)
                                       select tt.Id);
                    if (lstChiNhanh.Count() > 0)
                    {
                        XtraMessageBox.Show("Tên chi nhánh đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTen.Focus();
                        return false;
                    }
                    lstChiNhanh = (from tt in dbContext.DmChiNhanh
                                   where (tt.TenVietTat == branchShortName) &&
                                         (entCatalogOld == null || tt.Id != entCatalogOld.Id)
                                   select tt.Id);
                    if (lstChiNhanh.Count() > 0)
                    {
                        XtraMessageBox.Show("Tên viết tắt đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTenVietTat.Focus();
                        return false;
                    }
                    if (entCatalogOld == null)
                    {
                        DmChiNhanh entCatalog = new DmChiNhanh
                        {
                            Ten = branchName,
                            TenVietTat = branchShortName,
                            DiaChi = branchAddress,
                            LienHe = branchContact,
                            ThuTu = Convert.ToInt32(txtThuTu.EditValue),
                            ChuThich = MTString.TextClean(txtChuThich.EditValue),
                            TrangThai = MTCheckbox.Int32Value(chkTrangThai.CheckState)
                        };
                        dbContext.DmChiNhanh.InsertOnSubmit(entCatalog);
                        dbContext.SubmitChanges();
                    }
                    else
                    {
                        entCatalogOld.Detach();
                        dbContext.DmChiNhanh.Attach(entCatalogOld);

                        entCatalogOld.Ten = branchName;
                        entCatalogOld.TenVietTat = branchShortName;
                        entCatalogOld.DiaChi = branchAddress;
                        entCatalogOld.LienHe = branchContact;
                        entCatalogOld.ThuTu = Convert.ToInt32(txtThuTu.EditValue);
                        entCatalogOld.ChuThich = MTString.TextClean(txtChuThich.EditValue);
                        entCatalogOld.TrangThai = MTCheckbox.Int32Value(chkTrangThai.CheckState);
                        dbContext.SubmitChanges();
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
                frmParent.BindData();

                if (ToolbarDm.SenderName == INVENTORY.CONTROL.ToolbarDm.Action.Save)
                {
                    ToolbarDm.DisableTool = INVENTORY.CONTROL.ToolbarDm.Action.Save;
                }
                else if (ToolbarDm.SenderName == INVENTORY.CONTROL.ToolbarDm.Action.SaveAdd)
                {
                    entCatalogOld = null;

                    txtTen.EditValue = null;
                    txtTenVietTat.EditValue = null;
                    txtDiaChi.EditValue = null;
                    txtLienHe.EditValue = null;
                    txtThuTu.EditValue = 0;
                    chkTrangThai.CheckState = CheckState.Checked;
                    txtTen.Focus();           
                }
                return true;
            }
            else
            {
                XtraMessageBox.Show("Cập nhật Thông tin Chi nhánh Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
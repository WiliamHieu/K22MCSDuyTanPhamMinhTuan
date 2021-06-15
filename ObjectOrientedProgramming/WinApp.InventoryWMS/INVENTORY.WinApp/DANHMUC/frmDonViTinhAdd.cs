using System;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.DANHMUC
{
    public partial class frmDonViTinhAdd : DevExpress.XtraEditors.XtraForm
    {
        private Form frmParent = null;
        public DmDonViTinh entCatalogOld = null;

        public frmDonViTinhAdd(Form frm)
        {
            InitializeComponent();
            frmParent = frm;
        }

        private void frmDonViTinhAdd_Load(object sender, EventArgs e)
        {
            if (entCatalogOld != null)
            {
                txtTen.EditValue = entCatalogOld.Ten;
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
            string unitName = MTString.TextClean(txtTen.EditValue);
            if (unitName.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Tên đơn vị tính", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            bool updateStatus = false;
            Guid IdDonViTinh = Guid.Empty;
            try
            {
                using (var dbContext = new InventoryDbContext())
                {
                    if (entCatalogOld == null)
                    {
                        if (dbContext.DmDonViTinh.ByTen(unitName).Count() > 0)
                        {
                            XtraMessageBox.Show("Tên đơn vị tính đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTen.Focus();
                            return false;
                        }
                        DmDonViTinh entCatalog = new DmDonViTinh
                        {
                            Id = Guid.NewGuid(),
                            Ten = unitName,
                            ThuTu = Convert.ToInt32(txtThuTu.EditValue),
                            ChuThich = MTString.TextClean(txtChuThich.EditValue),
                            TrangThai = MTCheckbox.Int32Value(chkTrangThai.CheckState)
                        };
                        dbContext.DmDonViTinh.InsertOnSubmit(entCatalog);
                        dbContext.SubmitChanges();

                        IdDonViTinh = entCatalog.Id;
                    }
                    else
                    {
                        if (dbContext.DmDonViTinh.ByTen(unitName).Where(d => d.Id != entCatalogOld.Id).Count() > 0)
                        {
                            XtraMessageBox.Show("Tên đơn vị tính đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTen.Focus();
                            return false;
                        }
                        entCatalogOld.Detach();
                        dbContext.DmDonViTinh.Attach(entCatalogOld);

                        entCatalogOld.Ten = unitName;
                        entCatalogOld.ThuTu = Convert.ToInt32(txtThuTu.EditValue);
                        entCatalogOld.ChuThich = MTString.TextClean(txtChuThich.EditValue);
                        entCatalogOld.TrangThai = MTCheckbox.Int32Value(chkTrangThai.CheckState);
                        dbContext.SubmitChanges();

                        IdDonViTinh = entCatalogOld.Id;
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
                if (frmParent.GetType() == typeof(frmDonViTinh))
                    ((frmDonViTinh)frmParent).BindData();

                if (ToolbarDm.SenderName == INVENTORY.CONTROL.ToolbarDm.Action.Save)
                {
                    ToolbarDm.DisableTool = INVENTORY.CONTROL.ToolbarDm.Action.Save;
                }
                else if (ToolbarDm.SenderName == INVENTORY.CONTROL.ToolbarDm.Action.SaveAdd)
                {
                    entCatalogOld = null;

                    txtTen.EditValue = null;
                    txtThuTu.EditValue = null;
                    chkTrangThai.CheckState = CheckState.Checked;
                    txtChuThich.EditValue = string.Empty;
                    txtTen.Focus();
                }
                return true;
            }
            else
            {
                XtraMessageBox.Show("Cập nhật Thông tin Đơn vị tính Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
using System;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.DANHMUC
{
    public partial class frmNguonNhapAdd : DevExpress.XtraEditors.XtraForm
    {
        private Form frmParent = null;
        public DmNguonNhap entCatalogOld = null;

        public frmNguonNhapAdd(Form frm)
        {
            InitializeComponent();
            frmParent = frm;
        }

        private void frmNguonNhapAdd_Load(object sender, EventArgs e)
        {
            if (entCatalogOld != null)
            {
                txtTen.EditValue = entCatalogOld.Ten;
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

        private void chkTrangThai_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            e.Appearance.BackColor = System.Drawing.Color.White;
            e.Appearance.ForeColor = System.Drawing.Color.Black;
        }

        private bool SaveRecord()
        {
            string supplyName = MTString.TextClean(txtTen.EditValue);
            if (supplyName.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Tên nguồn nhập", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            string supplyAddress = MTString.TextClean(txtDiaChi.EditValue);
            if (supplyAddress.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Địa chỉ", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }
            Guid IdNguonNhap = Guid.Empty;
            bool updateStatus = false;
            try
            {
                using (var dbContext = new InventoryDbContext())
                {
                    if (entCatalogOld == null)
                    {
                        if (dbContext.DmNguonNhap.ByTen(supplyName).Count() > 0)
                        {
                            XtraMessageBox.Show("Tên nguồn nhập đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTen.Focus();
                            return false;
                        }
                        DmNguonNhap entCatalog = new DmNguonNhap
                        {
                            Id = Guid.NewGuid(),
                            Ten = supplyName,
                            DiaChi = supplyAddress,
                            ThuTu = Convert.ToInt32(txtThuTu.EditValue),
                            ChuThich = MTString.TextClean(txtChuThich.EditValue),
                            TrangThai = MTCheckbox.Int32Value(chkTrangThai.CheckState)
                        };
                        dbContext.DmNguonNhap.InsertOnSubmit(entCatalog);
                        dbContext.SubmitChanges();

                        IdNguonNhap = entCatalog.Id;
                    }
                    else
                    {
                        if (dbContext.DmNguonNhap.ByTen(supplyName).Where(d => d.Id != entCatalogOld.Id).Count() > 0)
                        {
                            XtraMessageBox.Show("Tên nguồn nhập đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTen.Focus();
                            return false;
                        }
                        entCatalogOld.Detach();
                        dbContext.DmNguonNhap.Attach(entCatalogOld);

                        entCatalogOld.Ten = supplyName;
                        entCatalogOld.DiaChi = supplyAddress;
                        entCatalogOld.ThuTu = Convert.ToInt32(txtThuTu.EditValue);
                        entCatalogOld.ChuThich = MTString.TextClean(txtChuThich.EditValue);
                        entCatalogOld.TrangThai = MTCheckbox.Int32Value(chkTrangThai.CheckState);
                        dbContext.SubmitChanges();

                        IdNguonNhap = entCatalogOld.Id;
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
                if (frmParent.GetType() == typeof(frmNguonNhap))
                    ((frmNguonNhap)frmParent).BindData();

                if (ToolbarDm.SenderName == INVENTORY.CONTROL.ToolbarDm.Action.Save)
                {
                    ToolbarDm.DisableTool = INVENTORY.CONTROL.ToolbarDm.Action.Save;
                }
                else if (ToolbarDm.SenderName == INVENTORY.CONTROL.ToolbarDm.Action.SaveAdd)
                {
                    entCatalogOld = null;

                    txtTen.EditValue = null;
                    txtDiaChi.EditValue = null;
                    txtLienHe.EditValue = null;
                    txtThuTu.EditValue = null;
                    chkTrangThai.CheckState = CheckState.Checked;
                    txtChuThich.EditValue = string.Empty;
                    txtTen.Focus();
                }
                return true;
            }
            else
            {
                XtraMessageBox.Show("Cập nhật Thông tin Nguồn nhập Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
using System;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.DANHMUC
{
    public partial class frmBoPhanAdd : DevExpress.XtraEditors.XtraForm
    {
        private Form frmParent = null;
        public DmBoPhan entCatalogOld = null;

        public frmBoPhanAdd(Form frm)
        {
            InitializeComponent();
            frmParent = frm;
        }

        private void frmBoPhanAdd_Load(object sender, EventArgs e)
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
            string Ten = MTString.TextClean(txtTen.EditValue);
            if (Ten.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Tên bộ phận", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            bool updateStatus = false;
            try
            {
                using (var dbContext = new InventoryDbContext())
                {
                    if (entCatalogOld == null)
                    {
                        if (dbContext.DmBoPhan.ByTen(Ten).Count() > 0)
                        {
                            XtraMessageBox.Show("Tên bộ phận đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTen.Focus();
                            return false;
                        }
                        DmBoPhan entCatalog = new DmBoPhan
                        {
                            Id = Guid.NewGuid(),
                            Ten = Ten,
                            ThuTu = Convert.ToInt32(txtThuTu.EditValue),
                            ChuThich = MTString.TextClean(txtChuThich.EditValue),
                            TrangThai = MTCheckbox.Int32Value(chkTrangThai.CheckState)
                        };
                        dbContext.DmBoPhan.InsertOnSubmit(entCatalog);
                        dbContext.SubmitChanges();
                    }
                    else
                    {
                        if (dbContext.DmBoPhan.ByTen(Ten).Where(d => d.Id != entCatalogOld.Id).Count() > 0)
                        {
                            XtraMessageBox.Show("Tên bộ phận đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTen.Focus();
                            return false;
                        }
                        entCatalogOld.Detach();
                        dbContext.DmBoPhan.Attach(entCatalogOld);

                        entCatalogOld.Ten = Ten;
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
                if (frmParent.GetType() == typeof(frmBoPhan))
                    ((frmBoPhan)frmParent).BindData();

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
                XtraMessageBox.Show("Cập nhật Thông tin Bộ phận Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.HETHONG
{
    public partial class frmVaiTroAdd : DevExpress.XtraEditors.XtraForm
    {
        frmVaiTro frmParent = null;
        public HtVaiTro entCatalogOld = null;

        public frmVaiTroAdd(frmVaiTro frm)
        {
            InitializeComponent();
            frmParent = frm;
        }

        private void frmVaiTroAdd_Load(object sender, EventArgs e)
        {
            if (entCatalogOld != null)
            {
                txtTen.Text = entCatalogOld.Ten;
                txtThuTu.EditValue = entCatalogOld.ThuTu;
                txtChuThich.Text = entCatalogOld.ChuThich;
                chkTrangThai.Items[0].CheckState = MTCheckbox.State(entCatalogOld.TrangThai);
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
            string Ten = MTString.TextClean(txtTen.EditValue);
            if (Ten.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Tên vai trò", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        if (dbContext.HtVaiTro.ByTen(Ten).Count() > 0)
                        {
                            XtraMessageBox.Show("Tên vai trò đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTen.Focus();
                            return false;
                        }
                        HtVaiTro entCatalog = new HtVaiTro
                        {
                            Ten = Ten,
                            ThuTu = Convert.ToInt32(txtThuTu.EditValue),
                            ChuThich = MTString.TextClean(txtChuThich.EditValue),
                            TrangThai = MTCheckbox.Int32Value(chkTrangThai.Items[0].CheckState)
                        };
                        dbContext.HtVaiTro.InsertOnSubmit(entCatalog);
                        dbContext.SubmitChanges();
                    }
                    else
                    {
                        if (dbContext.HtVaiTro.ByTen(Ten).Where(d => d.Id != entCatalogOld.Id).Count() > 0)
                        {
                            XtraMessageBox.Show("Tên vai trò đã tồn tại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTen.Focus();
                            return false;
                        }
                        entCatalogOld.Detach();
                        dbContext.HtVaiTro.Attach(entCatalogOld);

                        entCatalogOld.Ten = Ten;
                        entCatalogOld.ThuTu = Convert.ToInt32(txtThuTu.EditValue);
                        entCatalogOld.ChuThich = MTString.TextClean(txtChuThich.EditValue);
                        entCatalogOld.TrangThai = MTCheckbox.Int32Value(chkTrangThai.Items[0].CheckState);
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
                    txtTen.EditValue = string.Empty;
                    txtThuTu.EditValue = 0;
                    chkTrangThai.Items[0].CheckState = CheckState.Checked;
                    txtChuThich.EditValue = string.Empty;
                    txtTen.Focus();
                }
                return true;
            }
            else
            {
                XtraMessageBox.Show("Cập nhật Thông tin Vai trò Thất bại", AppSetting.MessageCaption(),  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
using System;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.HETHONG
{
    public partial class frmNguoiDungEdit : DevExpress.XtraEditors.XtraForm
    {
        public frmNguoiDungEdit()
        {
            InitializeComponent();
        }

        private void frmNguoiDungEdit_Load(object sender, EventArgs e)
        {
            if (AppSetting.entNguoiDung != null)
            {
                txtTen.Text = AppSetting.entNguoiDung.Ten;
                txtTenTruyCap.Text = AppSetting.entNguoiDung.TenTruyCap;
            }
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
            string Ten = MTString.TextClean(txtTen.EditValue);
            if (Ten.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Tên người dùng", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            string MatKhau = MTString.TextClean(txtMatKhau.EditValue);

            bool updateStatus = false;
            try
            {
                using (var dbContext = new InventoryDbContext())
                {
                    var entCatalog = dbContext.HtNguoiDung.ById(AppSetting.entNguoiDung.Id).FirstOrDefault();
                    entCatalog.Ten = MTString.TextClean(txtTen.EditValue);
                    if (MatKhau.Length != 0) entCatalog.MatKhau = MTString.TextEncrypt(MatKhau);
                    dbContext.SubmitChanges();

                    AppSetting.entNguoiDung = entCatalog;
                }
                updateStatus = true;
            }
            catch (Exception)
            {
                updateStatus = false;
            }
            if (updateStatus)
            {
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
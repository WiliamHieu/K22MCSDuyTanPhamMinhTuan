using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            this.txtUsername.Focus();
            base.OnShown(e);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            AppSetting.AppPath = Application.StartupPath;
            BindCatalog.Server_BindDropDown(cboServer);

            string Username = MTRegistry.ReadWithDecrypt("Username");
            string Password = MTRegistry.ReadWithDecrypt("Password");
            string Server = MTRegistry.ReadWithDecrypt("Server");

            if (Username.Length > 0) Username = MTString.TextEncrypt(Username, false);
            if (Password.Length > 0) Password = MTString.TextEncrypt(Password, false);

            if (Server.Length > 0) cboServer.EditValue = Server;
            if (Username.Length > 0 && Password.Length > 0)
            {
                txtUsername.EditValue = Username;
                txtPassword.EditValue = Password;
                chkRemember.Checked = true;
            }
            else
            {
                chkRemember.Checked = false;
            }
            lblSecurityCode.Text = MTSystem.SecurityCode();
            txtUsername.Focus();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdLogin_Click(sender, e);
            }
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (cboServer.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn Máy chủ", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboServer.Focus();
                return;
            }
            if (MTString.Length(txtUsername.EditValue) == 0)
            {
                XtraMessageBox.Show("Chưa nhập Tên truy cập", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (MTString.Length(txtPassword.EditValue) == 0)
            {
                XtraMessageBox.Show("Chưa nhập Mật khẩu", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            string Username = MTString.TextClean(txtUsername.EditValue);
            string Password = MTString.TextClean(txtPassword.EditValue);
            Password = MTString.TextEncrypt(Password);
            if (Username.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Tên truy cập", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (Password.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Mật khẩu", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            //if (cboServer.EditValue != null)
            //{
            //    bool pingOk = MTSystem.Ping(cboServer.EditValue.ToString());
            //    if (pingOk == false)
            //    {
            //        XtraMessageBox.Show("Truy cập máy chủ không Thành công", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        cboServer.Focus();
            //        return;
            //    }
            //}
            string checkSetting = AppSetting.Setting_GetList();
            if (checkSetting.Length > 0)
            {
                PanelError.Visible = true;
                return;
            }
            GroupInfor.Text = AppSetting.MessageCaption();
            using (var dbContext = new InventoryDbContext())
            {
                var entNguoiDung = dbContext.HtNguoiDung.ByTenTruyCap(Username).FirstOrDefault();
                if (entNguoiDung == null)
                {
                    XtraMessageBox.Show("Người dùng không tồn tại trong hệ thống", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    return;
                }
                if (entNguoiDung.TrangThai == 0 || entNguoiDung.TrangThai == -1)
                {
                    XtraMessageBox.Show("Người dùng đã bị khóa", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    return;
                }
                if (entNguoiDung.DangNhap == false)
                {
                    XtraMessageBox.Show("Người dùng không có quyền trong hệ thống", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    return;
                }
                if (Password.Equals(entNguoiDung.MatKhau))
                {
                    var lstNguoiDungVaiTro = dbContext.HtNguoiDungVaiTro.ByIdNguoiDung(entNguoiDung.Id).ToList();
                    if (lstNguoiDungVaiTro.Count == 0)
                    {
                        XtraMessageBox.Show("Người dùng không có quyền trong Hệ thống", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                        return;
                    }
                    AppSetting.entNguoiDung = entNguoiDung;
                    AppSetting.lstKhoHang = dbContext.CustomHtNguoiDungGetListKhoHang(entNguoiDung.Id).ToList();
                    var entKhoMacDinh = AppSetting.lstKhoHang.Where(d => d.MacDinh = true).FirstOrDefault();
                    if (entKhoMacDinh == null)
                    {
                        XtraMessageBox.Show("Người dùng không có quyền trong Hệ thống", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                        return;
                    }
                    AppSetting.entKhoHang = dbContext.DmKhoHang.ById(entKhoMacDinh.Id).FirstOrDefault();
                    AppSetting.lstQuyenHan = dbContext.HtQuyenHan.ByIdVaiTro(entKhoMacDinh.IdVaiTro).ToList();
                    AppSetting.entChiNhanh = dbContext.DmChiNhanh.ById(AppSetting.entKhoHang.IdChiNhanh).FirstOrDefault();

                    MTRegistry.WriteWithEncrypt("Server", cboServer.EditValue.ToString());
                    if (chkRemember.Checked)
                    {
                        MTRegistry.WriteWithEncrypt("Username", MTString.TextEncrypt(Username, true));
                        MTRegistry.WriteWithEncrypt("Password", MTString.TextEncrypt(MTString.Text(txtPassword.EditValue), true));
                    }
                    else
                    {
                        MTRegistry.WriteWithEncrypt("Username", string.Empty);
                        MTRegistry.WriteWithEncrypt("Password", string.Empty);
                    }
                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.Show();
                }
                else
                {
                    XtraMessageBox.Show("Mật khẩu không đúng", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }
    }
}
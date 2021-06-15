using DevExpress.XtraEditors;
using INVENTORY.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace INVENTORY.WinApp.KHOHANG
{
    public partial class frmPhieuNhapModify : XtraForm
    {
        Form frmParent = null;

        private CustomDmLoaiVatTuGetDropDownResult entLoaiVatTu = null;

        public int IdKhoHang = 0;
        public DataRow rowPhieuNhapCt = null;

        public frmPhieuNhapModify(Form frm)
        {
            InitializeComponent();
            frmParent = frm;
        }

        private void frmPhieuNhapModify_Load(object sender, EventArgs e)
        {
            BindCatalog.DmLoaiVatTu_BindDropDown(cboLoaiVatTu, IdKhoHang, Guid.Empty, 0);
            if (rowPhieuNhapCt != null)
            {
                cboLoaiVatTu.EditValue = rowPhieuNhapCt["IdLoaiVatTu"];
                txtChuThich.EditValue = rowPhieuNhapCt["ChuThich"];
            }
        }

        private void cboLoaiVatTu_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if ((e.CloseMode == PopupCloseMode.ButtonClick || e.CloseMode == PopupCloseMode.Normal) && e.AcceptValue && e.Value != null)
            {
                entLoaiVatTu = cboLoaiVatTu.Properties.GetRowByKeyValue(e.Value) as CustomDmLoaiVatTuGetDropDownResult;
            }
        }

        private void chkLoaiVatTu_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkLoaiVatTu.Checked) cboLoaiVatTu.EditValue = null;
        }

        private void chkChuThich_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkChuThich.Checked) txtChuThich.EditValue = null;
        }

        private void ToolbarLd_Clicked(object sender, EventArgs e)
        {
            switch (ToolbarLd.SenderName)
            {
                case INVENTORY.CONTROL.ToolbarLd.Action.SaveClose:
                    if (!SaveRecord()) return;
                    DialogResult = DialogResult.OK;
                    this.Close();
                    break;
                case INVENTORY.CONTROL.ToolbarLd.Action.Close:
                    this.Close();
                    break;
            }
        }

        private bool SaveRecord()
        {
            if (chkLoaiVatTu.Checked && cboLoaiVatTu.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn Loại vật tư", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiVatTu.Focus();
                return false;
            }
            if (chkChuThich.Checked && MTString.Length(txtChuThich.EditValue) == 0)
            {
                XtraMessageBox.Show("Chưa nhập Chú thích", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChuThich.Focus();
                return false;
            }
            if (!chkLoaiVatTu.Checked && !chkChuThich.Checked)
            {
                cboLoaiVatTu.EditValue = null;
                txtChuThich.EditValue = null;
            }
            if (chkLoaiVatTu.Checked && cboLoaiVatTu.EditValue != null)
            {
                Guid IdLoaiVatTu = new Guid(cboLoaiVatTu.EditValue.ToString());
                if (IdLoaiVatTu != new Guid(rowPhieuNhapCt["IdLoaiVatTu"].ToString()))
                {
                    using (var dbContext = new InventoryDbContext())
                    {
                        if (dbContext.KhSanPham.Where(d => d.SoLuongTon != d.SoLuongNhap).Any(d => d.IdSanPham == MTValue.Guid(rowPhieuNhapCt["IdSanPham"])))
                        {
                            XtraMessageBox.Show(rowPhieuNhapCt["TenLoaiVatTu"] + " đã thay đổi Hàng tồn nên không thể Thay đổi Loại vật tư", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cboLoaiVatTu.Focus();
                            return false;
                        }
                    }
                }
                rowPhieuNhapCt["IdLoaiVatTu"] = cboLoaiVatTu.EditValue;
                rowPhieuNhapCt["TenLoaiVatTu"] = entLoaiVatTu.Ten;
                rowPhieuNhapCt["TenDonViTinh"] = entLoaiVatTu.TenDonViTinh;
                rowPhieuNhapCt["QuyCach"] = entLoaiVatTu.QuyCach;
            }
            if (chkChuThich.Checked)
            {
                rowPhieuNhapCt["ChuThich"] = MTString.TextClean(txtChuThich.EditValue);
            }
            if (Convert.ToInt32(rowPhieuNhapCt["Status"]) == 1) rowPhieuNhapCt["Status"] = 2;

            if (frmParent.GetType() == typeof(frmPhieuNhapAdd))
                ((frmPhieuNhapAdd)frmParent).HangNhap_Update();
            if (frmParent.GetType() == typeof(frmPhieuNhapEdit))
                ((frmPhieuNhapEdit)frmParent).HangNhap_Update();

            return true;
        }
    }
}
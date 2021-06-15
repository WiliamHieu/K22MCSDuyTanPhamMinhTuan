using System;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using INVENTORY.Data;

namespace INVENTORY.WinApp.HETHONG
{
    public partial class frmThietLap : DevExpress.XtraEditors.XtraForm
    {
        private HtThietLap entThietLap = null;

        public frmThietLap()
        {
            InitializeComponent();
        }

        private void frmThietLap_Load(object sender, EventArgs e)
        {
            if (!oSecurity.CheckEdit(this.Name))
                ToolbarLd.DisableTool = INVENTORY.CONTROL.ToolbarLd.Action.SaveClose;

            BindCatalog.KieuKhoa_BindDropDown(cboKieuKhoa);

            using (var dbContext = new InventoryDbContext())
            {
                entThietLap = dbContext.HtThietLap.ById(1).FirstOrDefault();
                txtTenPhanMem.EditValue = entThietLap.TenPhanMem;
                spSoNgayDuLieu.EditValue = entThietLap.NgayDuLieu;
                cboKieuKhoa.EditValue = entThietLap.KieuKhoa;
                spSoGioKhoa.EditValue = entThietLap.ThoiGianKhoa;
                chkXoaQuaNgay.Items[0].CheckState = MTCheckbox.State(entThietLap.XoaQuaNgay);
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
            string sTenPhanMem = MTString.TextClean(txtTenPhanMem.EditValue);
            if (sTenPhanMem.Length == 0)
            {
                XtraMessageBox.Show("Chưa nhập Tên phần mềm", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhanMem.Focus();
                return false;
            }
            if (spSoNgayDuLieu.EditValue == null)
            {
                XtraMessageBox.Show("Chưa nhập Số ngày dữ liệu", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spSoNgayDuLieu.Focus();
                return false;
            }
            if (cboKieuKhoa.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn Kiểu khóa dữ liệu", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKieuKhoa.Focus();
                return false;
            }
            if (spSoGioKhoa.EditValue == null)
            {
                XtraMessageBox.Show("Chưa nhập Số giờ khóa sửa đổi", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spSoGioKhoa.Focus();
                return false;
            }
            if (Convert.ToInt32(cboKieuKhoa.EditValue) == 0)
            {
                if (Convert.ToInt32(spSoGioKhoa.EditValue) > 12)
                {
                    XtraMessageBox.Show("Số giờ Khóa phải >=0 và <=12", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    spSoGioKhoa.Focus();
                    return false;
                }
            }
            try
            {
                using (var dbContext = new InventoryDbContext())
                {
                    dbContext.HtThietLap.Attach(entThietLap);
                    entThietLap.TenPhanMem = MTString.TextClean(txtTenPhanMem.EditValue);
                    entThietLap.NgayDuLieu = Convert.ToInt32(spSoNgayDuLieu.EditValue);
                    entThietLap.KieuKhoa = Convert.ToInt32(cboKieuKhoa.EditValue);
                    entThietLap.ThoiGianKhoa = Convert.ToInt32(spSoGioKhoa.EditValue);
                    entThietLap.XoaQuaNgay = MTCheckbox.BoolValue(chkXoaQuaNgay.Items[0].CheckState);
                    dbContext.SubmitChanges();
                }

                AppSetting.entThietLap = entThietLap;

                return true;
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Cập nhật Thiết lập Thất bại", AppSetting.MessageCaption(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
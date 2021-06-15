using System.Data;

namespace INVENTORY.WinApp.BAOCAO.BIEUMAU
{
    public partial class rpPhieuChuyen : DevExpress.XtraReports.UI.XtraReport
    {
        public rpPhieuChuyen()
        {
            InitializeComponent();
        }

        public void LoadData(DataTable dtThongTinChung, DataTable dtThongTinChiTiet)
        {
            pbLogo.Image = AppSetting.entCompany.Logo;
            lblTenCongTy.Text = AppSetting.entChiNhanh.Ten.ToUpper();
            lblDiaChi.Text = AppSetting.entChiNhanh.DiaChi;
            lblDienThoai.Text = AppSetting.entChiNhanh.LienHe;

            phieuNhapXuat1.ThongTinChung.Merge(dtThongTinChung, false);
            phieuNhapXuat1.ThongTinChiTiet.Merge(dtThongTinChiTiet, false);
        }
    }
}

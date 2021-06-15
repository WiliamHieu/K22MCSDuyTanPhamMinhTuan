using System.Data;
using System.Drawing;

using DevExpress.XtraReports.UI;

using INVENTORY.Data;

public class oReport
{
    public static DataRow rowChiNhanh = null;
    public static DataTable dtThongTinPhieu = null;
    public static DataTable dtThongTinSanPham = null;
    public static Point location = new Point(0, 0);

    public static void KH_PhieuNhap_Print(DataTable dtThongTinPhieu, DataTable dtThongTinSanPham)
    {
        INVENTORY.WinApp.BAOCAO.BIEUMAU.rpPhieuNhap rpPhieuNhap = new INVENTORY.WinApp.BAOCAO.BIEUMAU.rpPhieuNhap();
        rpPhieuNhap.LoadData(dtThongTinPhieu, dtThongTinSanPham);
        rpPhieuNhap.ShowPreviewDialog();
    }

    public static void KH_PhieuXuat_Print(DataTable dtThongTinPhieu, DataTable dtThongTinSanPham)
    {
        INVENTORY.WinApp.BAOCAO.BIEUMAU.rpPhieuXuat rpPhieuXuat = new INVENTORY.WinApp.BAOCAO.BIEUMAU.rpPhieuXuat();
        rpPhieuXuat.LoadData(dtThongTinPhieu, dtThongTinSanPham);
        rpPhieuXuat.ShowPreviewDialog();
    }

    public static void KH_PhieuChuyen_Print(DataTable dtThongTinPhieu, DataTable dtThongTinSanPham)
    {
        INVENTORY.WinApp.BAOCAO.BIEUMAU.rpPhieuChuyen rpPhieuChuyen = new INVENTORY.WinApp.BAOCAO.BIEUMAU.rpPhieuChuyen();
        rpPhieuChuyen.LoadData(dtThongTinPhieu, dtThongTinSanPham);
        rpPhieuChuyen.ShowPreviewDialog();
    }

    public static DataTable KH_PhieuNhap_GetTable(KhPhieuNhap entPhieuNhap)
    {
        DataTable dtThongTinPhieu = new INVENTORY.WinApp.DATASET.PhieuNhapXuat.ThongTinChungDataTable();
        DmNguonNhap entNguonNhap = oFunction.DmNguonNhap_Entity(entPhieuNhap.IdNguonNhap);

        DataRow rowPhieu = dtThongTinPhieu.NewRow();
        rowPhieu["SoPhieu"] = entPhieuNhap.SoPhieu;
        rowPhieu["TenKhoHang"] = AppSetting.entKhoHang.Ten;
        rowPhieu["TenKhoPhieu"] = "Kho: " + AppSetting.entKhoHang.Ten + "  -  Số phiếu: " + entPhieuNhap.SoPhieu;
        rowPhieu["NgayTao"] = "Ngày: " + entPhieuNhap.NgayTao.ToString("dd/MM/yyyy HH:mm");
        rowPhieu["TenDoiTuong"] = entNguonNhap.Ten;
        rowPhieu["TenNguoiTao"] = AppSetting.entNguoiDung.Ten;
        rowPhieu["ChuThich"] = entPhieuNhap.ChuThich;
        dtThongTinPhieu.Rows.Add(rowPhieu);
        return dtThongTinPhieu;
    }

    public static DataTable KH_PhieuXuat_GetTable(KhPhieuXuat entPhieuXuat, DmBoPhan entBoPhan)
    {
        DataTable dtThongTinPhieu = new INVENTORY.WinApp.DATASET.PhieuNhapXuat.ThongTinChungDataTable();
        DataRow rowPhieu = dtThongTinPhieu.NewRow();
        rowPhieu["SoPhieu"] = entPhieuXuat.SoPhieu;
        DmKhoHang entKhoHang = oFunction.DmKhoHang_Entity(entPhieuXuat.IdKhoHang);
        rowPhieu["TenKhoHang"] = entKhoHang.Ten;
        rowPhieu["TenKhoPhieu"] = "Kho: " + entKhoHang.Ten + "  -  Số phiếu: " + entPhieuXuat.SoPhieu;
        rowPhieu["NgayTao"] = "Ngày: " + entPhieuXuat.NgayTao.ToString("dd/MM/yyyy HH:mm");
        rowPhieu["TenDoiTuong"] = entBoPhan.Ten;
        rowPhieu["TenNguoiNhan"] = oFunction.HtNguoiDung_Entity(entPhieuXuat.IdNguoiNhan).Ten;
        rowPhieu["TenNguoiTao"] = AppSetting.entNguoiDung.Ten;
        rowPhieu["ChuThich"] = entPhieuXuat.ChuThich;
        dtThongTinPhieu.Rows.Add(rowPhieu);
        return dtThongTinPhieu;
    }

    public static DataTable KH_PhieuChuyen_GetTable(KhPhieuChuyen entPhieuChuyen)
    {
        DataTable dtThongTinPhieu = new INVENTORY.WinApp.DATASET.PhieuNhapXuat.ThongTinChungDataTable();
        DataRow rowPhieu = dtThongTinPhieu.NewRow();
        rowPhieu["SoPhieu"] = entPhieuChuyen.SoPhieu;
        rowPhieu["TenKhoHang"] = AppSetting.entKhoHang.Ten;
        rowPhieu["TenKhoPhieu"] = "Kho chuyển: " + AppSetting.entKhoHang.Ten + "  -  Số phiếu: " + entPhieuChuyen.SoPhieu;
        rowPhieu["NgayTao"] = "Ngày: " + entPhieuChuyen.NgayTao.ToString("dd/MM/yyyy HH:mm");
        rowPhieu["TenDoiTuong"] = oFunction.DmKhoHang_Entity(entPhieuChuyen.IdKhoNhan).Ten;
        rowPhieu["TenNguoiGiao"] = oFunction.HtNguoiDung_Entity(entPhieuChuyen.IdNguoiGiao).Ten;
        rowPhieu["TenNguoiTao"] = AppSetting.entNguoiDung.Ten;
        rowPhieu["ChuThich"] = entPhieuChuyen.ChuThich;
        dtThongTinPhieu.Rows.Add(rowPhieu);
        return dtThongTinPhieu;
    }
}

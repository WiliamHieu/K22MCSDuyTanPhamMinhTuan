using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;

using INVENTORY.Data;
using System.ComponentModel;

public static class oFunction
{
    public static string KhNhapXuat_Get_SoPhieu(string LoaiPhieu, InventoryDbContext dbContext, DateTime dtNgayHienTai)
    {
        if (dbContext == null) dbContext = new InventoryDbContext();
        if (LoaiPhieu.Equals("Nhap"))
        {
            var result = dbContext.CustomGenKhPhieuNhapGetSoPhieu(AppSetting.entKhoHang.Id, AppSetting.entKhoHang.TenVietTat, dtNgayHienTai.ToString("MMyy")).FirstOrDefault();
            return result?.SoPhieu;
        }
        else if (LoaiPhieu.Equals("Chuyen"))
        {
            var result = dbContext.CustomGenKhPhieuChuyenGetSoPhieu(AppSetting.entKhoHang.Id, AppSetting.entKhoHang.TenVietTat, dtNgayHienTai.ToString("MMyy")).FirstOrDefault();
            return result?.SoPhieu;
        }
        else if (LoaiPhieu.Equals("NhapNb"))
        {
            var result = dbContext.CustomGenKhPhieuNhapNbGetSoPhieu(AppSetting.entKhoHang.Id, dtNgayHienTai.ToString("MMyy")).FirstOrDefault();
            return result?.SoPhieu;
        }
        else if (LoaiPhieu.Equals("Xuat"))
        {
            var result = dbContext.CustomGenKhPhieuXuatGetSoPhieu(AppSetting.entKhoHang.Id, AppSetting.entKhoHang.TenVietTat, dtNgayHienTai.ToString("MMyy")).FirstOrDefault();
            return result?.SoPhieu;
        }
        return string.Empty;
    }

    public static string KhPhieuNhapNb_Get_SoPhieu(InventoryDbContext dbContext, int IdKhoNhan, DateTime dtNgayHienTai)
    {
        if (dbContext == null) dbContext = new InventoryDbContext();
        var result = dbContext.CustomGenKhPhieuNhapNbGetSoPhieu(IdKhoNhan, dtNgayHienTai.ToString("MMyy")).FirstOrDefault();
        return result != null ? result.SoPhieu : string.Empty;
    }

    public static DataTable KhNhapXuat_Get_ListChiTiet(string LoaiPhieu, InventoryDbContext dbContext, Guid IdPhieu)
    {
        if (dbContext == null) dbContext = new InventoryDbContext();
        DataTable dtResult = null;
        if (LoaiPhieu.Equals("Nhap"))
        {
            dtResult = ToDataTable(dbContext.CustomKhPhieuNhapGetListChiTiet(IdPhieu).ToList());
        }
        else if (LoaiPhieu.Equals("NhapDn"))
        {
            dtResult = ToDataTable(dbContext.CustomKhPhieuNhapGetListChiTietNb(IdPhieu).ToList());
        }
        else if (LoaiPhieu.Equals("Chuyen"))
        {
            dtResult = ToDataTable(dbContext.CustomKhPhieuChuyenGetListChiTiet(IdPhieu).ToList());
        }
        else if (LoaiPhieu.Equals("NhapNb"))
        {
            dtResult = ToDataTable(dbContext.CustomKhPhieuNhapNbGetListChiTiet(IdPhieu).ToList());
        }
        else if (LoaiPhieu.Equals("Xuat"))
        {
            dtResult = ToDataTable(dbContext.CustomKhPhieuXuatGetListChiTiet(IdPhieu).ToList());
        }
        return dtResult;
    }

    public static int KhPhieuNhap_Check_Delete(InventoryDbContext dbContext, Guid IdPhieuNhap, Guid? IdLoaiVatTu)
    {
        if (dbContext == null) dbContext = new InventoryDbContext();
        var result = dbContext.CustomKhPhieuNhapCheckDelete(IdPhieuNhap, IdLoaiVatTu).FirstOrDefault();
        return (int)(result?.SoDong.Value);
    }

    public static int KhSanPham_Get_SoLuong(InventoryDbContext dbContext, int IdKhoHang, Guid IdLoaiVatTu)
    {
        if (dbContext == null) dbContext = new InventoryDbContext();
        var result = dbContext.CustomKhSanPhamGetSoLuong(IdKhoHang, IdLoaiVatTu).FirstOrDefault();
        return (int)(result?.SoLuong.Value);
    }

    public static Guid KhPhieuNhapNb_Get_NguonNhap(InventoryDbContext dbContext, int IdKhoHang)
    {
        if (dbContext == null) dbContext = new InventoryDbContext();
        var result = dbContext.DmNguonKho.ByIdKhoHang(IdKhoHang).FirstOrDefault();
        return (Guid)(result?.IdNguonNhap);
    }

    public static string KhNhapXuat_Check_HangTon(InventoryDbContext dbContext, int IdKhoHang, DataTable dtPhieuXuatCt, bool checkEdit)
    {
        if (dbContext == null) dbContext = new InventoryDbContext();
        int SoLuongXuat = 0;
        foreach (DataRow row in dtPhieuXuatCt.Rows)
        {
            SoLuongXuat = checkEdit ? (Convert.ToInt32(row["SoLuong"]) - Convert.ToInt32(row["SoLuongOld"])) : Convert.ToInt32(row["SoLuong"]);
            if (KhSanPham_Get_SoLuong(dbContext, IdKhoHang, MTValue.Guid(row["IdLoaiVatTu"])) < SoLuongXuat)
            {
                return string.Format("Loại vật tư {0} không đủ số lượng xuất", row["TenListChiTiet"]);
            }
        }
        return string.Empty;
    }
    
    public static DataTable ToDataTable<T>(IList<T> data)
    {
        PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));

        DataTable table = new DataTable();

        foreach (PropertyDescriptor prop in properties)
            table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

        foreach (T item in data)
        {
            DataRow row = table.NewRow();
            foreach (PropertyDescriptor prop in properties)
            {
                row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
            }
            table.Rows.Add(row);
        }
        return table;
    }

    public static HtNguoiDung HtNguoiDung_Entity(int IdNguoiDung)
    {
        using (var dbContext = new InventoryDbContext())
        {
            return dbContext.HtNguoiDung.ById(IdNguoiDung).FirstOrDefault();
        }
    }

    public static DmKhoHang DmKhoHang_Entity(int IdKhoHang)
    {
        using (var dbContext = new InventoryDbContext())
        {
            return dbContext.DmKhoHang.ById(IdKhoHang).FirstOrDefault();
        }
    }

    public static DmNguonNhap DmNguonNhap_Entity(Guid IdNguonNhap)
    {
        using (var dbContext = new InventoryDbContext())
        {
            return dbContext.DmNguonNhap.ById(IdNguonNhap).FirstOrDefault();
        }
    }
}

public class oInitData
{
    public static DataTable TrangThai_InitTable()
    {
        DataTable dtTemp = new DataTable();
        dtTemp.Columns.Add(new DataColumn("Ten", typeof(string)));
        dtTemp.Columns.Add(new DataColumn("Id", typeof(int)));
        DataRow dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Kích hoạt";
        dcTemp["Id"] = 1;
        dtTemp.Rows.Add(dcTemp);
        dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Không";
        dcTemp["Id"] = 0;
        dtTemp.Rows.Add(dcTemp);
        dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Đã xóa";
        dcTemp["Id"] = -1;
        dtTemp.Rows.Add(dcTemp);
        return dtTemp;
    }

    public static DataTable KH_SanPham_InitTable()
    {
        DataTable dtTemp = new DataTable();
        dtTemp.Columns.Add(new DataColumn("Id", typeof(Guid)));
        dtTemp.Columns.Add(new DataColumn("IdSanPham", typeof(Guid)));
        dtTemp.Columns.Add(new DataColumn("IdNguonNhap", typeof(Guid)));
        dtTemp.Columns.Add(new DataColumn("IdLoaiVatTu", typeof(Guid)));
        dtTemp.Columns.Add(new DataColumn("IdLoaiVatTuOld", typeof(Guid)));
        dtTemp.Columns.Add(new DataColumn("TenLoaiVatTu", typeof(string)));
        dtTemp.Columns.Add(new DataColumn("QuyCach", typeof(string)));
        dtTemp.Columns.Add(new DataColumn("TenDonViTinh", typeof(string)));
        dtTemp.Columns.Add(new DataColumn("SoLuongTon", typeof(int)));
        dtTemp.Columns.Add(new DataColumn("SoLuong", typeof(int)));
        dtTemp.Columns.Add(new DataColumn("ChuThich", typeof(string)));
        dtTemp.Columns.Add(new DataColumn("Status", typeof(int)));
        return dtTemp;
    }
}

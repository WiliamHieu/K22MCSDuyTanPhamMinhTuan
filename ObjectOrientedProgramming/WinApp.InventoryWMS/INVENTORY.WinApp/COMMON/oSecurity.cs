using System;
using System.Linq;
using INVENTORY.Data;

public class oSecurity
{
    public static bool CheckView(string formName)
    {
        if (AppSetting.lstQuyenHan == null || AppSetting.lstQuyenHan.Count == 0) return false;
        var entResult = AppSetting.lstQuyenHan.Where(d => d.TenForm == GetFormName(formName)).FirstOrDefault();
        return entResult == null ? false : entResult.Xem;
    }

    public static bool CheckAdd(string formName)
    {
        if (AppSetting.lstQuyenHan == null || AppSetting.lstQuyenHan.Count == 0) return false;
        var entResult = AppSetting.lstQuyenHan.Where(d => d.TenForm == GetFormName(formName)).FirstOrDefault();
        return entResult == null ? false : entResult.Them;
    }

    public static bool CheckEdit(string formName)
    {
        if (AppSetting.lstQuyenHan == null || AppSetting.lstQuyenHan.Count == 0) return false;
        var entResult = AppSetting.lstQuyenHan.Where(d => d.TenForm == GetFormName(formName)).FirstOrDefault();
        return entResult == null ? false : entResult.Sua;
    }

    public static bool CheckDelete(string formName)
    {
        if (AppSetting.lstQuyenHan == null || AppSetting.lstQuyenHan.Count == 0) return false;
        var entResult = AppSetting.lstQuyenHan.Where(d => d.TenForm == GetFormName(formName)).FirstOrDefault();
        return entResult == null ? false : entResult.Xoa;
    }

    public static string GetFormName(string formName)
    {
        if (formName.Length > 0 && formName.Contains("frm"))
        {
            formName = formName.Remove(0, 3);
        }
        if (formName.Length > 0 && formName.Contains("Add"))
        {
            formName = formName.Replace("Add", "");
        }
        if (formName.Length > 0 && formName.Contains("Edit"))
        {
            formName = formName.Replace("Edit", "");
        }
        return formName;
    }

    public static bool CheckLockData(string formName, int IdNguoiTao, DateTime dtNgayTao, DateTime dtNgayHienTai)
    {
        if (!CheckEdit(formName))
        {
            return false;
        }
        else
        {
            using (var dbContext = new InventoryDbContext())
            {
                AppSetting.entThietLap = dbContext.HtThietLap.ById(1).FirstOrDefault();
                if (AppSetting.entThietLap.KieuKhoa.Equals(1))
                {
                    int countHours = MTDateTime.Hours(dtNgayTao, dtNgayHienTai);
                    if (countHours < AppSetting.entThietLap.ThoiGianKhoa && CheckNguoiTao(IdNguoiTao)) return true;
                    return false;
                }
                else if (AppSetting.entThietLap.KieuKhoa.Equals(2))
                {
                    int countMinutes = MTDateTime.Minute(dtNgayTao, dtNgayHienTai);
                    if (countMinutes < AppSetting.entThietLap.ThoiGianKhoa && CheckNguoiTao(IdNguoiTao)) return true;
                    return false;
                }
                else
                {
                    int countDates = MTDateTime.Days(dtNgayTao, dtNgayHienTai);
                    if (countDates != 0)
                    {
                        return false;
                    }
                    else
                    {
                        DateTime dtNgayHienTai12h = new DateTime(dtNgayHienTai.Year, dtNgayHienTai.Month, dtNgayHienTai.Day, 23, 59, 0);
                        int countHours = MTDateTime.Hours(dtNgayHienTai, dtNgayHienTai12h);
                        if (countHours < AppSetting.entThietLap.ThoiGianKhoa)
                        {
                            return false;
                        }
                    }
                }
                return CheckNguoiTao(IdNguoiTao);
            }
        }
    }

    private static bool CheckNguoiTao(int IdNguoiTao)
    {
        if (AppSetting.entNguoiDung.Id != 1 && AppSetting.entNguoiDung.Id != IdNguoiTao)
        {
            return false;
        }
        return true;
    }
}

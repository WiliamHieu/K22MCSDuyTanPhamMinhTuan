using System;
using System.Linq;
using System.Collections.Generic;

using INVENTORY.Data;

public class AppSetting
{
    public static string TenCongTy = string.Empty;
    public static string AppPath = string.Empty;
    public static string Password = string.Empty;

    public static Company entCompany;
    public static DmChiNhanh entChiNhanh;
    public static DmKhoHang entKhoHang = null;
    public static HtNguoiDung entNguoiDung = null;
    public static List<CustomHtNguoiDungGetListKhoHangResult> lstKhoHang = null;
    public static List<HtQuyenHan> lstQuyenHan = null;
    public static HtThietLap entThietLap = null;

    public static void Company_Init()
    {
        if (TenCongTy.Equals("K22MCS"))
        {
            entCompany = new Company
            {
                Server = "192.168.1.254_Local Server",
                DBName = "INVENTORY",
                DBUser = "inventory",
                Logo = global::INVENTORY.WinApp.Properties.Resources.Logo
            };
        }
    }

    public static DateTime DateTime_GetServer()
    {
        using (var dbContext = new InventoryDbContext())
        {
            var entNgayThang = dbContext.CustomHtNgayThangGetValue().FirstOrDefault();
            return entNgayThang != null ? entNgayThang.ServerDateTime : DateTime.Now;
        }
    }

    public static DateTime DateTime_GetServer(InventoryDbContext dbContext)
    {
        var entNgayThang = dbContext.CustomHtNgayThangGetValue().FirstOrDefault();
        return entNgayThang != null ? entNgayThang.ServerDateTime : DateTime.Now;
    }

    public static string MessageCaption()
    {
        return entThietLap != null ? entThietLap.TenPhanMem : "Inventory WMS";
    }

    public static string Setting_GetList()
    {
        try
        {
            using (var dbContext = new InventoryDbContext())
            {
                entThietLap = dbContext.HtThietLap.ById(1).FirstOrDefault();
            }
            return string.Empty;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
}

public class Company
{
    public Company()
    {
        Server = string.Empty;
    }

    public string Server { get; set; }

    public string DBName { get; set; }

    public string DBUser { get; set; }

    public System.Drawing.Image Logo { set; get; }
}

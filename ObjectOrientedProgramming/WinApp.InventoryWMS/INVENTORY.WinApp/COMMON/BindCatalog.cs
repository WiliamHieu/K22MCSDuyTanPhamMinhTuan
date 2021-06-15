using System;
using System.Data;
using System.Linq;
using DevExpress.XtraEditors;

using INVENTORY.Data;

public class BindCatalog
{
    public static void Server_BindDropDown(LookUpEdit cboTemp)
    {
        DataTable dtTemp = new DataTable();
        dtTemp.Columns.Add(new DataColumn("Ten", typeof(string)));
        dtTemp.Columns.Add(new DataColumn("MayChu", typeof(string)));

        string[] aServer = AppSetting.entCompany.Server.Split(',');
        foreach (string server in aServer)
        {
            string[] aKhoHang = server.Split('_');
            DataRow dcTemp = dtTemp.NewRow();
            dcTemp["Ten"] = MTString.Text(aKhoHang.GetValue(1));
            dcTemp["MayChu"] = MTString.Text(aKhoHang.GetValue(0));
            dtTemp.Rows.Add(dcTemp);
        }
        cboTemp.Properties.DisplayMember = "Ten";
        cboTemp.Properties.ValueMember = "MayChu";
        cboTemp.Properties.DataSource = dtTemp;

        cboTemp.EditValue = null;
        cboTemp.Properties.NullText = " -- Máy chủ --";
    }

    public static void DmChiNhanh_BindDropDown(LookUpEdit cboTemp)
    {
        using (var dbContext = new InventoryDbContext())
        {
            var lstTemp = dbContext.DmChiNhanh.ByTrangThai(1).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();
            cboTemp.Properties.DisplayMember = "Ten";
            cboTemp.Properties.ValueMember = "Id";
            cboTemp.Properties.DataSource = lstTemp;

            cboTemp.EditValue = null;
            cboTemp.Properties.NullText = " -- Chi nhánh --";
        }
    }

    public static void DmKhoHang_BindDropDown(CheckedComboBoxEdit cboTemp)
    {
        cboTemp.Properties.DataSource = AppSetting.lstKhoHang;
        cboTemp.Properties.DisplayMember = "Ten";
        cboTemp.Properties.ValueMember = "Id";

        cboTemp.CheckAll();
    }

    public static void DmKhoNhan_BindDropDown(LookUpEdit cboTemp, int IdKhoHang)
    {
        using (var dbContext = new InventoryDbContext())
        {
            var lstTemp = dbContext.DmKhoHang.ByTrangThai(1).Where(d => d.Id != IdKhoHang).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();
            cboTemp.Properties.DisplayMember = "Ten";
            cboTemp.Properties.ValueMember = "Id";
            cboTemp.Properties.DataSource = lstTemp;

            cboTemp.EditValue = null;
            cboTemp.Properties.NullText = " -- Kho nhận --";
        }
    }

    public static void DmNhomVatTu_BindDropDown(GridLookUpEdit cboTemp)
    {
        using (var dbContext = new InventoryDbContext())
        {
            var lstTemp = dbContext.DmNhomVatTu.ByTrangThai(1).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();
            cboTemp.Properties.DisplayMember = "Ten";
            cboTemp.Properties.ValueMember = "Id";
            cboTemp.Properties.DataSource = lstTemp;

            cboTemp.EditValue = null;
            cboTemp.Properties.NullText = " -- Nhóm vật tư --";
        }
    }

    public static void DmLoaiVatTu_BindDropDown(GridLookUpEdit cboTemp, int IdKhoHang, Guid IdNhomVatTu, int LoaiGet)
    {
        using (var dbContext = new InventoryDbContext())
        {
            var lstTemp = dbContext.CustomDmLoaiVatTuGetDropDown(IdKhoHang, IdNhomVatTu, LoaiGet).ToList();
            cboTemp.Properties.DisplayMember = "Ten";
            cboTemp.Properties.ValueMember = "Id";
            cboTemp.Properties.DataSource = lstTemp;

            cboTemp.EditValue = null;
            cboTemp.Properties.NullText = " -- Loại vật tư --";
        }
    }

    public static void DmDonViTinh_BindDropDown(GridLookUpEdit cboTemp)
    {
        using (var dbContext = new InventoryDbContext())
        {
            var lstTemp = dbContext.DmDonViTinh.ByTrangThai(1).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();
            cboTemp.Properties.DisplayMember = "Ten";
            cboTemp.Properties.ValueMember = "Id";
            cboTemp.Properties.DataSource = lstTemp;

            cboTemp.EditValue = null;
            cboTemp.Properties.NullText = " -- Đơn vị tính --";
        }
    }

    public static void DmNguonNhap_BindDropDown(GridLookUpEdit cboTemp)
    {
        using (var dbContext = new InventoryDbContext())
        {
            var lstTemp = dbContext.DmNguonNhap.ByTrangThai(1).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();
            cboTemp.Properties.DisplayMember = "Ten";
            cboTemp.Properties.ValueMember = "Id";
            cboTemp.Properties.DataSource = lstTemp;

            cboTemp.EditValue = null;
            cboTemp.Properties.NullText = " -- Nguồn nhập --";
        }
    }

    public static void DmBoPhan_BindDropDown(GridLookUpEdit cboTemp)
    {
        using (var dbContext = new InventoryDbContext())
        {
            var lstTemp = dbContext.DmBoPhan.ByTrangThai(1).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();
            cboTemp.Properties.DisplayMember = "Ten";
            cboTemp.Properties.ValueMember = "Id";
            cboTemp.Properties.DataSource = lstTemp;

            cboTemp.EditValue = null;
            cboTemp.Properties.NullText = " -- Bộ phận --";
        }
    }

    public static void NguoiNhan_BindDropDown(GridLookUpEdit cboTemp, int IdKhoHang)
    {
        using (var dbContext = new InventoryDbContext())
        {
            var lstTemp = dbContext.CustomHtNguoiDungGetDropDown(IdKhoHang).ToList();
            cboTemp.Properties.DisplayMember = "Ten";
            cboTemp.Properties.ValueMember = "Id";
            cboTemp.Properties.DataSource = lstTemp;

            cboTemp.EditValue = null;
            cboTemp.Properties.NullText = " -- Người nhận --";
        }
    }

    public static void HtVaiTro_BindDropDown(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTemp)
    {
        using (var dbContext = new InventoryDbContext())
        {
            var lstTemp = dbContext.HtVaiTro.ByTrangThai(1).OrderBy(d => d.ThuTu).ThenBy(d => d.Ten).ToList();
            cboTemp.DisplayMember = "Ten";
            cboTemp.ValueMember = "Id";
            cboTemp.DataSource = lstTemp;

            cboTemp.NullText = " -- Vai trò --";
        }
    }

    public static void NguoiGiao_BindDropDown(GridLookUpEdit cboTemp, int IdKhoHang)
    {
        using (var dbContext = new InventoryDbContext())
        {
            var lstTemp = dbContext.CustomHtNguoiDungGetDropDown(IdKhoHang).ToList();
            cboTemp.Properties.DisplayMember = "Ten";
            cboTemp.Properties.ValueMember = "Id";
            cboTemp.Properties.DataSource = lstTemp;

            cboTemp.EditValue = null;
            cboTemp.Properties.NullText = " -- Người giao --";
        }
    }

    public static void KieuKhoa_BindDropDown(LookUpEdit cboTemp)
    {
        DataTable dtTemp = new DataTable();
        dtTemp.Columns.Add(new DataColumn("Ten", typeof(string)));
        dtTemp.Columns.Add(new DataColumn("Id", typeof(int)));
        DataRow dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Theo ngày";
        dcTemp["Id"] = 0;
        dtTemp.Rows.Add(dcTemp);
        dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Theo giờ";
        dcTemp["Id"] = 1;
        dtTemp.Rows.Add(dcTemp);
        dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Theo phút";
        dcTemp["Id"] = 2;
        dtTemp.Rows.Add(dcTemp);

        cboTemp.Properties.DisplayMember = "Ten";
        cboTemp.Properties.ValueMember = "Id";
        cboTemp.Properties.DataSource = dtTemp;

        cboTemp.EditValue = null;
        cboTemp.Properties.NullText = " -- Kiểu khóa --";
    }

    public static void LoaiNhap_BindDropDown(LookUpEdit cboTemp)
    {
        DataTable dtTemp = new DataTable();
        dtTemp.Columns.Add(new DataColumn("Ten", typeof(string)));
        dtTemp.Columns.Add(new DataColumn("Id", typeof(int)));
        DataRow dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "-- Loại nhập kho --";
        dcTemp["Id"] = -2;
        dtTemp.Rows.Add(dcTemp);
        dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Nhập mới";
        dcTemp["Id"] = 0;
        dtTemp.Rows.Add(dcTemp);
        dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Nhập nội bộ";
        dcTemp["Id"] = 2;
        dtTemp.Rows.Add(dcTemp);

        cboTemp.Properties.DisplayMember = "Ten";
        cboTemp.Properties.ValueMember = "Id";
        cboTemp.Properties.DataSource = dtTemp;

        cboTemp.EditValue = -2;
    }

    public static void LoaiBaoCao_BindDropDown(LookUpEdit cboTemp)
    {
        DataTable dtTemp = new DataTable();
        dtTemp.Columns.Add(new DataColumn("Ten", typeof(string)));
        dtTemp.Columns.Add(new DataColumn("Id", typeof(int)));
        DataRow dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Tổng hợp";
        dcTemp["Id"] = 0;
        dtTemp.Rows.Add(dcTemp);
        dcTemp = dtTemp.NewRow();
        dcTemp["Ten"] = "Chi tiết";
        dcTemp["Id"] = 1;
        dtTemp.Rows.Add(dcTemp);

        cboTemp.Properties.DisplayMember = "Ten";
        cboTemp.Properties.ValueMember = "Id";
        cboTemp.Properties.DataSource = dtTemp;

        cboTemp.EditValue = 0;
    }
}

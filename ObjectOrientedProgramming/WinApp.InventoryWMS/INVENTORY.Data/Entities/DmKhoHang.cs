using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using CodeSmith.Data.Attributes;
using CodeSmith.Data.Rules;

namespace INVENTORY.Data
{
    public partial class DmKhoHang
    {
        // Place custom code here.

        #region Metadata
        // For more information about how to use the metadata class visit:
        // http://www.plinqo.com/metadata.ashx
        [CodeSmith.Data.Audit.Audit]
        internal class Metadata
        {
             // WARNING: Only attributes inside of this class will be preserved.

            public int Id { get; set; }

            public int IdChiNhanh { get; set; }

            [Required]
            public string Ten { get; set; }

            [Required]
            public string TenVietTat { get; set; }

            public int ThuTu { get; set; }

            public int TrangThai { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string ChuThich { get; set; }

            public DmChiNhanh ChiNhanhDmChiNhanh { get; set; }

            public EntitySet<DmNguonKho> KhoHangDmNguonKhoList { get; set; }

            public EntitySet<HtNguoiDungVaiTro> KhoHangHtNguoiDungVaiTroList { get; set; }

            public EntitySet<KhPhieuChuyen> KhoHangKhPhieuChuyenList { get; set; }

            public EntitySet<KhPhieuChuyen> KhoNhanKhPhieuChuyenList { get; set; }

            public EntitySet<KhPhieuNhap> KhoHangKhPhieuNhapList { get; set; }

            public EntitySet<KhPhieuNhap> KhoChuyenKhPhieuNhapList { get; set; }

            public EntitySet<KhPhieuNhapNb> KhoHangKhPhieuNhapNbList { get; set; }

            public EntitySet<KhPhieuNhapNb> KhoChuyenKhPhieuNhapNbList { get; set; }

            public EntitySet<KhPhieuXuat> KhoHangKhPhieuXuatList { get; set; }

            public EntitySet<KhSanPham> KhoHangKhSanPhamList { get; set; }

        }

        #endregion
    }
}
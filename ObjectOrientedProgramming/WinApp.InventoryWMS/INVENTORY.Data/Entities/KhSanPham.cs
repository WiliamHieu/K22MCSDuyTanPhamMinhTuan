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
    public partial class KhSanPham
    {
        // Place custom code here.

        #region Metadata
        // For more information about how to use the metadata class visit:
        // http://www.plinqo.com/metadata.ashx
        [CodeSmith.Data.Audit.Audit]
        internal class Metadata
        {
             // WARNING: Only attributes inside of this class will be preserved.

            public System.Guid Id { get; set; }

            public System.Guid IdSanPham { get; set; }

            public int IdKhoHang { get; set; }

            public System.Guid IdNguonNhap { get; set; }

            public System.Guid IdLoaiVatTu { get; set; }

            public int SoLuongNhap { get; set; }

            public int SoLuongTon { get; set; }

            public System.DateTime NgayTao { get; set; }

            public string ChuThich { get; set; }

            public DmKhoHang KhoHangDmKhoHang { get; set; }

            public DmLoaiVatTu LoaiVatTuDmLoaiVatTu { get; set; }

            public DmNguonNhap NguonNhapDmNguonNhap { get; set; }

            public KhSanPham SanPhamKhSanPham { get; set; }

            public EntitySet<KhPhieuChuyenSp> SanPhamKhPhieuChuyenSpList { get; set; }

            public EntitySet<KhPhieuNhapCt> SanPhamKhPhieuNhapCtList { get; set; }

            public EntitySet<KhPhieuNhapNbCt> SanPhamKhPhieuNhapNbCtList { get; set; }

            public EntitySet<KhPhieuXuatSp> SanPhamKhPhieuXuatSpList { get; set; }

            public EntitySet<KhSanPham> SanPhamKhSanPhamList { get; set; }

        }

        #endregion
    }
}
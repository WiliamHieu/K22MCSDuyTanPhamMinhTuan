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
    public partial class DmLoaiVatTu
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

            public System.Guid IdNhomVatTu { get; set; }

            public System.Guid IdDonViTinh { get; set; }

            [Required]
            public string Ten { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string QuyCach { get; set; }

            public int TrangThai { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string ChuThich { get; set; }

            public DmDonViTinh DonViTinhDmDonViTinh { get; set; }

            public DmNhomVatTu NhomVatTuDmNhomVatTu { get; set; }

            public EntitySet<KhPhieuChuyenCt> LoaiVatTuKhPhieuChuyenCtList { get; set; }

            public EntitySet<KhPhieuNhapCt> LoaiVatTuKhPhieuNhapCtList { get; set; }

            public EntitySet<KhPhieuNhapNbCt> LoaiVatTuKhPhieuNhapNbCtList { get; set; }

            public EntitySet<KhPhieuXuatCt> LoaiVatTuKhPhieuXuatCtList { get; set; }

            public EntitySet<KhSanPham> LoaiVatTuKhSanPhamList { get; set; }

        }

        #endregion
    }
}
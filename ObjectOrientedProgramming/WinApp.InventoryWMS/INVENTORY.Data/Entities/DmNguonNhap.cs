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
    public partial class DmNguonNhap
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

            [Required]
            public string Ten { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string DiaChi { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string LienHe { get; set; }

            public int ThuTu { get; set; }

            public int TrangThai { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string ChuThich { get; set; }

            public EntitySet<DmNguonKho> NguonNhapDmNguonKhoList { get; set; }

            public EntitySet<KhPhieuNhap> NguonNhapKhPhieuNhapList { get; set; }

            public EntitySet<KhPhieuNhapNb> NguonNhapKhPhieuNhapNbList { get; set; }

            public EntitySet<KhSanPham> NguonNhapKhSanPhamList { get; set; }

        }

        #endregion
    }
}
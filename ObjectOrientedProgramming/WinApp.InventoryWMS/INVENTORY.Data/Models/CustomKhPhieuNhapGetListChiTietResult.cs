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
    public partial class CustomKhPhieuNhapGetListChiTietResult
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

            public System.Guid IdLoaiVatTu { get; set; }

            [Required]
            public string TenLoaiVatTu { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string QuyCach { get; set; }

            [Required]
            public string TenDonViTinh { get; set; }

            public int SoLuong { get; set; }

            public System.Guid IdNguonNhap { get; set; }

            public int SoLuongNhap { get; set; }

            public int SoLuongTon { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string ChuThich { get; set; }

            public System.Guid IdLoaiVatTuOld { get; set; }

            public int SoLuongOld { get; set; }

            public int? Status { get; set; }

        }

        #endregion
    }
}
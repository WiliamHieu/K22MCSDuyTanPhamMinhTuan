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
    public partial class CustomRpNhapXuatTonResult
    {
        // Place custom code here.

        #region Metadata
        // For more information about how to use the metadata class visit:
        // http://www.plinqo.com/metadata.ashx
        [CodeSmith.Data.Audit.Audit]
        internal class Metadata
        {
             // WARNING: Only attributes inside of this class will be preserved.

            public System.Guid? IdNhomVatTu { get; set; }

            public System.Guid? IdLoaiVatTu { get; set; }

            [Required]
            public string TenNhomVatTu { get; set; }

            public string TenLoaiVatTu { get; set; }

            [Required]
            public string TenDonViTinh { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string QuyCach { get; set; }

            public int? TonDau { get; set; }

            public int? Nhap { get; set; }

            public int? Xuat { get; set; }

            public int? Chuyen { get; set; }

            public int? TonCuoi { get; set; }

        }

        #endregion
    }
}
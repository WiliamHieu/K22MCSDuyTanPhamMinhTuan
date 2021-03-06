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
    public partial class CustomKhPhieuNhapGetListResult
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

            public int IdKhoHang { get; set; }

            public int LoaiNhap { get; set; }

            [Required]
            public string SoPhieu { get; set; }

            [Required]
            public string TenNguonNhap { get; set; }

            public string TenLoaiNhap { get; set; }

            [Required]
            public string TenNguoiTao { get; set; }

            public System.DateTime NgayTao { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string ChuThich { get; set; }

        }

        #endregion
    }
}
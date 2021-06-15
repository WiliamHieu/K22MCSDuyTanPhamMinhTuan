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
    public partial class CustomKhPhieuChuyenGetListResult
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

            [Required]
            public string SoPhieu { get; set; }

            [Required]
            public string TenKhoNhan { get; set; }

            public int TrangThai { get; set; }

            public int TrangThaiNhan { get; set; }

            public string TenTrangThaiChuyen { get; set; }

            public string TenTrangThaiNhan { get; set; }

            [Required]
            public string TenNguoiGiao { get; set; }

            [Required]
            public string TenNguoiTao { get; set; }

            public System.DateTime NgayTao { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string ChuThich { get; set; }

        }

        #endregion
    }
}
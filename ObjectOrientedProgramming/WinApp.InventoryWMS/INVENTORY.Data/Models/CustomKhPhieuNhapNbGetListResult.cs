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
    public partial class CustomKhPhieuNhapNbGetListResult
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
            public string SoPhieu { get; set; }

            [Required]
            public string TenKhoChuyen { get; set; }

            public int TrangThai { get; set; }

            public string TenTrangThai { get; set; }

            [Required]
            public string TenNguoiTao { get; set; }

            public System.DateTime NgayTao { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string ChuThich { get; set; }

        }

        #endregion
    }
}
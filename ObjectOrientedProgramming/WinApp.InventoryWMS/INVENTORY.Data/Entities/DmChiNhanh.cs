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
    public partial class DmChiNhanh
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

            [Required]
            public string Ten { get; set; }

            [Required]
            public string TenVietTat { get; set; }

            [Required]
            public string DiaChi { get; set; }

            [Required]
            public string LienHe { get; set; }

            public string MaSoThue { get; set; }

            public int ThuTu { get; set; }

            public int TrangThai { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string ChuThich { get; set; }

            public EntitySet<DmKhoHang> ChiNhanhDmKhoHangList { get; set; }

        }

        #endregion
    }
}
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
    public partial class CustomHtQuyenHanGetListResult
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

            public int IdPhanHe { get; set; }

            public int? IdVaiTro { get; set; }

            [Required]
            public string TenForm { get; set; }

            [Required]
            public string TenPhanHe { get; set; }

            public int ThuTuPhanHe { get; set; }

            [Required]
            public string TenChucNang { get; set; }

            public bool Xem { get; set; }

            public bool Them { get; set; }

            public bool Sua { get; set; }

            public bool Xoa { get; set; }

            public int? ThayDoi { get; set; }

        }

        #endregion
    }
}
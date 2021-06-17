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
    public partial class KhPhieuXuat
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

            public System.Guid IdBoPhan { get; set; }

            public int IdNguoiNhan { get; set; }

            public int IdNguoiTao { get; set; }

            public System.DateTime NgayTao { get; set; }

            public System.DateTime NgayTaoDate { get; set; }

            public bool UpdateTon { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string ChuThich { get; set; }

            public DmBoPhan BoPhanDmBoPhan { get; set; }

            public DmKhoHang KhoHangDmKhoHang { get; set; }

            public EntitySet<KhPhieuXuatCt> PhieuXuatKhPhieuXuatCtList { get; set; }

        }

        #endregion
    }
}
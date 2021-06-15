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
    public partial class HtNguoiDungVaiTro
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

            public int IdNguoiDung { get; set; }

            public int IdVaiTro { get; set; }

            public int IdKhoHang { get; set; }

            public bool MacDinh { get; set; }

            public DmKhoHang KhoHangDmKhoHang { get; set; }

            public HtNguoiDung NguoiDungHtNguoiDung { get; set; }

            public HtVaiTro VaiTroHtVaiTro { get; set; }

        }

        #endregion
    }
}
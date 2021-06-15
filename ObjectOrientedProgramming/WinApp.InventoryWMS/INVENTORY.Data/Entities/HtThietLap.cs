﻿using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using CodeSmith.Data.Attributes;
using CodeSmith.Data.Rules;

namespace INVENTORY.Data
{
    public partial class HtThietLap
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
            public string TenPhanMem { get; set; }

            public int NgayDuLieu { get; set; }

            public int KieuKhoa { get; set; }

            public int ThoiGianKhoa { get; set; }

            public bool XoaQuaNgay { get; set; }

        }

        #endregion
    }
}
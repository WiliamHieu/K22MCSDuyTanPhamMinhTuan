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
    public partial class KhPhieuNhapNbCt
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

            public System.Guid IdPhieuNhapNb { get; set; }

            public System.Guid IdLoaiVatTu { get; set; }

            public System.Guid IdSanPham { get; set; }

            public int SoLuong { get; set; }

            public int TrangThai { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string ChuThich { get; set; }

            public DmLoaiVatTu LoaiVatTuDmLoaiVatTu { get; set; }

            public KhPhieuNhapNb PhieuNhapNbKhPhieuNhapNb { get; set; }

            public KhSanPham SanPhamKhSanPham { get; set; }

        }

        #endregion
    }
}
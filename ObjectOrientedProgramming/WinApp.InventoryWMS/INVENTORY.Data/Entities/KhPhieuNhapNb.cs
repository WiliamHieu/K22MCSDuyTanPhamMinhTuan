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
    public partial class KhPhieuNhapNb
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

            public int IdKhoChuyen { get; set; }

            public System.Guid IdPhieuChuyen { get; set; }

            public System.Guid? IdPhieuNhap { get; set; }

            public System.Guid IdNguonNhap { get; set; }

            [Required]
            public string SoPhieu { get; set; }

            public int TrangThai { get; set; }

            public int IdNguoiGiao { get; set; }

            public int IdNguoiTao { get; set; }

            public System.DateTime NgayTao { get; set; }

            public System.DateTime NgayTaoDate { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string ChuThich { get; set; }

            public DmKhoHang KhoHangDmKhoHang { get; set; }

            public DmKhoHang KhoChuyenDmKhoHang { get; set; }

            public DmNguonNhap NguonNhapDmNguonNhap { get; set; }

            public KhPhieuChuyen PhieuChuyenKhPhieuChuyen { get; set; }

            public KhPhieuNhap PhieuNhapKhPhieuNhap { get; set; }

            public EntitySet<KhPhieuNhapNbCt> PhieuNhapNbKhPhieuNhapNbCtList { get; set; }

        }

        #endregion
    }
}
namespace QLTV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTHUTIEN")]
    public partial class PHIEUTHUTIEN
    {
        [Key]
        public int MaPhieuThuTien { get; set; }

        public double? SoTienNo { get; set; }

        public double? SoTienThu { get; set; }

        public int? MaDocGia { get; set; }

        public int? MaNhanVien { get; set; }

        public virtual DOCGIA DOCGIA { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}

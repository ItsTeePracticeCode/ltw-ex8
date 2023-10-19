namespace QLTV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            PHIEUMUONSACHes = new HashSet<PHIEUMUONSACH>();
        }

        [Key]
        public int MaSach { get; set; }

        [StringLength(40)]
        public string TenSach { get; set; }

        [StringLength(30)]
        public string TacGia { get; set; }

        public int? NamXuatBan { get; set; }

        [StringLength(40)]
        public string NhaXuatBan { get; set; }

        public double? TriGia { get; set; }

        public DateTime? NgayNhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUMUONSACH> PHIEUMUONSACHes { get; set; }
    }
}

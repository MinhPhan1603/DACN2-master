namespace DACN2.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QLDL1.TOUR")]
    public partial class TOUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOUR()
        {
            CHANGs = new HashSet<CHANG>();
            CTHOPDONGTOURs = new HashSet<CTHOPDONGTOUR>();
            DANHGIAs = new HashSet<DANHGIA>();
            HOPDONGs = new HashSet<HOPDONG>();
        }

        [Key]
        public decimal MATOUR { get; set; }

        [StringLength(1000)]
        public string TENTOUR { get; set; }

        public decimal? GIA { get; set; }

        public decimal? SOCHO { get; set; }

        [StringLength(2000)]
        public string NOIDUNG { get; set; }

        public decimal? MALOAITOUR { get; set; }

        [StringLength(50)]
        public string HINH { get; set; }

        [StringLength(100)]
        public string NOIKHOIHANH { get; set; }

        public decimal? GIANGUOILON { get; set; }

        public decimal? GIATREEM { get; set; }

        [StringLength(50)]
        public string THOIGIAN { get; set; }

        [StringLength(50)]
        public string HINH2 { get; set; }

        [StringLength(50)]
        public string HINH3 { get; set; }

        public decimal? MANV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHANG> CHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHOPDONGTOUR> CTHOPDONGTOURs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHGIA> DANHGIAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG> HOPDONGs { get; set; }

        public virtual LOAITOUR LOAITOUR { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}

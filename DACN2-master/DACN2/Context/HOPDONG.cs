namespace DACN2.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QLDL1.HOPDONG")]
    public partial class HOPDONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOPDONG()
        {
            CTHOPDONGTOURs = new HashSet<CTHOPDONGTOUR>();
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        public short MAHOPDONG { get; set; }

        public DateTime? NGAYDAT { get; set; }

        public decimal? MAKHACHHANG { get; set; }

        public decimal? SOCHO { get; set; }

        public DateTime? NGAYKHOIHANH { get; set; }

        public DateTime? NGAYKETTHUC { get; set; }

        public decimal? MATOUR { get; set; }

        public long? TONGTIEN { get; set; }

        public bool? TRANGTHAI { get; set; }

        public decimal? MANV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHOPDONGTOUR> CTHOPDONGTOURs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual TOUR TOUR { get; set; }
    }
}

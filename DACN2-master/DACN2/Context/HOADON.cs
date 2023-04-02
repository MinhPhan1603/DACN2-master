namespace DACN2.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QLDL1.HOADON")]
    public partial class HOADON
    {
        [Key]
        public short MAHD { get; set; }

        public decimal? MAHOPDONG { get; set; }

        [Column(TypeName = "float")]
        public decimal? THANHTIEN { get; set; }

        public decimal? MANV { get; set; }

        public virtual HOPDONG HOPDONG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}

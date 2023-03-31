namespace DACN2.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QLDL1.TINTUC")]
    public partial class TINTUC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IDTINTUC { get; set; }

        [StringLength(1000)]
        public string TIEUDE { get; set; }

        [StringLength(1000)]
        public string TOMTAT { get; set; }

        [StringLength(1000)]
        public string NOIDUNGTINTUC { get; set; }

        public DateTime? NGAYDANG { get; set; }

        public decimal? MANV { get; set; }

        [StringLength(50)]
        public string HINHANH { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}

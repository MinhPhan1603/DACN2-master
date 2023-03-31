namespace DACN2.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QLDL1.DANHGIA")]
    public partial class DANHGIA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal MADG { get; set; }

        public decimal MAKHACHHANG { get; set; }

        public decimal? MATOUR { get; set; }

        [StringLength(500)]
        public string NOIDUNG { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual TOUR TOUR { get; set; }
    }
}

namespace DACN2.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QLDL1.CTHOPDONGTOUR")]
    public partial class CTHOPDONGTOUR
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MATOUR { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MAHOPDONG { get; set; }

        public decimal? SONGUOILON { get; set; }

        public decimal? SOTREEM { get; set; }

        [Column(TypeName = "float")]
        public decimal? THANHTIEN { get; set; }

        public virtual TOUR TOUR { get; set; }

        public virtual HOPDONG HOPDONG { get; set; }
    }
}

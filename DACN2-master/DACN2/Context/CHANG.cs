namespace DACN2.Context
{
    using DACN2.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QLDL1.CHANG")]
    public partial class CHANG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal MACHANG { get; set; }

        [Required]
        [StringLength(100)]
        public string TENCHANG { get; set; }

        [StringLength(400)]
        public string NOIDUNGCHANG { get; set; }

        public decimal? MATOUR { get; set; }

        public virtual TOUR TOUR { get; set; }

    }
}

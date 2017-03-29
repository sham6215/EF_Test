namespace Challenger.Domain.DB.british
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class british_notice_graphic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [StringLength(2147483647)]
        public string name { get; set; }

        [Column(TypeName = "real")]
        public double? height { get; set; }

        [Column(TypeName = "real")]
        public double? width { get; set; }

        [NotMapped]
        [MaxLength(2147483647)]
        public byte[] data { get; set; }

        [StringLength(2147483647)]
        public string type { get; set; }

        public long? size { get; set; }

        public long notice_id { get; set; }

        public virtual british_notice british_notice { get; set; }
    }
}

namespace Challenger.Domain.DB.british
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vessel_enp_notice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long notice_id { get; set; }

        [StringLength(2147483647)]
        public string comment { get; set; }

        [StringLength(2147483647)]
        public string applied_date { get; set; }

        [StringLength(2147483647)]
        public string edited_by { get; set; }

        public long? download_graphic { get; set; }

        public virtual enp_notice enp_notice { get; set; }
    }
}

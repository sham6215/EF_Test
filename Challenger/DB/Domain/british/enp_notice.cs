namespace Challenger.Domain.DB.british
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class enp_notice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [StringLength(2147483647)]
        public string name { get; set; }

        [MaxLength(2147483647)]
        public byte[] data { get; set; }

        public long? publication_id { get; set; }

        public long week_id { get; set; }

        public virtual british_publication british_publication { get; set; }

        public virtual enp_week enp_week { get; set; }

        public virtual vessel_enp_notice vessel_enp_notice { get; set; }
    }
}

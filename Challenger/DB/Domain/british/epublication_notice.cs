namespace Challenger.Domain.DB.british
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class epublication_notice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [MaxLength(2147483647)]
        public byte[] data { get; set; }

        public long? publication_id { get; set; }

        public long? week_id { get; set; }

        public virtual british_publication british_publication { get; set; }

        public virtual epublication_week epublication_week { get; set; }

        public virtual vessel_epublication_notice vessel_epublication_notice { get; set; }
    }
}

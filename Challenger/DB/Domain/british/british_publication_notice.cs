namespace Challenger.Domain.DB.british
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class british_publication_notice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [MaxLength(2147483647)]
        public byte[] data { get; set; }

        public long? publication_id { get; set; }

        public long weekly_notice_id { get; set; }

        public long? size { get; set; }

        public virtual british_publication british_publication { get; set; }

        public virtual british_week_notice british_week_notice { get; set; }

        public virtual vessel_publication_notice vessel_publication_notice { get; set; }
    }
}

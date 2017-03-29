namespace Challenger.Domain.DB.british
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class week_notice_data
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [MaxLength(2147483647)]
        public byte[] charts_publications_list { get; set; }

        [MaxLength(2147483647)]
        public byte[] navigational_warnings { get; set; }

        [MaxLength(2147483647)]
        public byte[] nautical_publications { get; set; }

        [MaxLength(2147483647)]
        public byte[] digital_products_services { get; set; }

        public virtual british_week_notice british_week_notice { get; set; }
    }
}

namespace Challenger.Domain.DB.british
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vessel_british_notice
    {
        public long id { get; set; }

        public long notice_id { get; set; }

        [StringLength(2147483647)]
        public string comment { get; set; }

        [StringLength(2147483647)]
        public string applied_date { get; set; }

        [StringLength(2147483647)]
        public string edited_by { get; set; }

        public long download_graphic { get; set; }

        public long vessel_chart_id { get; set; }

        public virtual british_notice british_notice { get; set; }

        public virtual vessel_british_chart vessel_british_chart { get; set; }
    }
}

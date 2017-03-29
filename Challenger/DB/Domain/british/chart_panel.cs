namespace Challenger.Domain.DB.british
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class chart_panel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long? panel_id { get; set; }

        [StringLength(2147483647)]
        public string area { get; set; }

        [StringLength(2147483647)]
        public string name { get; set; }

        public long? scale { get; set; }

        [Column(TypeName = "real")]
        public double? north_limit { get; set; }

        [Column(TypeName = "real")]
        public double? south_limit { get; set; }

        [Column(TypeName = "real")]
        public double? east_limit { get; set; }

        [Column(TypeName = "real")]
        public double? west_limit { get; set; }

        [StringLength(2147483647)]
        public string coordinates { get; set; }

        public long chart_id { get; set; }

        public virtual british_chart british_chart { get; set; }
    }
}

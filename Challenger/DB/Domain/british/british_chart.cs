namespace Challenger.Domain.DB.british
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class british_chart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public british_chart()
        {
            british_notice = new HashSet<british_notice>();
            chart_panel = new HashSet<chart_panel>();
            vessel_british_chart = new HashSet<vessel_british_chart>();
        }

        public long id { get; set; }

        public string prefix { get; set; }
        public string number { get; set; }
        public string suffix { get; set; }
        public string international_number { get; set; }
        public string new_edition_date { get; set; }
        public string publication_date { get; set; }
        public string title { get; set; }
        public long? scale { get; set; }
        public string folio { get; set; }
        public string status { get; set; }
        public string status_date { get; set; }
        public string cancel_date { get; set; }
        public string next_edition_date { get; set; }
        public string replaced_by { get; set; }
        public double? north_limit { get; set; }
        public double? south_limit { get; set; }
        public double? east_limit { get; set; }
        public double? west_limit { get; set; }
        public string coordinates { get; set; }
        public long? last_notice_id { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<british_notice> british_notice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chart_panel> chart_panel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vessel_british_chart> vessel_british_chart { get; set; }
    }
}

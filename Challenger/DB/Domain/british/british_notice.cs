namespace Challenger.Domain.DB.british
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class british_notice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public british_notice()
        {
            //british_notice_graphic = new HashSet<british_notice_graphic>();
            //vessel_british_notice = new HashSet<vessel_british_notice>();
        }

        public long id { get; set; }
        public string number { get; set; }
        public string data { get; set; }
        public long type { get; set; }
        public long chart_id { get; set; }
        public long week_notice_id { get; set; }
        public long? active { get; set; }
        public string cancel_date { get; set; }
        public long? area_id { get; set; }
        public virtual british_chart british_chart { get; set; }
        public virtual british_week_notice british_week_notice { get; set; }
        public virtual geographical_area geographical_area { get; set; }
        public virtual british_notice_type british_notice_type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<british_notice_graphic> british_notice_graphic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vessel_british_notice> vessel_british_notice { get; set; }
    }
}

namespace Challenger.Domain.DB.british
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vessel_british_chart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vessel_british_chart()
        {
            vessel_british_notice = new HashSet<vessel_british_notice>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long chart_id { get; set; }

        [StringLength(2147483647)]
        public string comment { get; set; }

        [StringLength(2147483647)]
        public string edited_by { get; set; }

        public long? active { get; set; }

        public long? number_in_folio { get; set; }

        public long? vessel_folio_id { get; set; }

        public long? delivery_state { get; set; }

        public long? current_notice_id { get; set; }

        public virtual british_chart british_chart { get; set; }

        public virtual vessel_folio vessel_folio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vessel_british_notice> vessel_british_notice { get; set; }
    }
}

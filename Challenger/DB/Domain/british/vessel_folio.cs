namespace Challenger.Domain.DB.british
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vessel_folio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vessel_folio()
        {
            vessel_british_chart = new HashSet<vessel_british_chart>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string name { get; set; }

        [StringLength(2147483647)]
        public string title { get; set; }

        public long? server_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vessel_british_chart> vessel_british_chart { get; set; }
    }
}

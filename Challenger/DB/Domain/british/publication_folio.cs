namespace Challenger.Domain.DB.british
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class publication_folio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public publication_folio()
        {
            vessel_british_publication = new HashSet<vessel_british_publication>();
        }

        public long id { get; set; }

        [StringLength(2147483647)]
        public string name { get; set; }

        [StringLength(2147483647)]
        public string title { get; set; }

        public long? server_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vessel_british_publication> vessel_british_publication { get; set; }
    }
}

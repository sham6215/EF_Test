namespace Challenger.Domain.DB.british
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class british_publication
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public british_publication()
        {
            british_publication_notice = new HashSet<british_publication_notice>();
            enp_notice = new HashSet<enp_notice>();
            epublication_notice = new HashSet<epublication_notice>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [StringLength(2147483647)]
        public string name { get; set; }

        [StringLength(2147483647)]
        public string title { get; set; }

        [StringLength(2147483647)]
        public string status { get; set; }

        [StringLength(2147483647)]
        public string status_date { get; set; }

        [StringLength(2147483647)]
        public string edition_number { get; set; }

        [StringLength(2147483647)]
        public string edition_date { get; set; }

        [StringLength(2147483647)]
        public string replaced_by { get; set; }

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

        public long? type { get; set; }

        public virtual british_publication_type british_publication_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<british_publication_notice> british_publication_notice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<enp_notice> enp_notice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<epublication_notice> epublication_notice { get; set; }

        public virtual vessel_british_publication vessel_british_publication { get; set; }

        public virtual vessel_epublication vessel_epublication { get; set; }
    }
}

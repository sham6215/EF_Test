namespace Challenger.Domain.DB.british
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vessel_british_publication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long publication_id { get; set; }

        [StringLength(2147483647)]
        public string comment { get; set; }

        [StringLength(2147483647)]
        public string edited_by { get; set; }

        public long? active { get; set; }

        public long? number_in_folio { get; set; }

        public long? folio_id { get; set; }

        public long? delivery_state { get; set; }

        public virtual british_publication british_publication { get; set; }

        public virtual publication_folio publication_folio { get; set; }
    }
}

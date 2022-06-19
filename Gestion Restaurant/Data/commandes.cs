namespace Gestion_Restaurant
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.commandes")]
    public partial class commandes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public commandes()
        {
            plats = new HashSet<plats>();
        }

        public int? tableid { get; set; }

        public int nbr_personne { get; set; }

        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string mode_payment { get; set; }

        public DateTime date_heur_commande { get; set; }

        public DateTime? date_heur_paiment { get; set; }

        public virtual tables tables { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<plats> plats { get; set; }
    }
}

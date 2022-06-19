namespace Gestion_Restaurant
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.plats")]
    public partial class plats
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public plats()
        {
            commandes = new HashSet<commandes>();
        }

        [Required]
        [StringLength(255)]
        public string libelle { get; set; }

        [Required]
        [StringLength(255)]
        public string type { get; set; }

        public double prix { get; set; }

        public int id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commandes> commandes { get; set; }
    }
}

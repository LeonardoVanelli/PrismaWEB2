namespace ProjetoModeloDDD.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lei
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lei()
        {
            Votocandidatoleis = new HashSet<Votocandidatoleis>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Numero { get; set; }

        [Required]
        [StringLength(60)]
        public string Nome { get; set; }

        [Required]
        public string Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Votocandidatoleis> Votocandidatoleis { get; set; }
    }
}

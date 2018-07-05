namespace ProjetoModeloDDD.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Estado
    {
        public int Id { get; set; }

        [Required]
        [StringLength(75)]
        public string Nome { get; set; }
        [Required]
        [StringLength(2)]
        public string Uf { get; set; }
        public int Pais { get; set; }

        public virtual Pais Paises { get; set; }
    }
}

namespace ProjetoModeloDDD.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Logradouro
    {
        public int Id { get; set; }
        [Required]
        [StringLength(120)]
        public string Nome { get; set; }
        public int Bairro { get; set; }
        public int Cidade { get; set; }
        public int Estado { get; set; }
        public int Pais { get; set; }

        public virtual Bairro Bairros { get; set; }
        public virtual Cidade Cidades { get; set; }
        public virtual Estado Estados { get; set; }
        public virtual Pais Paises { get; set; }
    }
}

namespace ProjetoModeloDDD.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Bairro
    {    
        public int Id { get; set; }

        [Required]
        [StringLength(120,MinimumLength=4)]
        public string Nome { get; set; }
        public int Cidade { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public int Estado { get; set; }
        [Display(Name = "Data do pedido")]
        public int Pais { get; set; }        
        public virtual Cidade Cidades { get; set; }
        public virtual Estado Estados { get; set; }
        public virtual Pais Paises { get; set; }
    }
}

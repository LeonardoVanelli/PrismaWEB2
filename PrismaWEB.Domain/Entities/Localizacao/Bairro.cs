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

        [Required]
        public int Cidade_Id { get; set; }

        [Required]
        public int Estado_Id { get; set; }

        [Required]
        public int Pais_Id { get; set; }

        public virtual Cidade Cidade { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Pais Pais { get; set; }
    }
}

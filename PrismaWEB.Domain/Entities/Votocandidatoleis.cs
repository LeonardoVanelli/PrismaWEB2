namespace ProjetoModeloDDD.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Votocandidatoleis
    {
        public int Id { get; set; }

        public int Candidato_Id { get; set; }

        public int Lei_Id { get; set; }

        public bool Votou { get; set; }

        public DateTime DataCriacao { get; set; }

        public virtual Lei Leis { get; set; }

        public virtual Pessoa Pessoas { get; set; }
    }
}

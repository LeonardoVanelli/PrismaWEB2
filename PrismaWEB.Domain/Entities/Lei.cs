namespace ProjetoModeloDDD.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Lei
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}

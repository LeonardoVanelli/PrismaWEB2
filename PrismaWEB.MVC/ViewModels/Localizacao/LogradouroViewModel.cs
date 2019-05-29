using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class LogradouroViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Bairro")]
        public int Bairro { get; set; }
        [Required]
        [Display(Name = "Cidade")]
        public int Cidade { get; set; }
        [Required]
        [Display(Name = "Estado")]
        public int Estado { get; set; }
        [Required]
        [Display(Name = "País")]
        public int Pais { get; set; }

        public virtual BairroViewModel Bairros { get; set; }
        public virtual CidadeViewModel Cidades { get; set; }
        public virtual EstadoViewModel Estados { get; set; }
        public virtual PaisViewModel Paises { get; set; }
    }
}


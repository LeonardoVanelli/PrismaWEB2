using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class LeiViewModel
    {
        [Required]        
        public string Numero { get; set; }
        [Required]
        [MaxLength(120)]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Descri��o")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
    }
}


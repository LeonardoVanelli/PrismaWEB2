using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class CargoViewModel
    {
        [Required]
        [StringLength(60)]
        public string Nome { get; set; }
        [Required]
        [StringLength(420)]
        [Display(Name = "Descri��o")]
        public string Descricao { get; set; }        
    }
}


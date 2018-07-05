using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class PaisViewModel
    {
        [Required]
        [StringLength(60)]
        public string Nome { get; set; }

        [Required]
        [StringLength(3)]
        public string Sigla { get; set; }
    }
}


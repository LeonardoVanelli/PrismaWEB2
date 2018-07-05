using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Enum
{
    public class TipoPessoa : Enumeration
    {

        public static TipoPessoa Candidato   = new TipoPessoa(1, "Candidato");
        public static TipoPessoa Usuario     = new TipoPessoa(2, "Usuario");
        public static TipoPessoa Funcionario = new TipoPessoa(3, "Funcionario");
        public static TipoPessoa Administrador = new TipoPessoa(3, "Administrador");

        protected TipoPessoa()
        {        
        }

        protected TipoPessoa(int id, string name)
            : base(id, name)
        {
        }

        public static IEnumerable<TipoPessoa> List()
        {
            return new[] { Candidato, Usuario, Funcionario, Administrador };
        }
    }
}

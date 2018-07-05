using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Enum;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Domain.Services
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _PessoaRepository;

        public PessoaService(IPessoaRepository PessoaRepository)
            : base(PessoaRepository)
        {
            _PessoaRepository = PessoaRepository;
        }

        public IEnumerable<Pessoa> ObterCandidatos(IEnumerable<Pessoa> Pessoas)
        {
            return Pessoas.Where(p => p.Tipo == TipoPessoa.Candidato.Id);
        }
    }
}


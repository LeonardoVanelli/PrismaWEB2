using System.Collections.Generic;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class PessoaAppService : AppServiceBase<Pessoa>, IPessoaAppService
    {
        private readonly IPessoaService _PessoaService;

        public PessoaAppService(IPessoaService PessoaService)
            : base(PessoaService)
        {
            _PessoaService = PessoaService;
        }

        public IEnumerable<Pessoa> ObterCandidatos()
        {
            return _PessoaService.ObterCandidatos(_PessoaService.GetAll());
        }
    }
}


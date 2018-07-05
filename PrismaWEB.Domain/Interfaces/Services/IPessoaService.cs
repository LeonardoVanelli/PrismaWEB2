using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IPessoaService : IServiceBase<Pessoa>
    {
        IEnumerable<Pessoa> ObterCandidatos(IEnumerable<Pessoa> clientes);
    }
}


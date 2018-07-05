using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class PresidenteRepository : RepositoryBase<Presidente>, IPresidenteRepository
    {
        public override void AfterInsert(Presidente obj)
        {
            
        }
    }
}


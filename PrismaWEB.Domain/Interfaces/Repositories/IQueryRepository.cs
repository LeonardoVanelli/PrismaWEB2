using PrismaWEB.Utils.Querys;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositories
{
    public interface IQueryRepository
    {
        IList<QueryReseult> Get(string sql);
    }
}

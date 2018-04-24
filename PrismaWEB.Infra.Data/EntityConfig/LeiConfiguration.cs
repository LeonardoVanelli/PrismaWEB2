using System.Data.Entity.ModelConfiguration;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class LeiConfiguration : EntityTypeConfiguration<Lei>
    {
        public LeiConfiguration()
        {
            HasKey(x => x.Id);
        }
    }
}


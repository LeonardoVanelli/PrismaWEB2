

using System.Data.Entity.ModelConfiguration;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class LeiConfiguration : EntityTypeConfiguration<Lei>
    {
        public LeiConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Numero)
                .IsRequired()
                .HasMaxLength(15);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(60);

            Property(p => p.Descricao)
                .IsRequired();
        }
    }
}

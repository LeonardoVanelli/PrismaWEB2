using System.Data.Entity.ModelConfiguration;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class PresidenteConfiguration : EntityTypeConfiguration<Presidente>
    {
        public PresidenteConfiguration()
        {
            HasKey(p => p.Id);

            HasRequired(p => p.Candidato)
                .WithMany()
                .HasForeignKey(p => p.Candidato_Id);

            HasRequired(p => p.Vice)
                .WithMany()
                .HasForeignKey(p => p.Vice_Id);

            Property(p => p.DataCriacao)
                .IsRequired();

            Property(p => p.DataAlteracao)
                .IsOptional();
        }
    }
}

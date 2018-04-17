using System.Data.Entity.ModelConfiguration;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    class PessoaConfiguration : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(60);

            Property(p => p.DataNascimento)
                .IsOptional();

            Property(p => p.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            Property(p => p.Foto)
                .IsOptional();

            Property(p => p.DataCriacao)
                .IsRequired();

            Property(p => p.DataAlteracao)
                .IsOptional();

            Property(p => p.Ativo)
                .IsRequired();

            Property(p => p.Email)
                .IsOptional()
                .HasMaxLength(120);

            Property(p => p.TelefoneFixo)
                .IsOptional()
                .HasMaxLength(12);

            Property(p => p.TelefoneMovel)
                .IsOptional()
                .HasMaxLength(12);

            Property(p => p.Endereco)
                .IsOptional()
                .HasMaxLength(120);

            HasRequired(p => p.Pais)
                .WithMany()
                .HasForeignKey(p => p.Pais_Id);

            HasRequired(p => p.Estado)
                .WithMany()
                .HasForeignKey(p => p.Estado_Id);

            HasRequired(p => p.Cidade)
                .WithMany()
                .HasForeignKey(p => p.Cidade_Id);

            HasRequired(p => p.Bairro)
                .WithMany()
                .HasForeignKey(p => p.Bairro_Id);

            HasRequired(p => p.Logradouro)
                .WithMany()
                .HasForeignKey(p => p.Logradouro_Id);

            Property(p => p.Cep)
                .IsOptional()
                .HasMaxLength(8);

            Property(p => p.Numero)
                .IsOptional()
                .HasMaxLength(6);

            Property(p => p.Complemento)
                .IsOptional()
                .HasMaxLength(120);

            Property(p => p.Tipo)
                .IsRequired();
        }
    }
}

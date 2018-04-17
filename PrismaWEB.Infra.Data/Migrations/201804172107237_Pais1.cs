namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pais1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Candidatocargos", "Cargos_Id", "dbo.Cargo");
            DropForeignKey("dbo.Candidatocargos", "Pessoas_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Favorito", "Pessoas_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Favorito", "Pessoas1_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Favorito", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Favorito", "Pessoa_Id1", "dbo.Pessoa");
            DropForeignKey("dbo.Presidente", "Pessoas_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Presidente", "Pessoas1_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Presidente", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Presidente", "Pessoa_Id1", "dbo.Pessoa");
            DropForeignKey("dbo.Votocandidatoleis", "Leis_Id", "dbo.Lei");
            DropForeignKey("dbo.Votocandidatoleis", "Pessoas_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Voto", "Pessoas_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Voto", "Pessoas1_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Voto", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Voto", "Pessoa_Id1", "dbo.Pessoa");
            DropIndex("dbo.Candidatocargos", new[] { "Cargos_Id" });
            DropIndex("dbo.Candidatocargos", new[] { "Pessoas_Id" });
            DropIndex("dbo.Favorito", new[] { "Pessoas_Id" });
            DropIndex("dbo.Favorito", new[] { "Pessoas1_Id" });
            DropIndex("dbo.Favorito", new[] { "Pessoa_Id" });
            DropIndex("dbo.Favorito", new[] { "Pessoa_Id1" });
            DropIndex("dbo.Presidente", new[] { "Pessoas_Id" });
            DropIndex("dbo.Presidente", new[] { "Pessoas1_Id" });
            DropIndex("dbo.Presidente", new[] { "Pessoa_Id" });
            DropIndex("dbo.Presidente", new[] { "Pessoa_Id1" });
            DropIndex("dbo.Votocandidatoleis", new[] { "Leis_Id" });
            DropIndex("dbo.Votocandidatoleis", new[] { "Pessoas_Id" });
            DropIndex("dbo.Voto", new[] { "Pessoas_Id" });
            DropIndex("dbo.Voto", new[] { "Pessoas1_Id" });
            DropIndex("dbo.Voto", new[] { "Pessoa_Id" });
            DropIndex("dbo.Voto", new[] { "Pessoa_Id1" });
            RenameColumn(table: "dbo.Pessoa", name: "Paises_Id", newName: "Pais_Id1");
            RenameColumn(table: "dbo.Pessoa", name: "Bairros_Id", newName: "Bairro_Id1");
            RenameColumn(table: "dbo.Pessoa", name: "Cidades_Id", newName: "Cidade_Id1");
            RenameColumn(table: "dbo.Pessoa", name: "Estados_Id", newName: "Estado_Id1");
            RenameColumn(table: "dbo.Pessoa", name: "Logradouros_Id", newName: "Logradouro_Id1");
            RenameIndex(table: "dbo.Pessoa", name: "IX_Bairros_Id", newName: "IX_Bairro_Id1");
            RenameIndex(table: "dbo.Pessoa", name: "IX_Cidades_Id", newName: "IX_Cidade_Id1");
            RenameIndex(table: "dbo.Pessoa", name: "IX_Estados_Id", newName: "IX_Estado_Id1");
            RenameIndex(table: "dbo.Pessoa", name: "IX_Logradouros_Id", newName: "IX_Logradouro_Id1");
            RenameIndex(table: "dbo.Pessoa", name: "IX_Paises_Id", newName: "IX_Pais_Id1");
            AlterColumn("dbo.Pessoa", "Nome", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Pessoa", "DataNascimento", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Pessoa", "Cpf", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Pessoa", "DataAlteracao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Pessoa", "Email", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Pessoa", "TelefoneFixo", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Pessoa", "TelefoneMovel", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Pessoa", "Endereco", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Pessoa", "Pais_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Pessoa", "Estado_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Pessoa", "Cidade_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Pessoa", "Bairro_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Pessoa", "Logradouro_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Pessoa", "Cep", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Pessoa", "Numero", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Pessoa", "Complemento", c => c.String(maxLength: 100, unicode: false));
            DropTable("dbo.Candidatocargos");
            DropTable("dbo.Cargo");
            DropTable("dbo.Favorito");
            DropTable("dbo.Presidente");
            DropTable("dbo.Votocandidatoleis");
            DropTable("dbo.Lei");
            DropTable("dbo.Voto");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Voto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usuario_Id = c.Int(nullable: false),
                        Candidato_Id = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        Pessoas_Id = c.Int(),
                        Pessoas1_Id = c.Int(),
                        Pessoa_Id = c.Int(),
                        Pessoa_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Lei",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.String(nullable: false, maxLength: 15, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Votocandidatoleis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Candidato_Id = c.Int(nullable: false),
                        Lei_Id = c.Int(nullable: false),
                        Votou = c.Boolean(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        Leis_Id = c.Int(),
                        Pessoas_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Presidente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Candidato_Id = c.Int(nullable: false),
                        Vice_Id = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(),
                        Pessoas_Id = c.Int(),
                        Pessoas1_Id = c.Int(),
                        Pessoa_Id = c.Int(),
                        Pessoa_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Favorito",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usuario_Id = c.Int(nullable: false),
                        Candidato_Id = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        Pessoas_Id = c.Int(),
                        Pessoas1_Id = c.Int(),
                        Pessoa_Id = c.Int(),
                        Pessoa_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cargo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 420, unicode: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Candidatocargos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Candidato_Id = c.Int(nullable: false),
                        Cargo_Id = c.Int(nullable: false),
                        DataInicio = c.DateTime(nullable: false),
                        DataFim = c.DateTime(),
                        Status = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(),
                        Cargos_Id = c.Int(),
                        Pessoas_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Pessoa", "Complemento", c => c.String(maxLength: 60, unicode: false));
            AlterColumn("dbo.Pessoa", "Numero", c => c.String(maxLength: 6, unicode: false));
            AlterColumn("dbo.Pessoa", "Cep", c => c.String(maxLength: 8, unicode: false));
            AlterColumn("dbo.Pessoa", "Logradouro_Id", c => c.Int());
            AlterColumn("dbo.Pessoa", "Bairro_Id", c => c.Int());
            AlterColumn("dbo.Pessoa", "Cidade_Id", c => c.Int());
            AlterColumn("dbo.Pessoa", "Estado_Id", c => c.Int());
            AlterColumn("dbo.Pessoa", "Pais_Id", c => c.Int());
            AlterColumn("dbo.Pessoa", "Endereco", c => c.String(maxLength: 60, unicode: false));
            AlterColumn("dbo.Pessoa", "TelefoneMovel", c => c.String(maxLength: 12, unicode: false));
            AlterColumn("dbo.Pessoa", "TelefoneFixo", c => c.String(maxLength: 12, unicode: false));
            AlterColumn("dbo.Pessoa", "Email", c => c.String(maxLength: 60, unicode: false));
            AlterColumn("dbo.Pessoa", "DataAlteracao", c => c.DateTime());
            AlterColumn("dbo.Pessoa", "Cpf", c => c.String(nullable: false, maxLength: 11, unicode: false));
            AlterColumn("dbo.Pessoa", "DataNascimento", c => c.DateTime());
            AlterColumn("dbo.Pessoa", "Nome", c => c.String(nullable: false, maxLength: 60, unicode: false));
            RenameIndex(table: "dbo.Pessoa", name: "IX_Pais_Id1", newName: "IX_Paises_Id");
            RenameIndex(table: "dbo.Pessoa", name: "IX_Logradouro_Id1", newName: "IX_Logradouros_Id");
            RenameIndex(table: "dbo.Pessoa", name: "IX_Estado_Id1", newName: "IX_Estados_Id");
            RenameIndex(table: "dbo.Pessoa", name: "IX_Cidade_Id1", newName: "IX_Cidades_Id");
            RenameIndex(table: "dbo.Pessoa", name: "IX_Bairro_Id1", newName: "IX_Bairros_Id");
            RenameColumn(table: "dbo.Pessoa", name: "Logradouro_Id1", newName: "Logradouros_Id");
            RenameColumn(table: "dbo.Pessoa", name: "Estado_Id1", newName: "Estados_Id");
            RenameColumn(table: "dbo.Pessoa", name: "Cidade_Id1", newName: "Cidades_Id");
            RenameColumn(table: "dbo.Pessoa", name: "Bairro_Id1", newName: "Bairros_Id");
            RenameColumn(table: "dbo.Pessoa", name: "Pais_Id1", newName: "Paises_Id");
            CreateIndex("dbo.Voto", "Pessoa_Id1");
            CreateIndex("dbo.Voto", "Pessoa_Id");
            CreateIndex("dbo.Voto", "Pessoas1_Id");
            CreateIndex("dbo.Voto", "Pessoas_Id");
            CreateIndex("dbo.Votocandidatoleis", "Pessoas_Id");
            CreateIndex("dbo.Votocandidatoleis", "Leis_Id");
            CreateIndex("dbo.Presidente", "Pessoa_Id1");
            CreateIndex("dbo.Presidente", "Pessoa_Id");
            CreateIndex("dbo.Presidente", "Pessoas1_Id");
            CreateIndex("dbo.Presidente", "Pessoas_Id");
            CreateIndex("dbo.Favorito", "Pessoa_Id1");
            CreateIndex("dbo.Favorito", "Pessoa_Id");
            CreateIndex("dbo.Favorito", "Pessoas1_Id");
            CreateIndex("dbo.Favorito", "Pessoas_Id");
            CreateIndex("dbo.Candidatocargos", "Pessoas_Id");
            CreateIndex("dbo.Candidatocargos", "Cargos_Id");
            AddForeignKey("dbo.Voto", "Pessoa_Id1", "dbo.Pessoa", "Id");
            AddForeignKey("dbo.Voto", "Pessoa_Id", "dbo.Pessoa", "Id");
            AddForeignKey("dbo.Voto", "Pessoas1_Id", "dbo.Pessoa", "Id");
            AddForeignKey("dbo.Voto", "Pessoas_Id", "dbo.Pessoa", "Id");
            AddForeignKey("dbo.Votocandidatoleis", "Pessoas_Id", "dbo.Pessoa", "Id");
            AddForeignKey("dbo.Votocandidatoleis", "Leis_Id", "dbo.Lei", "Id");
            AddForeignKey("dbo.Presidente", "Pessoa_Id1", "dbo.Pessoa", "Id");
            AddForeignKey("dbo.Presidente", "Pessoa_Id", "dbo.Pessoa", "Id");
            AddForeignKey("dbo.Presidente", "Pessoas1_Id", "dbo.Pessoa", "Id");
            AddForeignKey("dbo.Presidente", "Pessoas_Id", "dbo.Pessoa", "Id");
            AddForeignKey("dbo.Favorito", "Pessoa_Id1", "dbo.Pessoa", "Id");
            AddForeignKey("dbo.Favorito", "Pessoa_Id", "dbo.Pessoa", "Id");
            AddForeignKey("dbo.Favorito", "Pessoas1_Id", "dbo.Pessoa", "Id");
            AddForeignKey("dbo.Favorito", "Pessoas_Id", "dbo.Pessoa", "Id");
            AddForeignKey("dbo.Candidatocargos", "Pessoas_Id", "dbo.Pessoa", "Id");
            AddForeignKey("dbo.Candidatocargos", "Cargos_Id", "dbo.Cargo", "Id");
        }
    }
}

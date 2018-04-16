namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pais : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pais",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        Sigla = c.String(nullable: false, maxLength: 3, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bairro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 120, unicode: false),
                        Cidade = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        Pais = c.Int(nullable: false),
                        Cidades_Id = c.Int(),
                        Estados_Id = c.Int(),
                        Paises_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cidade", t => t.Cidades_Id)
                .ForeignKey("dbo.Estado", t => t.Estados_Id)
                .ForeignKey("dbo.Pais", t => t.Paises_Id)
                .Index(t => t.Cidades_Id)
                .Index(t => t.Estados_Id)
                .Index(t => t.Paises_Id);
            
            CreateTable(
                "dbo.Cidade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 120, unicode: false),
                        Estado = c.Int(nullable: false),
                        Pais = c.Int(nullable: false),
                        Estados_Id = c.Int(),
                        Paises_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estado", t => t.Estados_Id)
                .ForeignKey("dbo.Pais", t => t.Paises_Id)
                .Index(t => t.Estados_Id)
                .Index(t => t.Paises_Id);
            
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 75, unicode: false),
                        Uf = c.String(nullable: false, maxLength: 2, unicode: false),
                        Pais = c.Int(nullable: false),
                        Paises_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pais", t => t.Paises_Id)
                .Index(t => t.Paises_Id);
            
            CreateTable(
                "dbo.Logradouro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 120, unicode: false),
                        Bairro = c.Int(nullable: false),
                        Cidade = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        Pais = c.Int(nullable: false),
                        Bairros_Id = c.Int(),
                        Cidades_Id = c.Int(),
                        Estados_Id = c.Int(),
                        Paises_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bairro", t => t.Bairros_Id)
                .ForeignKey("dbo.Cidade", t => t.Cidades_Id)
                .ForeignKey("dbo.Estado", t => t.Estados_Id)
                .ForeignKey("dbo.Pais", t => t.Paises_Id)
                .Index(t => t.Bairros_Id)
                .Index(t => t.Cidades_Id)
                .Index(t => t.Estados_Id)
                .Index(t => t.Paises_Id);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        DataNascimento = c.DateTime(),
                        Cpf = c.String(nullable: false, maxLength: 11, unicode: false),
                        Foto = c.String(maxLength: 100, unicode: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(),
                        Ativo = c.Boolean(nullable: false),
                        Email = c.String(maxLength: 60, unicode: false),
                        TelefoneFixo = c.String(maxLength: 12, unicode: false),
                        TelefoneMovel = c.String(maxLength: 12, unicode: false),
                        Endereco = c.String(maxLength: 60, unicode: false),
                        Pais_Id = c.Int(),
                        Estado_Id = c.Int(),
                        Cidade_Id = c.Int(),
                        Bairro_Id = c.Int(),
                        Logradouro_Id = c.Int(),
                        Cep = c.String(maxLength: 8, unicode: false),
                        Numero = c.String(maxLength: 6, unicode: false),
                        Complemento = c.String(maxLength: 60, unicode: false),
                        Tipo = c.Int(nullable: false),
                        Bairros_Id = c.Int(),
                        Cidades_Id = c.Int(),
                        Estados_Id = c.Int(),
                        Logradouros_Id = c.Int(),
                        Paises_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bairro", t => t.Bairros_Id)
                .ForeignKey("dbo.Cidade", t => t.Cidades_Id)
                .ForeignKey("dbo.Estado", t => t.Estados_Id)
                .ForeignKey("dbo.Logradouro", t => t.Logradouros_Id)
                .ForeignKey("dbo.Pais", t => t.Paises_Id)
                .Index(t => t.Bairros_Id)
                .Index(t => t.Cidades_Id)
                .Index(t => t.Estados_Id)
                .Index(t => t.Logradouros_Id)
                .Index(t => t.Paises_Id);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cargo", t => t.Cargos_Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoas_Id)
                .Index(t => t.Cargos_Id)
                .Index(t => t.Pessoas_Id);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoas_Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoas1_Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id1)
                .Index(t => t.Pessoas_Id)
                .Index(t => t.Pessoas1_Id)
                .Index(t => t.Pessoa_Id)
                .Index(t => t.Pessoa_Id1);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoas_Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoas1_Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id1)
                .Index(t => t.Pessoas_Id)
                .Index(t => t.Pessoas1_Id)
                .Index(t => t.Pessoa_Id)
                .Index(t => t.Pessoa_Id1);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lei", t => t.Leis_Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoas_Id)
                .Index(t => t.Leis_Id)
                .Index(t => t.Pessoas_Id);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoas_Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoas1_Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id1)
                .Index(t => t.Pessoas_Id)
                .Index(t => t.Pessoas1_Id)
                .Index(t => t.Pessoa_Id)
                .Index(t => t.Pessoa_Id1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bairro", "Paises_Id", "dbo.Pais");
            DropForeignKey("dbo.Cidade", "Paises_Id", "dbo.Pais");
            DropForeignKey("dbo.Estado", "Paises_Id", "dbo.Pais");
            DropForeignKey("dbo.Voto", "Pessoa_Id1", "dbo.Pessoa");
            DropForeignKey("dbo.Voto", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Voto", "Pessoas1_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Voto", "Pessoas_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Votocandidatoleis", "Pessoas_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Votocandidatoleis", "Leis_Id", "dbo.Lei");
            DropForeignKey("dbo.Presidente", "Pessoa_Id1", "dbo.Pessoa");
            DropForeignKey("dbo.Presidente", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Presidente", "Pessoas1_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Presidente", "Pessoas_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Pessoa", "Paises_Id", "dbo.Pais");
            DropForeignKey("dbo.Pessoa", "Logradouros_Id", "dbo.Logradouro");
            DropForeignKey("dbo.Favorito", "Pessoa_Id1", "dbo.Pessoa");
            DropForeignKey("dbo.Favorito", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Favorito", "Pessoas1_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Favorito", "Pessoas_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Pessoa", "Estados_Id", "dbo.Estado");
            DropForeignKey("dbo.Pessoa", "Cidades_Id", "dbo.Cidade");
            DropForeignKey("dbo.Candidatocargos", "Pessoas_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Candidatocargos", "Cargos_Id", "dbo.Cargo");
            DropForeignKey("dbo.Pessoa", "Bairros_Id", "dbo.Bairro");
            DropForeignKey("dbo.Logradouro", "Paises_Id", "dbo.Pais");
            DropForeignKey("dbo.Logradouro", "Estados_Id", "dbo.Estado");
            DropForeignKey("dbo.Logradouro", "Cidades_Id", "dbo.Cidade");
            DropForeignKey("dbo.Logradouro", "Bairros_Id", "dbo.Bairro");
            DropForeignKey("dbo.Cidade", "Estados_Id", "dbo.Estado");
            DropForeignKey("dbo.Bairro", "Estados_Id", "dbo.Estado");
            DropForeignKey("dbo.Bairro", "Cidades_Id", "dbo.Cidade");
            DropIndex("dbo.Voto", new[] { "Pessoa_Id1" });
            DropIndex("dbo.Voto", new[] { "Pessoa_Id" });
            DropIndex("dbo.Voto", new[] { "Pessoas1_Id" });
            DropIndex("dbo.Voto", new[] { "Pessoas_Id" });
            DropIndex("dbo.Votocandidatoleis", new[] { "Pessoas_Id" });
            DropIndex("dbo.Votocandidatoleis", new[] { "Leis_Id" });
            DropIndex("dbo.Presidente", new[] { "Pessoa_Id1" });
            DropIndex("dbo.Presidente", new[] { "Pessoa_Id" });
            DropIndex("dbo.Presidente", new[] { "Pessoas1_Id" });
            DropIndex("dbo.Presidente", new[] { "Pessoas_Id" });
            DropIndex("dbo.Favorito", new[] { "Pessoa_Id1" });
            DropIndex("dbo.Favorito", new[] { "Pessoa_Id" });
            DropIndex("dbo.Favorito", new[] { "Pessoas1_Id" });
            DropIndex("dbo.Favorito", new[] { "Pessoas_Id" });
            DropIndex("dbo.Candidatocargos", new[] { "Pessoas_Id" });
            DropIndex("dbo.Candidatocargos", new[] { "Cargos_Id" });
            DropIndex("dbo.Pessoa", new[] { "Paises_Id" });
            DropIndex("dbo.Pessoa", new[] { "Logradouros_Id" });
            DropIndex("dbo.Pessoa", new[] { "Estados_Id" });
            DropIndex("dbo.Pessoa", new[] { "Cidades_Id" });
            DropIndex("dbo.Pessoa", new[] { "Bairros_Id" });
            DropIndex("dbo.Logradouro", new[] { "Paises_Id" });
            DropIndex("dbo.Logradouro", new[] { "Estados_Id" });
            DropIndex("dbo.Logradouro", new[] { "Cidades_Id" });
            DropIndex("dbo.Logradouro", new[] { "Bairros_Id" });
            DropIndex("dbo.Estado", new[] { "Paises_Id" });
            DropIndex("dbo.Cidade", new[] { "Paises_Id" });
            DropIndex("dbo.Cidade", new[] { "Estados_Id" });
            DropIndex("dbo.Bairro", new[] { "Paises_Id" });
            DropIndex("dbo.Bairro", new[] { "Estados_Id" });
            DropIndex("dbo.Bairro", new[] { "Cidades_Id" });
            DropTable("dbo.Voto");
            DropTable("dbo.Lei");
            DropTable("dbo.Votocandidatoleis");
            DropTable("dbo.Presidente");
            DropTable("dbo.Favorito");
            DropTable("dbo.Cargo");
            DropTable("dbo.Candidatocargos");
            DropTable("dbo.Pessoa");
            DropTable("dbo.Logradouro");
            DropTable("dbo.Estado");
            DropTable("dbo.Cidade");
            DropTable("dbo.Bairro");
            DropTable("dbo.Pais");
        }
    }
}

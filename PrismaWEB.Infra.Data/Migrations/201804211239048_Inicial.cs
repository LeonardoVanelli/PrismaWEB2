namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Sobrenome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
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
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Cpf = c.String(maxLength: 100, unicode: false),
                        Foto = c.String(maxLength: 100, unicode: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(),
                        Ativo = c.Boolean(nullable: false),
                        Email = c.String(maxLength: 100, unicode: false),
                        TelefoneFixo = c.String(maxLength: 100, unicode: false),
                        TelefoneMovel = c.String(maxLength: 100, unicode: false),
                        Endereco = c.String(maxLength: 100, unicode: false),
                        Pais_Id = c.Int(nullable: false),
                        Estado_Id = c.Int(nullable: false),
                        Cidade_Id = c.Int(nullable: false),
                        Bairro_Id = c.Int(nullable: false),
                        Logradouro_Id = c.Int(nullable: false),
                        Cep = c.String(maxLength: 100, unicode: false),
                        Numero = c.String(maxLength: 100, unicode: false),
                        Complemento = c.String(maxLength: 100, unicode: false),
                        Tipo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Logradouro", t => t.Logradouro_Id)
                .ForeignKey("dbo.Estado", t => t.Estado_Id)
                .ForeignKey("dbo.Cidade", t => t.Cidade_Id)
                .ForeignKey("dbo.Bairro", t => t.Bairro_Id)
                .ForeignKey("dbo.Pais", t => t.Pais_Id)
                .Index(t => t.Cpf, unique: true)
                .Index(t => t.Email, unique: true)
                .Index(t => t.Pais_Id)
                .Index(t => t.Estado_Id)
                .Index(t => t.Cidade_Id)
                .Index(t => t.Bairro_Id)
                .Index(t => t.Logradouro_Id);
            
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
                "dbo.Produto",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Disponivel = c.Boolean(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produto", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.Pessoa", "Pais_Id", "dbo.Pais");
            DropForeignKey("dbo.Pessoa", "Bairro_Id", "dbo.Bairro");
            DropForeignKey("dbo.Bairro", "Paises_Id", "dbo.Pais");
            DropForeignKey("dbo.Pessoa", "Cidade_Id", "dbo.Cidade");
            DropForeignKey("dbo.Cidade", "Paises_Id", "dbo.Pais");
            DropForeignKey("dbo.Pessoa", "Estado_Id", "dbo.Estado");
            DropForeignKey("dbo.Estado", "Paises_Id", "dbo.Pais");
            DropForeignKey("dbo.Pessoa", "Logradouro_Id", "dbo.Logradouro");
            DropForeignKey("dbo.Logradouro", "Paises_Id", "dbo.Pais");
            DropForeignKey("dbo.Logradouro", "Estados_Id", "dbo.Estado");
            DropForeignKey("dbo.Logradouro", "Cidades_Id", "dbo.Cidade");
            DropForeignKey("dbo.Logradouro", "Bairros_Id", "dbo.Bairro");
            DropForeignKey("dbo.Cidade", "Estados_Id", "dbo.Estado");
            DropForeignKey("dbo.Bairro", "Estados_Id", "dbo.Estado");
            DropForeignKey("dbo.Bairro", "Cidades_Id", "dbo.Cidade");
            DropIndex("dbo.Produto", new[] { "ClienteId" });
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
            DropIndex("dbo.Pessoa", new[] { "Logradouro_Id" });
            DropIndex("dbo.Pessoa", new[] { "Bairro_Id" });
            DropIndex("dbo.Pessoa", new[] { "Cidade_Id" });
            DropIndex("dbo.Pessoa", new[] { "Estado_Id" });
            DropIndex("dbo.Pessoa", new[] { "Pais_Id" });
            DropIndex("dbo.Pessoa", new[] { "Email" });
            DropIndex("dbo.Pessoa", new[] { "Cpf" });
            DropTable("dbo.Produto");
            DropTable("dbo.Logradouro");
            DropTable("dbo.Estado");
            DropTable("dbo.Cidade");
            DropTable("dbo.Bairro");
            DropTable("dbo.Pessoa");
            DropTable("dbo.Pais");
            DropTable("dbo.Cliente");
        }
    }
}

namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bairro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 120, unicode: false),
                        Cidade_Id = c.Int(nullable: false),
                        Estado_Id = c.Int(nullable: false),
                        Pais_Id = c.Int(nullable: false),
                        Cidade_Id1 = c.Int(),
                        Estado_Id1 = c.Int(),
                        Pais_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cidade", t => t.Cidade_Id1)
                .ForeignKey("dbo.Estado", t => t.Estado_Id1)
                .ForeignKey("dbo.Pais", t => t.Pais_Id1)
                .Index(t => t.Cidade_Id1)
                .Index(t => t.Estado_Id1)
                .Index(t => t.Pais_Id1);
            
            CreateTable(
                "dbo.Cidade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 120, unicode: false),
                        Estado_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estado", t => t.Estado_Id)
                .Index(t => t.Estado_Id);
            
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 75, unicode: false),
                        Uf = c.String(nullable: false, maxLength: 2, unicode: false),
                        Pais_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pais", t => t.Pais_Id)
                .Index(t => t.Pais_Id);
            
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
                "dbo.Cargo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 420, unicode: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Nome, unique: true);
            
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
                "dbo.Leis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.String(nullable: false, maxLength: 20, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 120, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 450, unicode: false),
                        Autor_Id = c.Int(nullable: false),
                        LinkPdf = c.String(nullable: false, maxLength: 400, unicode: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Autor_Id)
                .Index(t => t.Autor_Id);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 120, unicode: false),
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
                        Tipo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bairro", t => t.Bairro_Id)
                .ForeignKey("dbo.Cidade", t => t.Cidade_Id)
                .ForeignKey("dbo.Estado", t => t.Estado_Id)
                .ForeignKey("dbo.Logradouro", t => t.Logradouro_Id)
                .ForeignKey("dbo.Pais", t => t.Pais_Id)
                .ForeignKey("dbo.TipoPessoa", t => t.Tipo_Id)
                .Index(t => t.Cpf, unique: true)
                .Index(t => t.Email, unique: true)
                .Index(t => t.Pais_Id)
                .Index(t => t.Estado_Id)
                .Index(t => t.Cidade_Id)
                .Index(t => t.Bairro_Id)
                .Index(t => t.Logradouro_Id)
                .Index(t => t.Tipo_Id);
            
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
                "dbo.TipoPessoa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 120, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 180, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.S_Acoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        Pagina_Id = c.Int(nullable: false),
                        Url = c.String(maxLength: 100, unicode: false),
                        Ativa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.S_Pagina", t => t.Pagina_Id)
                .Index(t => t.Pagina_Id);
            
            CreateTable(
                "dbo.S_Pagina",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        Controller = c.String(nullable: false, maxLength: 100, unicode: false),
                        Url = c.String(maxLength: 100, unicode: false),
                        Ativa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.S_Cadastros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pessoa_Id = c.Int(nullable: false),
                        Login = c.String(nullable: false, maxLength: 60, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 60, unicode: false),
                        UltimoAcesso = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        AlterarSenha = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id)
                .Index(t => t.Pessoa_Id);
            
            CreateTable(
                "dbo.S_ItensMenu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        Caption = c.String(nullable: false, maxLength: 60, unicode: false),
                        Tipo = c.Int(nullable: false),
                        url = c.String(maxLength: 100, unicode: false),
                        ItemPai_Id = c.Int(),
                        Action_Id = c.Int(),
                        Menu_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.S_Acoes", t => t.Action_Id)
                .ForeignKey("dbo.S_ItensMenu", t => t.ItemPai_Id)
                .ForeignKey("dbo.S_Menus", t => t.Menu_Id)
                .Index(t => t.ItemPai_Id)
                .Index(t => t.Action_Id)
                .Index(t => t.Menu_Id);
            
            CreateTable(
                "dbo.S_Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        Tipo = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.S_PapeisAcoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Acao_Id = c.Int(nullable: false),
                        Papel_Id = c.Int(nullable: false),
                        Conceder = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.S_Acoes", t => t.Acao_Id)
                .ForeignKey("dbo.S_Papeis", t => t.Papel_Id)
                .Index(t => t.Acao_Id)
                .Index(t => t.Papel_Id);
            
            CreateTable(
                "dbo.S_Papeis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 450, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Nome, unique: true);
            
            CreateTable(
                "dbo.S_Parametros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 120, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.S_PessoasPapeis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pessoa_Id = c.Int(nullable: false),
                        Papel_Id = c.Int(nullable: false),
                        Conceder = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.S_Papeis", t => t.Papel_Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id)
                .Index(t => t.Pessoa_Id)
                .Index(t => t.Papel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.S_PessoasPapeis", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.S_PessoasPapeis", "Papel_Id", "dbo.S_Papeis");
            DropForeignKey("dbo.S_PapeisAcoes", "Papel_Id", "dbo.S_Papeis");
            DropForeignKey("dbo.S_PapeisAcoes", "Acao_Id", "dbo.S_Acoes");
            DropForeignKey("dbo.S_ItensMenu", "Menu_Id", "dbo.S_Menus");
            DropForeignKey("dbo.S_ItensMenu", "ItemPai_Id", "dbo.S_ItensMenu");
            DropForeignKey("dbo.S_ItensMenu", "Action_Id", "dbo.S_Acoes");
            DropForeignKey("dbo.S_Cadastros", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.S_Acoes", "Pagina_Id", "dbo.S_Pagina");
            DropForeignKey("dbo.Produto", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.Leis", "Autor_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Pessoa", "Tipo_Id", "dbo.TipoPessoa");
            DropForeignKey("dbo.Pessoa", "Pais_Id", "dbo.Pais");
            DropForeignKey("dbo.Pessoa", "Logradouro_Id", "dbo.Logradouro");
            DropForeignKey("dbo.Logradouro", "Paises_Id", "dbo.Pais");
            DropForeignKey("dbo.Logradouro", "Estados_Id", "dbo.Estado");
            DropForeignKey("dbo.Logradouro", "Cidades_Id", "dbo.Cidade");
            DropForeignKey("dbo.Logradouro", "Bairros_Id", "dbo.Bairro");
            DropForeignKey("dbo.Pessoa", "Estado_Id", "dbo.Estado");
            DropForeignKey("dbo.Pessoa", "Cidade_Id", "dbo.Cidade");
            DropForeignKey("dbo.Pessoa", "Bairro_Id", "dbo.Bairro");
            DropForeignKey("dbo.Bairro", "Pais_Id1", "dbo.Pais");
            DropForeignKey("dbo.Bairro", "Estado_Id1", "dbo.Estado");
            DropForeignKey("dbo.Bairro", "Cidade_Id1", "dbo.Cidade");
            DropForeignKey("dbo.Cidade", "Estado_Id", "dbo.Estado");
            DropForeignKey("dbo.Estado", "Pais_Id", "dbo.Pais");
            DropIndex("dbo.S_PessoasPapeis", new[] { "Papel_Id" });
            DropIndex("dbo.S_PessoasPapeis", new[] { "Pessoa_Id" });
            DropIndex("dbo.S_Papeis", new[] { "Nome" });
            DropIndex("dbo.S_PapeisAcoes", new[] { "Papel_Id" });
            DropIndex("dbo.S_PapeisAcoes", new[] { "Acao_Id" });
            DropIndex("dbo.S_ItensMenu", new[] { "Menu_Id" });
            DropIndex("dbo.S_ItensMenu", new[] { "Action_Id" });
            DropIndex("dbo.S_ItensMenu", new[] { "ItemPai_Id" });
            DropIndex("dbo.S_Cadastros", new[] { "Pessoa_Id" });
            DropIndex("dbo.S_Acoes", new[] { "Pagina_Id" });
            DropIndex("dbo.Produto", new[] { "ClienteId" });
            DropIndex("dbo.Logradouro", new[] { "Paises_Id" });
            DropIndex("dbo.Logradouro", new[] { "Estados_Id" });
            DropIndex("dbo.Logradouro", new[] { "Cidades_Id" });
            DropIndex("dbo.Logradouro", new[] { "Bairros_Id" });
            DropIndex("dbo.Pessoa", new[] { "Tipo_Id" });
            DropIndex("dbo.Pessoa", new[] { "Logradouro_Id" });
            DropIndex("dbo.Pessoa", new[] { "Bairro_Id" });
            DropIndex("dbo.Pessoa", new[] { "Cidade_Id" });
            DropIndex("dbo.Pessoa", new[] { "Estado_Id" });
            DropIndex("dbo.Pessoa", new[] { "Pais_Id" });
            DropIndex("dbo.Pessoa", new[] { "Email" });
            DropIndex("dbo.Pessoa", new[] { "Cpf" });
            DropIndex("dbo.Leis", new[] { "Autor_Id" });
            DropIndex("dbo.Cargo", new[] { "Nome" });
            DropIndex("dbo.Estado", new[] { "Pais_Id" });
            DropIndex("dbo.Cidade", new[] { "Estado_Id" });
            DropIndex("dbo.Bairro", new[] { "Pais_Id1" });
            DropIndex("dbo.Bairro", new[] { "Estado_Id1" });
            DropIndex("dbo.Bairro", new[] { "Cidade_Id1" });
            DropTable("dbo.S_PessoasPapeis");
            DropTable("dbo.S_Parametros");
            DropTable("dbo.S_Papeis");
            DropTable("dbo.S_PapeisAcoes");
            DropTable("dbo.S_Menus");
            DropTable("dbo.S_ItensMenu");
            DropTable("dbo.S_Cadastros");
            DropTable("dbo.S_Pagina");
            DropTable("dbo.S_Acoes");
            DropTable("dbo.Produto");
            DropTable("dbo.TipoPessoa");
            DropTable("dbo.Logradouro");
            DropTable("dbo.Pessoa");
            DropTable("dbo.Leis");
            DropTable("dbo.Cliente");
            DropTable("dbo.Cargo");
            DropTable("dbo.Pais");
            DropTable("dbo.Estado");
            DropTable("dbo.Cidade");
            DropTable("dbo.Bairro");
        }
    }
}

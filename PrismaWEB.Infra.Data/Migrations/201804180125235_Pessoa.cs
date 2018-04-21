namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pessoa : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Pessoa", "Cpf", unique: true);
            CreateIndex("dbo.Pessoa", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Pessoa", new[] { "Email" });
            DropIndex("dbo.Pessoa", new[] { "Cpf" });
        }
    }
}

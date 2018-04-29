namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoa", "Nome", c => c.String(maxLength: 120, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoa", "Nome", c => c.String(maxLength: 100, unicode: false));
        }
    }
}

namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pais2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoa", "DataAlteracao", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoa", "DataAlteracao", c => c.DateTime(nullable: false));
        }
    }
}

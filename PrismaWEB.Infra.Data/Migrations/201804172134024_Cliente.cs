namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "DataAlteracao", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "DataAlteracao", c => c.DateTime(nullable: false));
        }
    }
}

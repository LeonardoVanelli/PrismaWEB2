namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.SqlServer;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoModeloDDD.Infra.Data.Contexto.ProjetoModeloContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjetoModeloDDD.Infra.Data.Contexto.ProjetoModeloContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }

        internal static class MissingDllHack
        {
            // Must reference a type in EntityFramework.SqlServer.dll so that this dll will be
            // included in the output folder of referencing projects without requiring a direct 
            // dependency on Entity Framework. See http://stackoverflow.com/a/22315164/1141360.
            private static SqlProviderServices instance = SqlProviderServices.Instance;
        }
    }
}

namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.SqlServer;

    internal sealed class Configuration : DbMigrationsConfiguration<Contexto.ProjetoModeloContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Contexto.ProjetoModeloContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
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

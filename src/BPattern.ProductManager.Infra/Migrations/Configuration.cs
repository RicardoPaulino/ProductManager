namespace BPattern.ProductManager.Infra.Migrations
{
    using BPattern.ProductManager.Infra.Data.Context;
    using System.Data.Entity.Migrations;
    internal sealed class Configuration : DbMigrationsConfiguration<AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

    }
}

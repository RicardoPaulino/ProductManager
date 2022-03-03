namespace BPattern.ProductManager.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enderec : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Endereços", newName: "Enderecos");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Enderecos", newName: "Endereços");
        }
    }
}

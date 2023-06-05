namespace Magazin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shop4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MagazinModels", "Price", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MagazinModels", "Price", c => c.Double(nullable: false));
        }
    }
}

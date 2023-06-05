namespace Magazin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shop3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MagazinModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MagazinModels");
        }
    }
}

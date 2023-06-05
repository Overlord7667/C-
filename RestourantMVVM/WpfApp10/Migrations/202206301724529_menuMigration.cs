namespace WpfApp10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class menuMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Photo = c.String(),
                        category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.category_Id)
                .Index(t => t.category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Menus", "category_Id", "dbo.Categories");
            DropIndex("dbo.Menus", new[] { "category_Id" });
            DropTable("dbo.Menus");
            DropTable("dbo.Categories");
        }
    }
}

namespace Kinoteatr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FilmCool : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        View = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Session = c.DateTime(nullable: false),
                        KinoteatrFilm_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KinoteatrFilms", t => t.KinoteatrFilm_Id)
                .Index(t => t.KinoteatrFilm_Id);
            
            CreateTable(
                "dbo.KinoteatrFilms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Films", "KinoteatrFilm_Id", "dbo.KinoteatrFilms");
            DropIndex("dbo.Films", new[] { "KinoteatrFilm_Id" });
            DropTable("dbo.KinoteatrFilms");
            DropTable("dbo.Films");
        }
    }
}

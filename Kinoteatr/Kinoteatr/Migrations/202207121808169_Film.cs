namespace Kinoteatr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Film : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Revenue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Revenue");
        }
    }
}

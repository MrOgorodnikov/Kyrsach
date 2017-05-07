namespace Kyrsach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteManufactureDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ShelfLifeInDays", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "ManufactureDate");
            DropColumn("dbo.Products", "ShelfLife");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ShelfLife", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "ManufactureDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Products", "ShelfLifeInDays");
        }
    }
}

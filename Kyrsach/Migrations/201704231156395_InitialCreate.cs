namespace Kyrsach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShelfLife = c.DateTime(nullable: false),
                        Name = c.String(),
                        EAN13 = c.String(),
                        Manufacturer = c.String(),
                        ManufactureDate = c.DateTime(nullable: false),
                        Price = c.Double(nullable: false),
                        ProductTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductTypes", t => t.ProductTypeId, cascadeDelete: true)
                .Index(t => t.ProductTypeId);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        IsFood = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NonFoods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        EAN13 = c.String(),
                        Manufacturer = c.String(),
                        ManufactureDate = c.DateTime(nullable: false),
                        Price = c.Double(nullable: false),
                        ProductTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductTypes", t => t.ProductTypeId, cascadeDelete: true)
                .Index(t => t.ProductTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NonFoods", "ProductTypeId", "dbo.ProductTypes");
            DropForeignKey("dbo.Foods", "ProductTypeId", "dbo.ProductTypes");
            DropIndex("dbo.NonFoods", new[] { "ProductTypeId" });
            DropIndex("dbo.Foods", new[] { "ProductTypeId" });
            DropTable("dbo.NonFoods");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Foods");
        }
    }
}

namespace Kyrsach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteFoodAndNonFood : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Foods", newName: "Products");
            DropIndex("dbo.NonFoods", new[] { "ProductTypeId" });
            DropTable("dbo.NonFoods");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.NonFoods", "ProductTypeId");
            RenameTable(name: "dbo.Products", newName: "Foods");
        }
    }
}

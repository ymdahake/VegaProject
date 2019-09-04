namespace Vega.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMenuRelatedRestaurantTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuCategories",
                c => new
                    {
                        MenuCategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Restaurant_RestaurantId = c.Int(),
                    })
                .PrimaryKey(t => t.MenuCategoryId)
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_RestaurantId)
                .Index(t => t.Restaurant_RestaurantId);
            
            CreateTable(
                "dbo.MenuItems",
                c => new
                    {
                        MenuIteamId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Price = c.Single(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        MenuCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MenuIteamId)
                .ForeignKey("dbo.MenuCategories", t => t.MenuCategoryId, cascadeDelete: true)
                .Index(t => t.MenuCategoryId);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        RestaurantId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Status = c.String(nullable: false),
                        PerPersonAmount = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RestaurantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuCategories", "Restaurant_RestaurantId", "dbo.Restaurants");
            DropForeignKey("dbo.MenuItems", "MenuCategoryId", "dbo.MenuCategories");
            DropIndex("dbo.MenuItems", new[] { "MenuCategoryId" });
            DropIndex("dbo.MenuCategories", new[] { "Restaurant_RestaurantId" });
            DropTable("dbo.Restaurants");
            DropTable("dbo.MenuItems");
            DropTable("dbo.MenuCategories");
        }
    }
}

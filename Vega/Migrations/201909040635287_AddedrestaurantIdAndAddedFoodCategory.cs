namespace Vega.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedrestaurantIdAndAddedFoodCategory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MenuCategories", "Restaurant_RestaurantId", "dbo.Restaurants");
            DropIndex("dbo.MenuCategories", new[] { "Restaurant_RestaurantId" });
            RenameColumn(table: "dbo.MenuCategories", name: "Restaurant_RestaurantId", newName: "RestaurantId");
            AddColumn("dbo.MenuItems", "FoodCategory", c => c.Int(nullable: false));
            AlterColumn("dbo.MenuCategories", "RestaurantId", c => c.Int(nullable: false));
            CreateIndex("dbo.MenuCategories", "RestaurantId");
            AddForeignKey("dbo.MenuCategories", "RestaurantId", "dbo.Restaurants", "RestaurantId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuCategories", "RestaurantId", "dbo.Restaurants");
            DropIndex("dbo.MenuCategories", new[] { "RestaurantId" });
            AlterColumn("dbo.MenuCategories", "RestaurantId", c => c.Int());
            DropColumn("dbo.MenuItems", "FoodCategory");
            RenameColumn(table: "dbo.MenuCategories", name: "RestaurantId", newName: "Restaurant_RestaurantId");
            CreateIndex("dbo.MenuCategories", "Restaurant_RestaurantId");
            AddForeignKey("dbo.MenuCategories", "Restaurant_RestaurantId", "dbo.Restaurants", "RestaurantId");
        }
    }
}

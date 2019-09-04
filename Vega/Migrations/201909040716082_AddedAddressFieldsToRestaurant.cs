namespace Vega.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAddressFieldsToRestaurant : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "Area", c => c.String());
            AddColumn("dbo.Restaurants", "City", c => c.String());
            AddColumn("dbo.Restaurants", "State", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Restaurants", "State");
            DropColumn("dbo.Restaurants", "City");
            DropColumn("dbo.Restaurants", "Area");
        }
    }
}

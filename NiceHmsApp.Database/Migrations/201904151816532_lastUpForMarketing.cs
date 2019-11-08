namespace NiceHmsApp.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastUpForMarketing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MarketingViewModels", "param_type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MarketingViewModels", "param_type");
        }
    }
}

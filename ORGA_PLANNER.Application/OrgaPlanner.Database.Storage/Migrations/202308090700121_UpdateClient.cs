namespace OrgaPlanner.Database.Storage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "DateCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "DateCreated");
        }
    }
}

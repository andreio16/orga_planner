namespace OrgaPlanner.Database.Storage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        isActive = c.Boolean(nullable: false),
                        Note = c.String(),
                        Title = c.String(),
                        Email = c.String(),
                        LastName = c.String(),
                        FirstName = c.String(),
                        Phonenumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}

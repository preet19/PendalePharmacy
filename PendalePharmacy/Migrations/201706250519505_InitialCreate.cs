namespace PendalePharmacy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drugs",
                c => new
                    {
                        DrugsID = c.Int(nullable: false, identity: true),
                        drugName = c.String(nullable: false),
                        comments = c.String(),
                    })
                .PrimaryKey(t => t.DrugsID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Drugs");
        }
    }
}

namespace PendalePharmacy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ins : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faq",
                c => new
                    {
                        FaqID = c.Int(nullable: false, identity: true),
                        comments = c.String(nullable: false),
                        name = c.String(nullable: false),
                        email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FaqID);
            
           
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        questionID = c.Int(nullable: false, identity: true),
                        comment = c.String(nullable: false),
                        name = c.String(nullable: false),
                        email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.questionID);
            
            DropTable("dbo.Faq");
        }
    }
}

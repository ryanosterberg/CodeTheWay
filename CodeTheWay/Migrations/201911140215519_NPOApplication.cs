namespace CodeTheWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NPOApplication : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NPOApplications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrgName = c.String(),
                        Email = c.String(),
                        PhoneNum = c.String(),
                        Address = c.String(),
                        ApplicantName = c.String(),
                        ApplicantPosition = c.String(),
                        ApplicantEmail = c.String(),
                        ApplicantPhone = c.String(),
                        NPOMission = c.String(),
                        NPOVision = c.String(),
                        WebURL = c.String(),
                        ProblemsAndDesires = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NPOApplications");
        }
    }
}

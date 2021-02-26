namespace CodeTheWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EndEmailReq : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NPOApplications", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NPOApplications", "Email", c => c.String(nullable: false));
        }
    }
}

namespace CodeTheWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Accomplishments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentApplications", "Accomplishments", c => c.String());
            AlterColumn("dbo.StudentApplications", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.StudentApplications", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.StudentApplications", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.StudentApplications", "HighSchool", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentApplications", "HighSchool", c => c.String());
            AlterColumn("dbo.StudentApplications", "Email", c => c.String());
            AlterColumn("dbo.StudentApplications", "LastName", c => c.String());
            AlterColumn("dbo.StudentApplications", "FirstName", c => c.String());
            DropColumn("dbo.StudentApplications", "Accomplishments");
        }
    }
}

namespace CodeTheWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nameSeparation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NPOApplications", "ApplicantFirstName", c => c.String(nullable: false));
            AddColumn("dbo.NPOApplications", "ApplicantLastName", c => c.String(nullable: false));
            AlterColumn("dbo.FacilitiesTechDonors", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.FacilitiesTechDonors", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.FacilitiesTechDonors", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.FacilitiesTechDonors", "Company", c => c.String(nullable: false));
            AlterColumn("dbo.FacilitiesTechDonors", "Offerings", c => c.String(nullable: false));
            AlterColumn("dbo.FinancialDonors", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.FinancialDonors", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.FinancialDonors", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.NPOApplications", "OrgName", c => c.String(nullable: false));
            AlterColumn("dbo.NPOApplications", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.NPOApplications", "ApplicantPosition", c => c.String(nullable: false));
            AlterColumn("dbo.NPOApplications", "NPOMission", c => c.String(nullable: false));
            AlterColumn("dbo.NPOApplications", "NPOVision", c => c.String(nullable: false));
            AlterColumn("dbo.NPOApplications", "ProblemsAndDesires", c => c.String(nullable: false));
            AlterColumn("dbo.VolunteerDonors", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.VolunteerDonors", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.VolunteerDonors", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.VolunteerDonors", "Company", c => c.String(nullable: false));
            AlterColumn("dbo.VolunteerDonors", "Offerings", c => c.String(nullable: false));
            DropColumn("dbo.NPOApplications", "ApplicantName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NPOApplications", "ApplicantName", c => c.String());
            AlterColumn("dbo.VolunteerDonors", "Offerings", c => c.String());
            AlterColumn("dbo.VolunteerDonors", "Company", c => c.String());
            AlterColumn("dbo.VolunteerDonors", "Email", c => c.String());
            AlterColumn("dbo.VolunteerDonors", "LastName", c => c.String());
            AlterColumn("dbo.VolunteerDonors", "FirstName", c => c.String());
            AlterColumn("dbo.NPOApplications", "ProblemsAndDesires", c => c.String());
            AlterColumn("dbo.NPOApplications", "NPOVision", c => c.String());
            AlterColumn("dbo.NPOApplications", "NPOMission", c => c.String());
            AlterColumn("dbo.NPOApplications", "ApplicantPosition", c => c.String());
            AlterColumn("dbo.NPOApplications", "Email", c => c.String());
            AlterColumn("dbo.NPOApplications", "OrgName", c => c.String());
            AlterColumn("dbo.FinancialDonors", "Email", c => c.String());
            AlterColumn("dbo.FinancialDonors", "LastName", c => c.String());
            AlterColumn("dbo.FinancialDonors", "FirstName", c => c.String());
            AlterColumn("dbo.FacilitiesTechDonors", "Offerings", c => c.String());
            AlterColumn("dbo.FacilitiesTechDonors", "Company", c => c.String());
            AlterColumn("dbo.FacilitiesTechDonors", "Email", c => c.String());
            AlterColumn("dbo.FacilitiesTechDonors", "LastName", c => c.String());
            AlterColumn("dbo.FacilitiesTechDonors", "FirstName", c => c.String());
            DropColumn("dbo.NPOApplications", "ApplicantLastName");
            DropColumn("dbo.NPOApplications", "ApplicantFirstName");
        }
    }
}

namespace CodeTheWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinancialDonor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FinancialDonors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        EstAmt = c.Double(nullable: false),
                        CurrentFrequency = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FinancialDonors");
        }
    }
}

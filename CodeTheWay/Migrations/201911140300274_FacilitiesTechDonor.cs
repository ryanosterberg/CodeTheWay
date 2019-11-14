namespace CodeTheWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FacilitiesTechDonor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FacilitiesTechDonors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Company = c.String(),
                        Offerings = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FacilitiesTechDonors");
        }
    }
}

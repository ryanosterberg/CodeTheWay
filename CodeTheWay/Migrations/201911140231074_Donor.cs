namespace CodeTheWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Donor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Donors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Company = c.String(),
                        Offerings = c.String(),
                        EstAmt = c.Double(),
                        CurrentFrequency = c.Int(),
                        Company1 = c.String(),
                        Offerings1 = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Donors");
        }
    }
}

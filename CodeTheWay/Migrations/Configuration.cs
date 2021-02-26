namespace CodeTheWay.Migrations
{
    using CodeTheWay.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeTheWay.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeTheWay.Models.ApplicationDbContext context)
        {


            if (!context.Users.Any(u => u.UserName == "rbennett@safenetconsulting.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser
                {
                    UserName = "rbennett@safenetconsulting.com",
                    Email = "rbennett@safenetconsulting.com",
                    EmailConfirmed = true
                };

                manager.Create(user, "Safenet01!");
           
            }
        }
    }
}

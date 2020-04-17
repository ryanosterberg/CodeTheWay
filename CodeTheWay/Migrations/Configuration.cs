namespace CodeTheWay.Migrations
{
    using CodeTheWay.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
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
            Dictionary<string, string> admins = new Dictionary<string, string>();
            admins.Add("ryanjbennett@live.com", "qqbreaksrr11");
            admins.Add("ryan.p.osterberg@gmail.com", "teamCTW1!");
            admins.Add("bzepecki@octaviantg.com", "2020CTWDominates!$");

            foreach(var kvp in admins)
            {
                if (!context.Users.Any(u => u.UserName == kvp.Key))
                {
                    var store = new UserStore<ApplicationUser>(context);
                    var manager = new UserManager<ApplicationUser>(store);
                    var user = new ApplicationUser
                    {
                        UserName = kvp.Key,
                        Email = kvp.Key,
                        EmailConfirmed = true
                    };

                    manager.Create(user, kvp.Value);

                }
            }

           


        }
    }
}

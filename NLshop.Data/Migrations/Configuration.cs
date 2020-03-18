namespace NLShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using NLshop.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NLShop.Data.NlShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NLShop.Data.NlShopDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new NlShopDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new NlShopDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "Nghiale",
                Email = "Nghiale@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "Le Nghia"

            };

            manager.Create(user, "123456@");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("Nghiale@gmail.com");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });

        }
    }
}

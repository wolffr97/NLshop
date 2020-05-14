﻿namespace NLShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using NLshop.Common;
    using NLshop.Model;
    using System;
    using System.Collections.Generic;
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
            CreateSlide(context);
        }
            //  This method will be called after migrating to the latest version.

        //    var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new NlShopDbContext()));

        //    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new NlShopDbContext()));

        //    var user = new ApplicationUser()
        //    {
        //        UserName = "Nghiale",
        //        Email = "Nghiale@gmail.com",
        //        EmailConfirmed = true,
        //        BirthDay = DateTime.Now,
        //        FullName = "Le Nghia"

        //    };

        //    manager.Create(user, "123456@");

        //    if (!roleManager.Roles.Any())
        //    {
        //        roleManager.Create(new IdentityRole { Name = "Admin" });
        //        roleManager.Create(new IdentityRole { Name = "User" });
        //    }

        //    var adminUser = manager.FindByEmail("Nghiale@gmail.com");

        //    manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });

        //}
        //private void CreateFooter(NlShopDbContext context)
        //{
        //    if (context.Footers.Count(x => x.ID == CommonConstants.DefaultFooterId) == 0)
        //    {
        //        string content = "";
        //    }
        //}
        private void CreateSlide(NlShopDbContext context)
        {
            if (context.Slides.Count() == 0)
            {
                List<Slide> listSlide = new List<Slide>()
                {
                    new Slide() {
                        Name ="Slide 1",
                        DisplayOrder =1,
                        Status =true,
                        Url ="#",
                        Image ="/Assets/client/images/bag.jpg",
                        Content =@"	<h2>FLAT 50% 0FF</h2>
                                <label>FOR ALL PURCHASE <b>VALUE</b></label>
                                <p>Lorem ipsum dolor sit amet, consectetur 
                            adipisicing elit, sed do eiusmod tempor incididunt ut labore et </ p >
                        <span class=""on-get"">GET NOW</span>" },
                    new Slide() {
                        Name ="Slide 2",
                        DisplayOrder =2,
                        Status =true,
                        Url ="#",
                        Image ="/Assets/client/images/bag1.jpg",
                    Content=@"<h2>FLAT 50% 0FF</h2>
                                <label>FOR ALL PURCHASE <b>VALUE</b></label>

                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et </ p >

                                <span class=""on-get"">GET NOW</span>"},
                };
                context.Slides.AddRange(listSlide);
                context.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using LootCrate4.Models.Identity;
using System.Data.Entity;
using LootCrate4.Models;
using System.Data.Entity.Migrations;
using LootCrate4.Migrations;

namespace LootCrate4
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());
            var migrator = new DbMigrator(new Configuration());
            migrator.Update();
            AreaRegistration.RegisterAllAreas();

        }
    }
}

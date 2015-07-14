namespace Iden.Migrations
{
    using Iden.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<Iden.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Iden.Models.ApplicationDbContext";
        }

        protected override void Seed(Iden.Models.ApplicationDbContext context)
        {
         
        }
    }
}

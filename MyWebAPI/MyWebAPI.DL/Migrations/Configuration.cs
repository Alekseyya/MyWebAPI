using MyWebAPI.DL.Entities;

namespace MyWebAPI.DL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyWebAPI.DL.Context.MyDbConnection>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyWebAPI.DL.Context.MyDbConnection context)
        {
            context.Clients.AddOrUpdate(u => u.Id,
               new Client { FirstName = "Admin", LastName = "Gena"},
               new Client { FirstName = "Manager", LastName = "Pena"}
               );
            context.SaveChanges();
        }
    }
}

using MyWebAPI.Entities;

namespace MyWebAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyWebAPI.Context.MyWebApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyWebAPI.Context.MyWebApiContext context)
        {
            context.Clients.AddOrUpdate(u => u.Id,
                new Client {FirstName = "Aleksey", LastName = "Gena"},
                new Client { FirstName = "Valera", LastName = "Petrox"}
                );
            context.SaveChanges();
        }
    }
}

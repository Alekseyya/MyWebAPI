using System.Data.Entity;
using MyWebAPI.Entities;

namespace MyWebAPI.Context
{
     public class MyWebApiContext : DbContext
    {
        public MyWebApiContext()
            : base("DbContext")
        { }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClientConfiguration());
        }
        public class DatabaseInitializer
            : CreateDatabaseIfNotExists<MyWebApiContext>
        {
            public override void InitializeDatabase(MyWebApiContext context)
            {

            }
        }
    }
}

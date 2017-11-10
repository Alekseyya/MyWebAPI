using System.Data.Entity;
using MyWebAPI.DL.Entities;

namespace MyWebAPI.DL.Context
{
    public class MyDbConnection: DbContext
    {
        public MyDbConnection()
            : base("DbContext")
        { }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClientConfiguration());
        }

        public class DatabaseInitializer
            : CreateDatabaseIfNotExists<MyDbConnection>
        {
            public override void InitializeDatabase(MyDbConnection context)
            {

            }
        }
    }
}

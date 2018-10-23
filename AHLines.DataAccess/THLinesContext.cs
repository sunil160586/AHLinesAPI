using AHLines.DataModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;

namespace AHLines.DataAccess
{
    public class THLinesContext : DbContext
    {
        public THLinesContext() : base("name=thLinesConnectionString")
        {
            Database.SetInitializer<THLinesContext>(new CreateDatabaseIfNotExists<THLinesContext>());
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 9999;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        void FixEfProviderServicesProblem()
        {
            var instance = SqlProviderServices.Instance;
        }

        public DbSet<News> News { get; set; }
    }
}
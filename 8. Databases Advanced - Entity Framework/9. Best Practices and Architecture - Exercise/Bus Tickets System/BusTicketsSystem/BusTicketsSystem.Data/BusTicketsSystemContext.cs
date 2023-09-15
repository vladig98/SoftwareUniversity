using Microsoft.EntityFrameworkCore;

namespace BusTicketsSystem.Data
{
    public class BusTicketsSystemContext : DbContext
    {
        public BusTicketsSystemContext() { }

        public BusTicketsSystemContext(DbContextOptions options)
            : base(options)
        {
        }

        //Include DbSets for all of your models
        //public DbSet<ModelName> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Apply model configuration after you've created the configuration in a separate file
            //modelBuilder.ApplyConfiguration(new ModelConfiguration());
        }
    }
}

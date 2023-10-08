using FDMC.Model;
using Microsoft.EntityFrameworkCore;

namespace FDMC.Data
{
    public class FDMCDbContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }

        public FDMCDbContext(DbContextOptions options) : base(options)
        {
        }

        public FDMCDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=FDMC;Integrated Security=true;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

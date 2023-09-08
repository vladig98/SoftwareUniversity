using Microsoft.EntityFrameworkCore;
using Pizzeria.Models;

namespace Pizzeria.Data
{
    public class PizzeriaContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; } 

        public PizzeriaContext(DbContextOptions options) : base(options)
        {
        }

        public PizzeriaContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasOne(x => x.Manager).WithMany(x => x.ManagerEmployees).HasForeignKey(x => x.ManagerId);
            });
        }
    }
}

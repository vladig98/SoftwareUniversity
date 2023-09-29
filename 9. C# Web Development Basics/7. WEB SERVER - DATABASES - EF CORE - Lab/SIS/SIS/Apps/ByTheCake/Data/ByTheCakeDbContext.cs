using ByTheCake.Models;
using Microsoft.EntityFrameworkCore;

namespace ByTheCake.Data
{
    public class ByTheCakeDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }

        public ByTheCakeDbContext(DbContextOptions options) : base(options)
        {
        }

        public ByTheCakeDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=ByTheCake;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>().HasKey(x => new { x.OrderId, x.ProductId });
            modelBuilder.Entity<OrderProduct>().HasOne(x => x.Product).WithMany(x => x.Orders).HasForeignKey(x => x.ProductId);
            modelBuilder.Entity<OrderProduct>().HasOne(x => x.Order).WithMany(x => x.Products).HasForeignKey(x => x.OrderId);
            modelBuilder.Entity<User>().HasMany(x => x.Orders).WithOne(x => x.User).HasForeignKey(x => x.UserId);
        }
    }
}

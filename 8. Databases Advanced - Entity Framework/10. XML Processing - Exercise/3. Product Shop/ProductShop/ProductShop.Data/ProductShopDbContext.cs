using Microsoft.EntityFrameworkCore;
using ProductShop.Data.Configuration;
using ProductShop.Models;

namespace ProductShop.Data
{
    public class ProductShopDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CategoryProduct> CategoryProducts { get; set; }
        public DbSet<Product> Products { get; set; }

        public ProductShopDbContext(DbContextOptions options) : base(options)
        {
        }

        protected ProductShopDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryProductConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}

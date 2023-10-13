using CHUSHKA.DbModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CHUSHKA.Data
{
    public class CHUSHKADbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

        public CHUSHKADbContext(DbContextOptions<CHUSHKADbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasMany(x => x.Orders).WithOne(x => x.Client).HasForeignKey(x => x.ClientId);
            builder.Entity<Product>().HasMany(x => x.Orders).WithOne(x => x.Product).HasForeignKey(x => x.ProductId);

            base.OnModelCreating(builder);
        }
    }
}

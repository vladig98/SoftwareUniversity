using Eventures.DbModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eventures.Data
{
    public class EventuresDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<EventuresEvent> EventuresEvents { get; set; }
        public DbSet<Order> Orders { get; set; }

        public EventuresDbContext(DbContextOptions<EventuresDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>().HasOne(x => x.Customer).WithMany(x => x.Orders).HasForeignKey(x => x.CustomerId);
            builder.Entity<Order>().HasOne(x => x.EventuresEvent).WithMany(x => x.Orders).HasForeignKey(x => x.EventuresEventId);
            base.OnModelCreating(builder);
        }
    }
}

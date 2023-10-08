using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PANDA.DbModels;

namespace PANDA.Data
{
    public class PandaDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Receipt> Receipts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(x => x.Receipts).WithOne(x => x.Recipient).HasForeignKey(x => x.RecipientId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<User>().HasMany(x => x.Packages).WithOne(x => x.Recipient).HasForeignKey(x => x.RecipientId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Receipt>().HasOne(x => x.Package).WithOne(x => x.Receipt).HasForeignKey<Package>(x => x.ReceiptId);
            modelBuilder.Entity<Package>().HasOne(x => x.Receipt).WithOne(x => x.Package).HasForeignKey<Receipt>(x => x.PackageId);

            base.OnModelCreating(modelBuilder);
        }

        public PandaDbContext(DbContextOptions<PandaDbContext> options) : base(options)
        {
        }
    }
}

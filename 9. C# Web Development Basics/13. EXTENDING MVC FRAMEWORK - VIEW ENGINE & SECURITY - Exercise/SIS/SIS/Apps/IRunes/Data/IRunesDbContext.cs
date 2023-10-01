using IRunes.Models;
using Microsoft.EntityFrameworkCore;

namespace IRunes.Data
{
    public class IRunesDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }

        public IRunesDbContext(DbContextOptions options) : base(options)
        {
        }

        public IRunesDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=IRunes;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasMany(x => x.Tracks).WithOne(x => x.Album).HasForeignKey(x => x.AlbumId);
        }
    }
}

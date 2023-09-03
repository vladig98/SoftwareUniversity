using Microsoft.EntityFrameworkCore;
using P02_FootballBetting.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02_FootballBetting.Data
{
    public class FootballBettingContext : DbContext
    {
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<PlayerStatistic> PlayersStatistics { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }

        public FootballBettingContext(DbContextOptions options) : base(options)
        {
        }

        protected FootballBettingContext()
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
            modelBuilder.Entity<Team>().HasOne(x => x.PrimaryKitColor).WithMany(x => x.PrimaryKitTeams).HasForeignKey(x => x.PrimaryKitColorId);
            modelBuilder.Entity<Team>().HasOne(x => x.SecondaryKitColor)
                .WithMany(x => x.SecondaryKitTeams).HasForeignKey(x => x.SecondaryKitColorId);
            modelBuilder.Entity<Team>().HasMany(x => x.HomeGames).WithOne(x => x.HomeTeam).HasForeignKey(x => x.HomeTeamId);
            modelBuilder.Entity<Team>().HasMany(x => x.AwayGames).WithOne(x => x.AwayTeam).HasForeignKey(x => x.AwayTeamId);
            modelBuilder.Entity<Team>().HasOne(x => x.Town).WithMany(x => x.Teams).HasForeignKey(x => x.TownId);
            modelBuilder.Entity<Team>().HasMany(x => x.Players).WithOne(x => x.Team).HasForeignKey(x => x.TeamId);
            modelBuilder.Entity<Team>().Property(x => x.Initials).HasMaxLength(3);

            modelBuilder.Entity<Color>().HasMany(x => x.PrimaryKitTeams).WithOne(x => x.PrimaryKitColor).HasForeignKey(x => x.PrimaryKitColorId);
            modelBuilder.Entity<Color>().HasMany(x => x.SecondaryKitTeams)
                .WithOne(x => x.SecondaryKitColor).HasForeignKey(x => x.SecondaryKitColorId);

            modelBuilder.Entity<Town>().HasMany(x => x.Teams).WithOne(x => x.Town).HasForeignKey(x => x.TownId);
            modelBuilder.Entity<Town>().HasOne(x => x.Country).WithMany(x => x.Towns).HasForeignKey(x => x.CountryId);

            modelBuilder.Entity<Game>().HasOne(x => x.HomeTeam).WithMany(x => x.HomeGames).HasForeignKey(x => x.HomeTeamId);
            modelBuilder.Entity<Game>().HasOne(x => x.AwayTeam).WithMany(x => x.AwayGames).HasForeignKey(x => x.AwayTeamId);
            modelBuilder.Entity<Game>().HasMany(x => x.Bets).WithOne(x => x.Game).HasForeignKey(x => x.GameId);
            modelBuilder.Entity<Game>().HasMany(x => x.PlayersStatistics).WithOne(x => x.Game).HasForeignKey(x => x.GameId);

            modelBuilder.Entity<Country>().HasMany(x => x.Towns).WithOne(x => x.Country).HasForeignKey(x => x.CountryId);

            modelBuilder.Entity<Player>().HasOne(x => x.Team).WithMany(x => x.Players).HasForeignKey(x => x.PlayerId);
            modelBuilder.Entity<Player>().HasOne(x => x.Position).WithMany(x => x.Players).HasForeignKey(x => x.PositionId);
            modelBuilder.Entity<Player>().HasMany(x => x.PlayersStatistics).WithOne(x => x.Player).HasForeignKey(x => x.PlayerId);

            modelBuilder.Entity<Position>().HasMany(x => x.Players).WithOne(x => x.Position).HasForeignKey(x => x.PositionId);

            modelBuilder.Entity<Bet>().HasOne(x => x.Game).WithMany(x => x.Bets).HasForeignKey(x => x.GameId);
            modelBuilder.Entity<Bet>().HasOne(x => x.User).WithMany(x => x.Bets).HasForeignKey(x => x.UserId);
            modelBuilder.Entity<Bet>().Property(x => x.Prediction).IsRequired(true);

            modelBuilder.Entity<User>().HasMany(x => x.Bets).WithOne(x => x.User).HasForeignKey(x => x.UserId);

            modelBuilder.Entity<PlayerStatistic>().HasKey(x => new { x.PlayerId, x.GameId });
        }
    }
}

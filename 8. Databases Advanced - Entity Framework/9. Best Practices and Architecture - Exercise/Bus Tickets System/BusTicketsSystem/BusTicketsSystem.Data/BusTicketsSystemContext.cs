﻿using BusTicketsSystem.Data.Configuration;
using BusTicketsSystem.Models;
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

        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<BusCompany> BusCompanies { get; set; }
        public DbSet<BusStation> BusStations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<ArrivedTrip> ArrivedTrips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BusCompanyConfiguration());
            modelBuilder.ApplyConfiguration(new BusStationConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            modelBuilder.ApplyConfiguration(new TownConfiguration());
            modelBuilder.ApplyConfiguration(new TripConfiguration());
            modelBuilder.ApplyConfiguration(new BankAccountConfiguration());
        }
    }
}

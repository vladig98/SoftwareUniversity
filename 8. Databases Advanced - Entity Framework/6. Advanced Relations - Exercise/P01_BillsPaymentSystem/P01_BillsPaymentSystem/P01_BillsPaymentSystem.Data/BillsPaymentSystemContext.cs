using Microsoft.EntityFrameworkCore;
using P01_BillsPaymentSystem.Data.EntityConfiguration;
using P01_BillsPaymentSystem.Data.Models;
using System;

namespace P01_BillsPaymentSystem.Data
{
    public class BillsPaymentSystemContext : DbContext
    {
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<User> Users { get; set; }

        public BillsPaymentSystemContext(DbContextOptions options) : base(options)
        {
        }

        public BillsPaymentSystemContext()
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
            modelBuilder.ApplyConfiguration(new BankAccountConfiguration());
            modelBuilder.ApplyConfiguration(new CreditCardConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentMethodConfiguration());
        }

        public void Seed(ModelBuilder modelBuilder)
        {

        }
    }
}

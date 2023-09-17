using BusTicketsSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicketsSystem.Data.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.HomeTown).WithMany(x => x.Customers).HasForeignKey(x => x.HomeTownId);
            builder.HasMany(x => x.Tickets).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId);
            builder.HasMany(x => x.Reviews).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.BankAccount).WithOne(x => x.Customer).HasForeignKey<Customer>(x => x.BankAccountId);
        }
    }
}

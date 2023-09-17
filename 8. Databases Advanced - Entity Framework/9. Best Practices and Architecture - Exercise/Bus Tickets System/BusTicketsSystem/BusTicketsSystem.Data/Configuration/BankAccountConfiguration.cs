using BusTicketsSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicketsSystem.Data.Configuration
{
    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Customer).WithOne(x => x.BankAccount).HasForeignKey<BankAccount>(x => x.CustomerId);
        }
    }
}

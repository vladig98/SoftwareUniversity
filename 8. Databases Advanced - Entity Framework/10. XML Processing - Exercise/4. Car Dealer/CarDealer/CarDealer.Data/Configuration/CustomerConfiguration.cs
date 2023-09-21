using CarDealer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDealer.Data.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasMany(x => x.Sales).WithOne(x => x.Customer).HasForeignKey(x => x.Customer_Id);
        }
    }
}

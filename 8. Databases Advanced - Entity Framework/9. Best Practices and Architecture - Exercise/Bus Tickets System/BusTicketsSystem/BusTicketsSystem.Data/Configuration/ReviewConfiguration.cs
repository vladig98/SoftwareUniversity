using BusTicketsSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicketsSystem.Data.Configuration
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.BusCompany).WithMany(x => x.Reviews).HasForeignKey(x => x.BusCompanyId);
            builder.HasOne(x => x.Customer).WithMany(x => x.Reviews).HasForeignKey(x => x.CustomerId);
        }
    }
}

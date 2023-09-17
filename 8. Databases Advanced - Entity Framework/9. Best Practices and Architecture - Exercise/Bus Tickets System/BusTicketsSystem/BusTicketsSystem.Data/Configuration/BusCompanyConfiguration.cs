using BusTicketsSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicketsSystem.Data.Configuration
{
    public class BusCompanyConfiguration : IEntityTypeConfiguration<BusCompany>
    {
        public void Configure(EntityTypeBuilder<BusCompany> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Reviews).WithOne(x => x.BusCompany).HasForeignKey(x => x.BusCompanyId);
            builder.HasMany(x => x.Trips).WithOne(x => x.BusCompany).HasForeignKey(x => x.BusCompanyId);
        }
    }
}

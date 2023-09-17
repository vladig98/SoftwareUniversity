using BusTicketsSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicketsSystem.Data.Configuration
{
    public class TownConfiguration : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Customers).WithOne(x => x.HomeTown).HasForeignKey(x => x.HomeTownId);
            builder.HasMany(x => x.BusStations).WithOne(x => x.Town).HasForeignKey(x => x.TownId);
        }
    }
}

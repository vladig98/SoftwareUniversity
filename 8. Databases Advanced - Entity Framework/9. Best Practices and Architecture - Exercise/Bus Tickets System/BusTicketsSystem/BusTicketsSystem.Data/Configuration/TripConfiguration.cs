using BusTicketsSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicketsSystem.Data.Configuration
{
    public class TripConfiguration : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Tickets).WithOne(x => x.Trip).HasForeignKey(x => x.TripId);
            builder.HasOne(x => x.BusCompany).WithMany(x => x.Trips).HasForeignKey(x => x.BusCompanyId);
            builder.HasOne(x => x.OriginBusStation).WithMany(x => x.OriginTrips).HasForeignKey(x => x.OriginBusStationId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.DestinationBusStation).WithMany(x => x.DestinationTrips).HasForeignKey(x => x.DestinationBusStationId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

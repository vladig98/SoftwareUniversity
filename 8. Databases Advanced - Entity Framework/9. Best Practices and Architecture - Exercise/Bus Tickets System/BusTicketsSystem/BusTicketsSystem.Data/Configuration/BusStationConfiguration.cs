using BusTicketsSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicketsSystem.Data.Configuration
{
    public class BusStationConfiguration : IEntityTypeConfiguration<BusStation>
    {
        public void Configure(EntityTypeBuilder<BusStation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Town).WithMany(x => x.BusStations).HasForeignKey(x => x.TownId);
            builder.HasMany(x => x.OriginTrips).WithOne(x => x.OriginBusStation).HasForeignKey(x => x.OriginBusStationId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.DestinationTrips).WithOne(x => x.DestinationBusStation).HasForeignKey(x => x.DestinationBusStationId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.ArrivedOriginTrips).WithOne(x => x.OriginBusStation).HasForeignKey(x => x.OriginBusStationId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.ArrivedDestinationTrips).WithOne(x => x.DestinationBusStation).HasForeignKey(x => x.DestinationBusStationId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

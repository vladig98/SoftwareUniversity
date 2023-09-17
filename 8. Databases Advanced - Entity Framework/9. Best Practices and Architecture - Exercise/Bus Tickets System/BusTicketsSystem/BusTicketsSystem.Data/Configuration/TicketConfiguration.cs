using BusTicketsSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicketsSystem.Data.Configuration
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Customer).WithMany(x => x.Tickets).HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.Trip).WithMany(x => x.Tickets).HasForeignKey(x => x.TripId);
        }
    }
}

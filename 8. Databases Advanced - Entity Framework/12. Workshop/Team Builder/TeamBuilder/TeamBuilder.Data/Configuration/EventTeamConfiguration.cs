using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamBuilder.Models;

namespace TeamBuilder.Data.Configuration
{
    public class EventTeamConfiguration : IEntityTypeConfiguration<TeamEvent>
    {
        public void Configure(EntityTypeBuilder<TeamEvent> builder)
        {
            builder.HasKey(x => new { x.EventId, x.TeamId });
            builder.HasOne(x => x.Event).WithMany(x => x.ParticipatingEventTeams).HasForeignKey(x => x.EventId);
            builder.HasOne(x => x.Team).WithMany(x => x.TeamEvents).HasForeignKey(x => x.TeamId);
        }
    }
}

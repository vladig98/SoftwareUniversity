using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamBuilder.Models;

namespace TeamBuilder.Data.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Username).IsRequired().HasMaxLength(25);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(30);
            builder.Property(x => x.FirstName).HasMaxLength(25);
            builder.Property(x => x.LastName).HasMaxLength(25);

            builder.HasIndex(x => x.Username).IsUnique();

            builder.HasMany(x => x.UserTeams).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(x => x.CreatedEvents).WithOne(x => x.Creator).HasForeignKey(x => x.CreatorId).OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.ReceivedInvitations).WithOne(x => x.InvitedUser).HasForeignKey(x => x.InvitedUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

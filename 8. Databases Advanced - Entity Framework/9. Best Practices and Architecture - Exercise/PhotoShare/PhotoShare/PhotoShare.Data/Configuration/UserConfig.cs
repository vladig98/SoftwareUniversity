﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhotoShare.Models;

namespace PhotoShare.Data.Configuration
{
    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Username)
                   .IsRequired()
                   .IsUnicode(false)
                   .HasMaxLength(30);

            builder.HasIndex(e => e.Username)
                   .IsUnique();

            builder.Property(e => e.Password)
                   .IsRequired();

            builder.Property(e => e.Email)
                   .HasMaxLength(80)
                   .IsRequired();

            builder.Property(e => e.FirstName)
                   .IsRequired(false)
                   .IsUnicode()
                   .HasMaxLength(60);

            builder.Property(e => e.LastName)
                   .IsRequired(false)
                   .IsUnicode()
                   .HasMaxLength(60);

            builder.Ignore(e => e.FullName);

            builder.HasOne(e => e.BornTown)
                   .WithMany(t => t.UsersBornInTown)
                   .HasForeignKey(e => e.BornTownId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.CurrentTown)
                   .WithMany(t => t.UsersCurrentlyLivingInTown)
                   .HasForeignKey(e => e.CurrentTownId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.ProfilePicture)
                   .WithOne(p => p.UserProfile)
                   .HasForeignKey<User>(u => u.ProfilePictureId);

            builder.Property(e => e.RegisteredOn)
                   .IsRequired(false)
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(e => e.LastTimeLoggedIn)
                   .IsRequired(false);

            builder.Property(e => e.Age)
                   .IsRequired(false);

            builder.Property(e => e.IsDeleted)
                   .IsRequired(true);

            builder.HasMany(x => x.FriendsAdded).WithOne(x => x.User).HasForeignKey(x => x.UserId);
        }
    }
}

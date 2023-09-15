﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhotoShare.Models;

namespace PhotoShare.Data.Configuration
{
    internal class TownConfig : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                   .HasMaxLength(60)
                   .IsRequired();

            builder.Property(e => e.Country)
                   .HasMaxLength(60);
        }
    }
}

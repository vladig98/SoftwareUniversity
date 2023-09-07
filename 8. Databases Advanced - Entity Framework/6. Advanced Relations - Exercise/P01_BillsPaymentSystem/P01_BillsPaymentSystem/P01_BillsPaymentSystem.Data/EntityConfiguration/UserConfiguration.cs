using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BillsPaymentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Data.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.UserId);
            builder.Property(x => x.FirstName).HasMaxLength(50).IsUnicode(true).IsRequired(true);
            builder.Property(x => x.LastName).HasMaxLength(50).IsUnicode(true).IsRequired(true);
            builder.Property(x => x.Email).HasMaxLength(80).IsUnicode(false).IsRequired(true);
            builder.Property(x => x.Password).HasMaxLength(25).IsUnicode(false).IsRequired(true);
        }
    }
}

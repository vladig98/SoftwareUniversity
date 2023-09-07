using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BillsPaymentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Data.EntityConfiguration
{
    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasKey(x => x.BankAccountId);
            builder.Property(x => x.Balance).IsRequired(true);
            builder.Property(x => x.BankName).HasMaxLength(50).IsUnicode(true).IsRequired(true);
            builder.Property(x => x.SWIFTCode).HasMaxLength(20).IsUnicode(false).IsRequired(true);
        }
    }
}

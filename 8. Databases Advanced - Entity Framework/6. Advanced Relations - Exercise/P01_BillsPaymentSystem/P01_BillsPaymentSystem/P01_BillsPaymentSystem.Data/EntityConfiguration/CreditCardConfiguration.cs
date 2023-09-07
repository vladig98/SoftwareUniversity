using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BillsPaymentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Data.EntityConfiguration
{
    public class CreditCardConfiguration : IEntityTypeConfiguration<CreditCard>
    {
        public void Configure(EntityTypeBuilder<CreditCard> builder)
        {
            builder.HasKey(x => x.CreditCardId);
            builder.Property(x => x.Limit).IsRequired(true);
            builder.Property(x => x.MoneyOwed).IsRequired(true);
            builder.Property(x => x.ExpirationDate).IsRequired(true);
            builder.Ignore(x => x.LimitLeft);
        }
    }
}

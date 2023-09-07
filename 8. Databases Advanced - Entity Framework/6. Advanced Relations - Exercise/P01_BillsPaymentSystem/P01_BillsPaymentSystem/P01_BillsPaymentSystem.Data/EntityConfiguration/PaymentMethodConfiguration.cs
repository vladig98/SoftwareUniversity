using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BillsPaymentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Data.EntityConfiguration
{
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Type).IsRequired(true);
            builder.Property(x => x.UserId).IsRequired(true);
            builder.HasIndex(x => new { x.UserId, x.CreditCardId, x.BankAccountId }).IsUnique(true);
            builder.HasCheckConstraint("BankAccountIdOrCreditCardId",
                "(BankAccountId IS NULL AND CreditCardId IS NOT NULL) OR \r\n     (BankAccountId IS NOT NULL AND CreditCardId IS NULL)");
            builder.HasOne(x => x.User).WithMany(x => x.PaymentMethods).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.BankAccount).WithOne(x => x.PaymentMethod).HasForeignKey<PaymentMethod>(x => x.BankAccountId);
            builder.HasOne(x => x.CreditCard).WithOne(x => x.PaymentMethod).HasForeignKey<PaymentMethod>(x => x.CreditCardId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductShop.Models;

namespace ProductShop.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.FirstName).IsRequired(false);
            builder.HasMany(x => x.ProductsSold).WithOne(x => x.Seller).HasForeignKey(x => x.SellerId);
            builder.HasMany(x => x.ProductsBought).WithOne(x => x.Buyer).HasForeignKey(x => x.BuyerId);
        }
    }
}

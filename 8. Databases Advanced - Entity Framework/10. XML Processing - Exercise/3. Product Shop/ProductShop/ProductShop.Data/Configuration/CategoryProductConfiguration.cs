using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductShop.Models;

namespace ProductShop.Data.Configuration
{
    public class CategoryProductConfiguration : IEntityTypeConfiguration<CategoryProduct>
    {
        public void Configure(EntityTypeBuilder<CategoryProduct> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.CategoryId });
            builder.HasOne(x => x.Product).WithMany(x => x.Categories).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
        }
    }
}

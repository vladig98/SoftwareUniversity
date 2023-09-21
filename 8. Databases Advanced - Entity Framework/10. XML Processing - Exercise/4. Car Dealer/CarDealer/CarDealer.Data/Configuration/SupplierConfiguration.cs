using CarDealer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDealer.Data.Configuration
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasMany(x => x.Parts).WithOne(x => x.Supplier).HasForeignKey(x => x.Supplier_Id);
        }
    }
}

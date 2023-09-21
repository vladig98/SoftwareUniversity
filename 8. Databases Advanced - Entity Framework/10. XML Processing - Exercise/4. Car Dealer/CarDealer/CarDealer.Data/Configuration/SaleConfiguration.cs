using CarDealer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDealer.Data.Configuration
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasOne(x => x.Car).WithMany(x => x.Sales).HasForeignKey(x => x.Car_Id);
        }
    }
}

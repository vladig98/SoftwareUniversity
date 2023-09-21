using CarDealer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDealer.Data.Configuration
{
    public class PartCarsConfiguration : IEntityTypeConfiguration<PartCar>
    {
        public void Configure(EntityTypeBuilder<PartCar> builder)
        {
            builder.HasKey(x => new { x.Part_Id, x.Car_Id });
            builder.HasOne(x => x.Car).WithMany(x => x.Parts).HasForeignKey(x => x.Car_Id);
            builder.HasOne(x => x.Part).WithMany(x => x.Cars).HasForeignKey(x => x.Part_Id);
        }
    }
}

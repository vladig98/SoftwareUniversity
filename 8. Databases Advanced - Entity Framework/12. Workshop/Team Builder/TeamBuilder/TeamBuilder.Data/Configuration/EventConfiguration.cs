using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamBuilder.Models;

namespace TeamBuilder.Data.Configuration
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(25).IsUnicode();
            builder.Property(x => x.Description).IsRequired().HasMaxLength(250).IsUnicode();
        }
    }
}

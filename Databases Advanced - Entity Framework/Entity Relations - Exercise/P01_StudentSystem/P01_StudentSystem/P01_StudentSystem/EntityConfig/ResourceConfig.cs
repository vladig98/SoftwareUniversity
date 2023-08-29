using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.EntityConfig
{
    public class ResourceConfig : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.HasKey(x => x.ResourceId);
            builder.Property(x => x.Name).HasMaxLength(50).IsUnicode(true);
            builder.Property(x => x.Url).IsUnicode(false);
            builder.HasOne(x => x.Course).WithMany(x => x.Resources).HasForeignKey(x => x.CourseId);

            builder.HasData(new Resource { CourseId = 1, Name = "Resource1", ResourceId = 1, ResourceType = ResourceType.Document, Url = "URL" });
        }
    }
}

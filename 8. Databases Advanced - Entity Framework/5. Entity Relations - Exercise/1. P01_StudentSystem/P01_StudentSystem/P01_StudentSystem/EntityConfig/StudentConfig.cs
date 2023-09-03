using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.EntityConfig
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.StudentId);
            builder.Property(x => x.Name).HasMaxLength(100).IsUnicode(true);
            builder.Property(x => x.PhoneNumber).HasMaxLength(10).IsUnicode(false).IsRequired(false);
            builder.Property(x => x.Birthday).IsRequired(false);
            builder.HasMany(x => x.CourseEnrollments).WithOne(x => x.Student).HasForeignKey(x => x.StudentId);
            builder.HasMany(x => x.HomeworkSubmissions).WithOne(x => x.Student).HasForeignKey(x => x.StudentId);

            builder.HasData(new Student { Birthday = DateTime.Now.AddYears(-22), Name = "Student1", PhoneNumber = "5555555555",
            RegisteredOn = DateTime.Now, StudentId = 1});
        }
    }
}

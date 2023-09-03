using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.EntityConfig
{
    public class HomeworkConfig : IEntityTypeConfiguration<Homework>
    {
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            builder.HasKey(x => x.HomeworkId);
            builder.Property(x => x.Content).IsUnicode(false);
            builder.HasOne(x => x.Course).WithMany(x => x.HomeworkSubmissions).HasForeignKey(x => x.CourseId);
            builder.HasOne(x => x.Student).WithMany(x => x.HomeworkSubmissions).HasForeignKey(x => x.StudentId);

            builder.HasData(new Homework { Content = "Content", ContentType = ContentType.Pdf, CourseId = 1, 
                HomeworkId = 1, StudentId = 1, SubmissionTime = DateTime.Now });
        }
    }
}

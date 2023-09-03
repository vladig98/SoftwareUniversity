using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.EntityConfig
{
    public class StudentCourseConfig : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(x => new { x.StudentId, x.CourseId });
            //builder.HasOne(x => x.Student).WithMany(x => x.CourseEnrollments).HasForeignKey(x => x.StudentId);
            //builder.HasOne(x => x.Course).WithMany(x => x.StudentsEnrolled).HasForeignKey(x => x.CourseId);

            builder.HasData(new StudentCourse { CourseId = 1, StudentId = 1 });
        }
    }
}

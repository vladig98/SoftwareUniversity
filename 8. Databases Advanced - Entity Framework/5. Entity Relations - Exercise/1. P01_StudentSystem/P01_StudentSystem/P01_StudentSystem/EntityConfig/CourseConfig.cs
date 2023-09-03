﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.EntityConfig
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.CourseId);
            builder.Property(x => x.Name).HasMaxLength(80).IsUnicode(true);
            builder.Property(x => x.Description).IsUnicode(true).IsRequired(false);
            builder.HasMany(x => x.StudentsEnrolled).WithOne(x => x.Course).HasForeignKey(x => x.CourseId);
            builder.HasMany(x => x.HomeworkSubmissions).WithOne(x => x.Course).HasForeignKey(x => x.CourseId);
            builder.HasMany(x => x.Resources).WithOne(x => x.Course).HasForeignKey(x => x.CourseId);
            
            builder.HasData(new Course { CourseId = 1, Name = "Course1", Description = "Description", StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(3), Price = 59.99M});
        }
    }
}

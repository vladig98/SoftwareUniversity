using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_HospitalDatabase.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_HospitalDatabase.EntityConfiguration
{
    public class VisitationConfig : IEntityTypeConfiguration<Visitation>
    {
        public void Configure(EntityTypeBuilder<Visitation> builder)
        {
            builder.HasKey(x => x.VisitationId);
            builder.Property(x => x.Comments).HasMaxLength(250).IsUnicode(true);
            builder.HasOne(x => x.Patient).WithMany(x => x.Visitations).HasForeignKey(x => x.PatientId);
            //builder.HasOne(x => x.Doctor).WithMany(x => x.Visitations).HasForeignKey(x => x.DoctorId);
        }
    }
}

using EFCore_Sesstion02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Sesstion02.Configurations
{
    internal class AttendeeConfigurations : IEntityTypeConfiguration<Attendee>
    {
        public void Configure(EntityTypeBuilder<Attendee> builder)
        {
            builder.Property(p => p.FullName).HasMaxLength(150);
            builder.Property(p => p.Email).HasMaxLength(200);
            builder.Property(p => p.Country).HasMaxLength(100);
            builder.Property(p => p.City).HasMaxLength(100);
            builder.Property(p => p.ZipCobe).HasMaxLength(20);
            builder.Property(p => p.ZipCobe).HasColumnName("ZipCobe");
            builder.Ignore(p => p.FullName);
        }
    }
}

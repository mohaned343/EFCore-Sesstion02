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
    internal class BadgeConfigurations : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasOne(p => p.Attendee)
                .WithOne(E => E.Badge)
                .HasForeignKey<Badge>(A => A.AttendeeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

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
    internal class OrganizerConfigurations : IEntityTypeConfiguration<Organizer>
    {
        public void Configure(EntityTypeBuilder<Organizer> builder)
        {
            builder.Property(d => d.Name).HasMaxLength(100);
            builder.Property(d => d.CompanyName).HasMaxLength(150);

            builder.HasOne(p => p.Profile)
                .WithOne(E => E.Organizer)
                .HasForeignKey<OrganizerProfile>(A => A.OrganizerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

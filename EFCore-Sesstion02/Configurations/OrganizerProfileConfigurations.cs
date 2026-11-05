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
    internal class OrganizerProfileConfigurations : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.Property(p => p.Id)
                .UseIdentityColumn(10, 10);
        }
    }
}

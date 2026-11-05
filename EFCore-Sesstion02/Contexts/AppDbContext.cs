using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore_Sesstion02.Models;
using EFCore_Sesstion02.Configurations;

namespace EFCore_Sesstion02.Contexts
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Platform;Trusted_Connection=True;TrustServerCertificate=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(b => {

                b.HasOne(p => p.OrganizerEV)
                .WithMany(E => E.events)
                .HasForeignKey(p => p.OrganizerEVId)
                .OnDelete(DeleteBehavior.Restrict);
            
            });



            modelBuilder.ApplyConfiguration(new AttendeeConfigurations());
            modelBuilder.ApplyConfiguration(new BadgeConfigurations());
            modelBuilder.ApplyConfiguration(new OrganizerConfigurations());
            modelBuilder.ApplyConfiguration(new OrganizerProfileConfigurations());
        }
    }
}

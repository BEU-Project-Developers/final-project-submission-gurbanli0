using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rentacar.domain.entity;

namespace Rentacar.domain
{
    public class AppDbContext : DbContext
    {
        public DbSet<CarEntity> Cars { get; set; }
        public DbSet<BookingEntity> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql
            (
                "Password=admin;Username=test;Database=postgres;Host=localhost;Port=5433"  //DEYISHHHSHHSHSHSHH
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Customer>()
                .HasIndex(p => p.Username)
                .IsUnique();

            // Define relationships
            modelBuilder.Entity<BookingEntity>()
                .HasOne<CarEntity>()
                .WithMany()
                .HasForeignKey(b => b.CarId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

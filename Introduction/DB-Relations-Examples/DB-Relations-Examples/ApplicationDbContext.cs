using DB_Relations_Examples.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB_Relations_Examples
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions options) : base(options){}
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<TypeHotel> TypeHotels { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<HotelFacility> HotelFacilities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER02;Database=HotelDataBaseFixed;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HotelFacility>()
                .HasKey(k => new { k.HotelId, k.FacilityId });

            modelBuilder.Entity<HotelFacility>()
                .HasOne(hf => hf.Hotel)
                .WithMany(h => h.HotelFacilities)
                .HasForeignKey(f => f.HotelId);

            modelBuilder.Entity<HotelFacility>()
                .HasOne(hf => hf.Facility)
                .WithMany(h => h.HotelFacilities)
                .HasForeignKey(f => f.FacilityId);
        }
    }
}

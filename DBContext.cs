using Microsoft.EntityFrameworkCore;
using FlightReservationApp.Models;

namespace FlightReservationApp
{
    public partial class DBContext : DbContext
    {
        private static string DbPath = "ReservationDataBase.db";
        public static bool DbCheck()
        {
            return File.Exists(DbPath);
        }
        public virtual DbSet<Aircraft> Aircrafts { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aircraft>(entity =>
            {
                entity.ToTable("Aircraft");
                entity.HasKey(e => e.AircraftId);
                entity.Property(e => e.AircraftModel).HasColumnType("TEXT");
                entity.Property(e => e.ACTrademark).HasColumnType("TEXT");
                entity.Property(e => e.ACSerialNumber).HasColumnType("TEXT");
                entity.Property(e => e.ACSeatCapacity).HasColumnType("INTEGER");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");
                entity.HasKey(e => e.LocationId);
                entity.Property(e => e.Country).HasColumnType("TEXT");
                entity.Property(e => e.City).HasColumnType("TEXT");
                entity.Property(e => e.Airport).HasColumnType("TEXT");
                entity.Property(e => e.Situation).HasColumnType("BOOLEAN");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("Reservation");
                entity.HasKey(e => e.ReservationId);
                entity.Property(e => e.AircraftId).HasColumnType("INTEGER");
                entity.Property(e => e.LocationId).HasColumnType("INTEGER");
                entity.Property(e => e.Date).HasColumnType("TEXT");
                entity.Property(e => e.CustomerIdCard).HasColumnType("TEXT");
                entity.Property(e => e.CustomerName).HasColumnType("TEXT");
                entity.Property(e => e.CustomerSurname).HasColumnType("TEXT");
                entity.Property(e => e.CustomerGender).HasColumnType("TEXT");
                entity.Property(e => e.SeatNumber).HasColumnType("INTEGER");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}

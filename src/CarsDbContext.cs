using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreSQLite
{
    public class CarsDbContext : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }

        public virtual DbSet<Garage> Garages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./cars.sqlite");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
            .HasKey(p => p.Id);
            
            modelBuilder.Entity<Car>()
            .Property(p => p.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Car>()
            .HasOne(p => p.Garage)
            .WithMany(p => p.Cars)
            .HasForeignKey(p => p.GarageId);

            modelBuilder.Entity<Garage>()
            .HasKey(p => p.Id);

            modelBuilder.Entity<Garage>()
            .Property(p => p.Id)
            .ValueGeneratedOnAdd();
        }
    }
}
﻿// <auto-generated />
using EFCoreSQLite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreSQLite.Migrations
{
    [DbContext(typeof(CarsDbContext))]
    partial class CarsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799");

            modelBuilder.Entity("EFCoreSQLite.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GarageId");

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.HasKey("Id");

                    b.HasIndex("GarageId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("EFCoreSQLite.Garage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Garages");
                });

            modelBuilder.Entity("EFCoreSQLite.Car", b =>
                {
                    b.HasOne("EFCoreSQLite.Garage", "Garage")
                        .WithMany("Cars")
                        .HasForeignKey("GarageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

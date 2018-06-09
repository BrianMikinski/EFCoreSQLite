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
            .HasOne(p => p.Garage);

            modelBuilder.Entity<Garage>()
            .HasKey(p => p.Id);

            modelBuilder.Entity<Garage>()
            .HasKey(p => p.Id);

            modelBuilder.Entity<Garage>()
            .HasMany(p => p.Cars);
        }

        //     private void ConfigureCategories(ModelBuilder modelBuilder)
        //     {
        //         modelBuilder.Entity<Category>()
        //             .HasKey(p => p.Id);

        //         modelBuilder.Entity<Category>()
        //             .ToTable("Category")
        //             .HasMany(e => e.Posts)
        //             .WithOne(e => e.Category)
        //             .HasForeignKey(e => e.CategoryId)
        //             .OnDelete(DeleteBehavior.Cascade);
        //     }

        //     private void ConfigurePosts(ModelBuilder modelBuilder)
        //     {
        //         modelBuilder.Entity<Post>()
        //             .ToTable("Post");

        //         modelBuilder.Entity<Post>()
        //             .Ignore(p => p.Tags);

        //         modelBuilder.Entity<Post>()
        //             .HasKey(p => p.Id);
        //     }

        //     private void ConfigurePostTags(ModelBuilder modelBuilder)
        //     {
        //         modelBuilder.Entity<PostTagMap>()
        //         .HasKey(p => new { p.Post_id, p.Tag_id });

        //         modelBuilder.Entity<PostTagMap>()
        //             .ToTable("PostTagMap")
        //             .HasOne(p => p.Post)
        //             .WithMany(p => p.PostTags)
        //             .HasForeignKey(p => p.Post_id);

        //         modelBuilder.Entity<PostTagMap>()
        //             .HasOne(p => p.Tag)
        //             .WithMany(p => p.PostTags)
        //             .HasForeignKey(p => p.Tag_id);
        //     }

        //     private void ConfigureTags(ModelBuilder modelBuilder)
        //     {
        //         modelBuilder.Entity<Tag>()
        //             .ToTable("Tag");

        //         modelBuilder.Entity<Tag>()
        //             .Ignore(p => p.Posts);

        //         modelBuilder.Entity<Tag>()
        //             .HasKey(p => p.Id);
        //     }
        // }
    }
}
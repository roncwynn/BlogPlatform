using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogPlatform.Models;

namespace BlogPlatform.Context
{
    public class BlogPlatformContext: DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogPlatform_Database;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<ContentTag>().HasKey(sc => new { sc.ContentId, sc.TagId });
            modelbuilder.Entity<Genre>().HasData(

                new Genre(1, "Woodworking", "Build furniture today!","Wood.jpg"),
                new Genre(2, "Gardening","Growing Extremely Hot Peppers","Garden.jpg"),
                new Genre(3, "Pools", "Backyard adventures await", "Pools.jpg")
                ); 

            modelbuilder.Entity<Content>().HasData(

               new Content(1, 1, "My first candle boat", "Rons super wood", "Jay Bowen",  DateTime.Now),
               new Content(2, 1, "My second candle boat", "Ash", "Ron Wynn", DateTime.Now),
               new Content(3, 2, "Pull Weeds", "All veggies", "Ron Wynn", DateTime.Now),
               new Content(4, 3, "Swimming", "this is body", "Jay Bowen", DateTime.Now)
               );

            modelbuilder.Entity<Tag>().HasData(

                new Tag(1, "Hot Peppers"),
                new Tag(2, "Mild Peppers"),
                new Tag(3, "Corn"),
                new Tag(4, "Rafting"),
                new Tag(5, "Oak"),
                new Tag(6, "Maple"),
                new Tag(7, "Table Saw")
                );

            modelbuilder.Entity<ContentTag>().HasData(
                new ContentTag(1, 1),
                new ContentTag(1, 2),
                new ContentTag(2, 1),
                new ContentTag(2, 3),
                new ContentTag(3, 2),
                new ContentTag(3, 3)
                );

            // base.OnModelCreating(modelBuilder);
        }
    }
    }


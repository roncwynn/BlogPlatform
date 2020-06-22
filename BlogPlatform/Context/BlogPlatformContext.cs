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

                new Genre(1, "Woodworking", "Build furniture today!"),
                new Genre(2, "Life","Husbands who are VolunTOLD by their wives"),
                new Genre(3, "Pools", "Backyard adventures await")
                ); 

            modelbuilder.Entity<Content>().HasData(

               new Content(1, 1, "My first candle boat", "Rons super wood", "Jay Bowen",  DateTime.Now),
               new Content(2, 1, "My second candle boat", "Ash", "Ron Wynn", DateTime.Now),
               new Content(3, 2, "Clean house", "All rooms", "Ron Wynn", DateTime.Now),
               new Content(4, 3, "Swimming", "this is body", "Ron Wynn", DateTime.Now)
               );

            modelbuilder.Entity<Tag>().HasData(

                new Tag(1, "Tag1"),
                new Tag(2, "Tag2"),
                new Tag(3, "Tag3")
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


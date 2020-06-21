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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogPlatformDatabase;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

            modelbuilder.Entity<Genre>().HasData(

                new Genre(1, "Woodworking", "Build furniture today!"),
                new Genre(2, "Life","Husbands who are VolunTOLD by their wives")
                ); 

            modelbuilder.Entity<Content>().HasData(

               new Content(1, 1, "My first candle boat", "Rons super wood", "Jay Bowen",  DateTime.Now),
               new Content(2, 1, "My second candle boat", "Ash", "Ron Wynn", DateTime.Now),
               new Content(3, 2, "Clean house", "All rooms", "Ron Wynn", DateTime.Now)
               ); 

           // base.OnModelCreating(modelBuilder);
        }
    }
    }


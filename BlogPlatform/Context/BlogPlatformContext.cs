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

                new Genre(1, "Woodworking", "Build furniture today!")


                ); 

            modelbuilder.Entity<Content>().HasData(

               new Content(1, 1, "My first candle boat", "Rons super wood", "Jay Bowen",  DateTime.Now)


               ); 

           // base.OnModelCreating(modelBuilder);
        }
    }
    }


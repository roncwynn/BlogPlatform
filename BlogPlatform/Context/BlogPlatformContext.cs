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

               new Content(1, 1, "Taking the Tool to Wood", "Or forefather produced furniture at an incredible rate.  Is this because they were just that much more talented than we are today?  Possibly but they had the benefit of not knowing any other way to work and they took advantage of the unique nature of hand work to be efficient and eliminate steps that we would go through today in order to work with a machine.  ", "Jay Bowen",  DateTime.Now),
               new Content(2, 1, "Nails 101", "Nails not only are 'acceptable' in your woodworking projects but they have experienced a resurgence in popularity.  But these are not the wire nails you will find at the typical hardware store.  These are the 18th and 19th century variants: cut nails and wrought nails.  Both of these types of nails have substantially more holding power then the modern equivalents but require a bit more care when driving them in.  First and foremost, in almost all cases you will want to bore a pilot hole before you reach for the hammer.", "Ron Wynn", DateTime.Now),
               new Content(3, 2, "Grow your own food", "In its simplest form, a kitchen garden produces fresh fruits, vegetables and herbs for delicious, healthy meals. A kitchen garden doesn’t have to be right outside the kitchen door, but the closer it is, the better. Think about it this way: The easier it is for you to get into the garden, the more likely it is that you will get tasty things out of it. Did you forget to add the chopped dill on your boiled red-skinned potatoes? No problem — it’s just steps away.", "Ron Wynn", DateTime.Now),
               new Content(4, 3, "Winterize your pool", "Your pool and spa are big investments, so it’s important to maintain them year-round. In this blog, we’ll go over the winterization basics for inground pools and above ground pools, as well as touch on spas and recommended products.", "Jay Bowen", DateTime.Now)
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
        }
    }
    }


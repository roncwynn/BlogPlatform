﻿// <auto-generated />
using System;
using BlogPlatform.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogPlatform.Migrations
{
    [DbContext(typeof(BlogPlatformContext))]
    [Migration("20200628180303_AddedImagesToGenres")]
    partial class AddedImagesToGenres
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogPlatform.Models.Content", b =>
                {
                    b.Property<int>("ContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContentId");

                    b.HasIndex("GenreId");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            ContentId = 1,
                            Author = "Jay Bowen",
                            Body = "Rons super wood",
                            GenreId = 1,
                            PublishDate = new DateTime(2020, 6, 28, 14, 3, 2, 530, DateTimeKind.Local).AddTicks(1985),
                            Title = "My first candle boat"
                        },
                        new
                        {
                            ContentId = 2,
                            Author = "Ron Wynn",
                            Body = "Ash",
                            GenreId = 1,
                            PublishDate = new DateTime(2020, 6, 28, 14, 3, 2, 532, DateTimeKind.Local).AddTicks(9688),
                            Title = "My second candle boat"
                        },
                        new
                        {
                            ContentId = 3,
                            Author = "Ron Wynn",
                            Body = "All veggies",
                            GenreId = 2,
                            PublishDate = new DateTime(2020, 6, 28, 14, 3, 2, 532, DateTimeKind.Local).AddTicks(9812),
                            Title = "Pull Weeds"
                        },
                        new
                        {
                            ContentId = 4,
                            Author = "Jay Bowen",
                            Body = "this is body",
                            GenreId = 3,
                            PublishDate = new DateTime(2020, 6, 28, 14, 3, 2, 532, DateTimeKind.Local).AddTicks(9821),
                            Title = "Swimming"
                        });
                });

            modelBuilder.Entity("BlogPlatform.Models.ContentTag", b =>
                {
                    b.Property<int>("ContentId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("ContentId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ContentTag");

                    b.HasData(
                        new
                        {
                            ContentId = 1,
                            TagId = 1
                        },
                        new
                        {
                            ContentId = 1,
                            TagId = 2
                        },
                        new
                        {
                            ContentId = 2,
                            TagId = 1
                        },
                        new
                        {
                            ContentId = 2,
                            TagId = 3
                        },
                        new
                        {
                            ContentId = 3,
                            TagId = 2
                        },
                        new
                        {
                            ContentId = 3,
                            TagId = 3
                        });
                });

            modelBuilder.Entity("BlogPlatform.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Build furniture today!",
                            ImageName = "Wood.jpg",
                            Name = "Woodworking"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Growing Extremely Hot Peppers",
                            ImageName = "Garden.jpg",
                            Name = "Gardening"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Backyard adventures await",
                            ImageName = "Pools.jpg",
                            Name = "Pools"
                        });
                });

            modelBuilder.Entity("BlogPlatform.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hot Peppers"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mild Peppers"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Corn"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Rafting"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Oak"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Maple"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Table Saw"
                        });
                });

            modelBuilder.Entity("BlogPlatform.Models.Content", b =>
                {
                    b.HasOne("BlogPlatform.Models.Genre", "Genre")
                        .WithMany("Content")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogPlatform.Models.ContentTag", b =>
                {
                    b.HasOne("BlogPlatform.Models.Content", "Content")
                        .WithMany("ContentTags")
                        .HasForeignKey("ContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogPlatform.Models.Tag", "Tag")
                        .WithMany("ContentTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

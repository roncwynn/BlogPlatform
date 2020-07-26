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
    [Migration("20200621222823_tagtest")]
    partial class tagtest
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
                            PublishDate = new DateTime(2020, 6, 21, 18, 28, 22, 996, DateTimeKind.Local).AddTicks(6433),
                            Title = "My first candle boat"
                        },
                        new
                        {
                            ContentId = 2,
                            Author = "Ron Wynn",
                            Body = "Ash",
                            GenreId = 1,
                            PublishDate = new DateTime(2020, 6, 21, 18, 28, 22, 999, DateTimeKind.Local).AddTicks(6946),
                            Title = "My second candle boat"
                        },
                        new
                        {
                            ContentId = 3,
                            Author = "Ron Wynn",
                            Body = "All rooms",
                            GenreId = 2,
                            PublishDate = new DateTime(2020, 6, 21, 18, 28, 22, 999, DateTimeKind.Local).AddTicks(7066),
                            Title = "Clean house"
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

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Build furniture today!",
                            Name = "Woodworking"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Husbands who are VolunTOLD by their wives",
                            Name = "Life"
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
                            Name = "Tag One"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tag two"
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
#pragma warning restore 612, 618
        }
    }
}

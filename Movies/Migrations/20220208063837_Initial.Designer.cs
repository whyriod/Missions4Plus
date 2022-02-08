﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies.Models;

namespace Movies.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220208063837_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Movies.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Drama"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Family"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 6,
                            Name = "Miscellaneous"
                        },
                        new
                        {
                            CategoryId = 7,
                            Name = "Television"
                        },
                        new
                        {
                            CategoryId = 8,
                            Name = "VHS"
                        });
                });

            modelBuilder.Entity("Movies.Models.MovieModel", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Edited")
                        .HasColumnType("TEXT");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 1,
                            Director = "Jerry London",
                            Edited = "",
                            LentTo = "",
                            Notes = "Old Time Classic",
                            Rating = "PG",
                            Title = "The Scarlet And The Black",
                            Year = 1967
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 3,
                            Director = "Melvin Frank and Norman Panama",
                            Edited = "",
                            LentTo = "",
                            Notes = "Greate for laughs",
                            Rating = "G",
                            Title = "The Court Jester",
                            Year = 1955
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 2,
                            Director = "Robert Stevenson",
                            Edited = "",
                            LentTo = "",
                            Notes = "Original Flubber",
                            Rating = "G",
                            Title = "The Absent-Minded Professor",
                            Year = 1961
                        });
                });

            modelBuilder.Entity("Movies.Models.MovieModel", b =>
                {
                    b.HasOne("Movies.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies.Models;

namespace Movies.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Movies.Models.MovieModel", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<string>("Edited")
                        .HasColumnType("TEXT");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Action",
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
                            Category = "Comedy",
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
                            Category = "Comedy",
                            Director = "Robert Stevenson",
                            Edited = "",
                            LentTo = "",
                            Notes = "Original Flubber",
                            Rating = "G",
                            Title = "The Absent-Minded Professor",
                            Year = 1961
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

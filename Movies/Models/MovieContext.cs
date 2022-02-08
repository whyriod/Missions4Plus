using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MovieContext : DbContext
    {
        /*Constructor*/
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }
        public DbSet<MovieModel> Movies { get; set; }
        public DbSet<Category> Categories { get;set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Action/Adventure" },
                new Category { CategoryId = 2, Name = "Comedy" },
                new Category { CategoryId = 3, Name = "Drama" },
                new Category { CategoryId = 4, Name = "Family" },
                new Category { CategoryId = 5, Name = "Horror/Suspense" },
                new Category { CategoryId = 6, Name = "Miscellaneous" },
                new Category { CategoryId = 7, Name = "Television" },
                new Category { CategoryId = 8, Name = "VHS" }
            ) ;

            mb.Entity<MovieModel>().HasData(
                new MovieModel
                {
                    MovieId = 1,
                    Title = "The Scarlet And The Black",
                    Year = 1967,
                    CategoryId = 1,
                    Director = "Jerry London",
                    Rating = "PG",
                    Edited = "",
                    LentTo = "",
                    Notes = "Old Time Classic"
                },

                new MovieModel
                {
                    MovieId = 2,
                    Title = "The Court Jester",
                    Year = 1955,
                    CategoryId = 3,
                    Director = "Melvin Frank and Norman Panama",
                    Rating = "G",
                    Edited = "",
                    LentTo = "",
                    Notes = "Greate for laughs"
                },

                new MovieModel
                {
                    MovieId = 3,
                    Title = "The Absent-Minded Professor",
                    Year = 1961,
                    CategoryId = 2,
                    Director = "Robert Stevenson",
                    Rating = "G",
                    Edited = "",
                    LentTo = "",
                    Notes = "Original Flubber"
                }
            );
        }
    }
}

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
        public DbSet<MovieModel> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieModel>().HasData(
                new MovieModel
                {
                    MovieId = 1,
                    Title = "The Scarlet And The Black",
                    Year = 1967,
                    Category = "Action",
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
                    Category = "Comedy",
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
                    Category = "Comedy",
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

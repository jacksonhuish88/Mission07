using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission07.Models
{
    public class MovieContext : DbContext
    {
       // Constructor
        public MovieContext (DbContextOptions <MovieContext> options) : base(options)
        {
            // Leave blank for now
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }


        // Seeding the Data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryType = "Comedy"},
                new Category { CategoryId = 2, CategoryType = "Drama" },
                new Category { CategoryId = 3, CategoryType = "Family" },
                new Category { CategoryId = 4, CategoryType = "Horror / Suspense" },
                new Category { CategoryId = 5, CategoryType = "Miscellaneous" },
                new Category { CategoryId = 6, CategoryType = "Television" },
                new Category { CategoryId = 7, CategoryType = "VHS" }
            );

            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    CategoryId = 2,
                    title = "Gladiator",
                    year = 2000,
                    director = "Ridley Scott",
                    rating = "R",
                    edited = false,

                },
                new Movie
                {
                    MovieId = 2,
                    CategoryId = 2,
                    title = "American Sniper",
                    year = 2014,
                    director = "Clint Eastwood",
                    rating = "R",
                    edited = false,
                },
                new Movie
                {
                    MovieId = 3,
                    CategoryId = 3,
                    title = "The Batman",
                    year = 2022,
                    director = "Matt Reeves",
                    rating = "PG-13",
                    edited = false,

                }
            );
        }
    }
}

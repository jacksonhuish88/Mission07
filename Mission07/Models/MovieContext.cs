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

        public DbSet<HomeControllerModel> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<HomeControllerModel>().HasData(
                new HomeControllerModel
                {
                    MovieId = 1,
                    category = "Action",
                    title = "Gladiator",
                    year = 2000,
                    director = "Ridley Scott",
                    rating = "R",
                    edited = false,

                },
                new HomeControllerModel
                {
                    MovieId = 2,
                    category = "Action",
                    title = "American Sniper",
                    year = 2014,
                    director = "Clint Eastwood",
                    rating = "R",
                    edited = false,
                },
                new HomeControllerModel
                {
                    MovieId = 3,
                    category = "Action",
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

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_jn375.Models
{
    public class AppContext : DbContext
    {
        // constructor
        public AppContext (DbContextOptions<AppContext> options) : base(options)
        {
            // leave blank for now
        }

        public DbSet<ModelClass> MovieInputs { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action" },
                new Category { CategoryId = 2, CategoryName = "Drama" },
                new Category { CategoryId = 3, CategoryName = "Thriller" },
                new Category { CategoryId = 4, CategoryName = "Comedy" }
                );
            mb.Entity<ModelClass>().HasData(
                new ModelClass
                {
                    MovieId = 1,
                    Title = "Count of Monte Cristo",
                    CategoryId = 1,
                    Year = 2002,
                    Director = "Kevin Reynolds",
                    Rating = "PG-13",
                    Edited = true,
                    LentTo = "",
                    Notes = ""
                },
                new ModelClass
                {
                    MovieId = 2,
                    Title = "Coco",
                    CategoryId = 2,
                    Year = 2017,
                    Director = "Adrian Molina",
                    Rating = "PG",
                    Edited = true,
                    LentTo = "",
                    Notes = ""

                },

                new ModelClass
                {
                    MovieId = 3,
                    Title = "Spirit",
                    CategoryId = 3,
                    Year = 2002,
                    Director = "Kelly Asbury",
                    Rating = "G",
                    Edited = true,
                    LentTo = "",
                    Notes = ""

                }

                );
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using movies_app.Data;
using System;
using System.Linq;

namespace movies_app.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new movies_appContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<movies_appContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Lucy",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "7Signs ",
                        ReleaseDate = DateTime.Parse("2001-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "The Hero",
                        ReleaseDate = DateTime.Parse("2004-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Red Dog",
                        ReleaseDate = DateTime.Parse("2021-11-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
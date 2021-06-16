using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Harry Potter",
                        ReleaseDate = DateTime.Parse("2003-5-28"),
                        Rating = "R",
                        Genre = "Test",
                        Price = 75.5M
                    },
                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Rating = "R", 
                        Genre = "Test",
                        Price = 8.99M
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Rating = "R", 
                        Genre = "Test",

                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Rating = "R", 
                        Genre = "Test",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
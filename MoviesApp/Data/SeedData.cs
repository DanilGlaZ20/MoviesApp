using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoviesApp.Models;

namespace MoviesApp.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MoviesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MoviesContext>>()))
            {
                // Look for any movies.
                if (!context.Movies.Any())
                {


                    context.Movies.AddRange(
                        new Movie
                        {
                            Title = "When Harry Met Sally",
                            ReleaseDate = DateTime.Parse("1989-2-12"),
                            Genre = "Romantic Comedy",
                            Price = 7.99M
                        },


                        new Movie
                        {
                            Title = "Ghostbusters ",
                            ReleaseDate = DateTime.Parse("1984-3-13"),
                            Genre = "Comedy",
                            Price = 8.99M
                        },

                        new Movie
                        {
                            Title = "Ghostbusters 2",
                            ReleaseDate = DateTime.Parse("1986-2-23"),
                            Genre = "Comedy",
                            Price = 9.99M
                        },

                        new Movie
                        {
                            Title = "Rio Bravo2",
                            ReleaseDate = DateTime.Parse("1959-4-15"),
                            Genre = "Western",
                            Price = 3.99M
                        }
                    );

                    context.SaveChanges();

                }

                using (var _context = new MoviesContext(
                    serviceProvider.GetRequiredService<
                        DbContextOptions<MoviesContext>>()))
                {
                    // Look for any movies.
                    if (!_context.Actor.Any())
                    {



                        _context.Actor.AddRange(

                            new Actor
                            {
                                Name = "Dmitry",
                                Surname = "Biruzov",
                                Birth = DateTime.Parse("1991-10-10")


                            },

                            new Actor
                            {
                                Name = "Dennis",
                                Surname = "Rodman",
                                Birth = DateTime.Parse("2001-1-15")

                            },
                            new Actor
                            {
                                Name = "Aleksey",
                                Surname = "Sved",
                                Birth = DateTime.Parse("1988-3-9")

                            },
                            new Actor
                            {
                                Name = "Anna",
                                Surname = "Lein",
                                Birth = DateTime.Parse("2004-4-22")

                            },
                            new Actor
                            {
                                Name = "Diana",
                                Surname = "Krotova",
                                Birth = DateTime.Parse("199-5-30")

                            }
                        );

                        _context.SaveChanges();
                    }

                    var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();
                    var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();

                    if (!roleManager.RoleExistsAsync("Admin").Result)
                    {
                        roleManager.CreateAsync(new IdentityRole {Name = "Admin"}).Wait();
                    }

                    if (userManager.FindByEmailAsync("admin@example.com").Result == null)
                    {
                        var user = new ApplicationUser
                        {
                            UserName = "admin@example.com",
                            Email = "admin@example.com",
                            FirstName = "Super",
                            LastName = "Admin"
                        };

                        IdentityResult result = userManager.CreateAsync(user, "P@ssw0rd").Result;

                        if (result.Succeeded)
                        {
                            userManager.AddToRoleAsync(user, "Admin").Wait();
                        }
                    }
                }
            }
        }
    }
}
            
            
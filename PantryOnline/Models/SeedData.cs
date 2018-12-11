using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace PantryOnline.Models
{
  public static class SeedData
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      using (var context = new PantryOnlineContext(
          serviceProvider.GetRequiredService<DbContextOptions<PantryOnlineContext>>()))
      {
        // Look for any movies.
        //if (context.Movies.Any())
        //{
        //  return;   // DB has been seeded
        //}

        //context.Movies.AddRange(
        //     new Movies
        //     {
        //       Name = "John McSporran",
        //       EmailAddress = "scottishjohn@scotmail.com"
        //     },

        //     new Movies
        //     {
        //       Name = "Peter Jones",
        //       EmailAddress = "123@peterjones.org"
        //     },

        //     new Movies
        //     {
        //       Name = "Mary Larry",
        //       EmailAddress = "maddog2020@yahoo.co.uk"
        //     },

        //   new Movies
        //   {
        //     Name = "George III",
        //     EmailAddress = "hrhgeorge@royal.org"
        //   }
        //);
        //context.SaveChanges();
      }
    }
  }
}
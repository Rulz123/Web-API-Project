using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obligatorisk_opgave_API_MVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                context.Game.AddRange(
                    new Games
                    {
                        internalName = "dota2",
                        title = "Dota 2",
                        metacriticlink = "/link",
                        dealID = "1",
                        storeID = "5",
                        gameID = "1000",
                        salePrice = "29.99",
                        normalPrice = "59.99",
                        isOnSale = "30",
                        savings = "50",
                        metacriticscore = "3",
                        steamRatingText = "Bad",
                        steamRatingPercent = "1%",
                        steamRatingCount = "10023",
                        steamAppID = "1013892",
                        releaseDate = 10399123,
                        lastChange = 12309932,
                        dealRating = "no",
                        thumb = "pls"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

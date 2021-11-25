using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using static System.Console;

namespace AirplanePartsStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Door",
                        Description = "Cesna passenger Dooor",
                        Category = "Structure",
                        Price = 375
                    },
                    new Product
                    {
                        Name = "Lifejacket",
                        Description = "Protective Life Jacket with radio",
                        Category = "Personal Safety Equipment",
                        Price = 48
                    },
                    new Product
                    {
                        Name = "Aircraft Tire",
                        Description = "USDOT approved",
                        Category = "Structure",
                        Price = 375
                    },
                    new Product
                    {
                        Name = "Brakes",
                        Description = "Aircraft Brakes, Titanium",
                        Category = "Structure",
                        Price = 150
                    },
                    new Product
                    {
                        Name = "Portable Aircraft Hangar",
                        Description = "Portable Aluminum Hangar for small Aircraft",
                        Category = "Support",
                        Price = 25000
                    },
                    new Product
                    {
                        Name = "T28 Engine",
                        Description = "T28 Engine approved by USDOT and FAA",
                        Category = "Engine",
                        Price = 5400
                    },
                    new Product
                    {
                        Name = "Pilot Seat",
                        Description = "Fitted for Cesna Aircraft custom",
                        Category = "Structure",
                        Price = 325
                    },
                    new Product
                    {
                        Name = "FAA Rules Book for IFR",
                        Description = "IFR Rules book to fly for Instruments only",
                        Category = "Support",
                        Price = 75
                    },
                    new Product
                    {
                        Name = "H251 Hydraulic pump",
                        Description = "Portable Hydraulic pump",
                        Category = "Support",
                        Price = 1200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}


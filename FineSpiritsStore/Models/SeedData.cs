using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace FineSpiritsStore.Models
{

    public static class SeedData
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
                        Name = "BomBay Sapphire London Dry Gin",
                        Category = "Gin",
                        Price = 22.99m
                        //Brand = "Bombay"

                    },
                    new Product
                    {
                        Name = "Aviation Gin",                 
                        Category = "Gin",
                        Price = 34.99m
                    },
                    new Product
                    {
                        Name = "Nikka Coffey Gin",
                        Category = "Gin",
                        Price = 54.99m

                    },
                    new Product
                    {
                        Name = "Crystal Head Vodka",
                        Category = "Vodka",
                        Price = 59.99m
                    },
                    new Product
                    {
                        Name = "Grey Goose Vodka",
                        Category = "Vodka",
                        Price = 19.99m
                    },
                    new Product
                    {
                        Name = "Tito's Handmade Vodka",
                        Category = "Vodka",
                        Price = 18.99m
                    },
                    new Product
                    {
                        Name = "Antigua Porteno 15 Yr Rum",
                        Category = "Rum",
                        Price = 49.99m
                    },
                    new Product
                    {
                        Name = "Kraken Black Spiced Rum",
                        Category = "Rum",
                        Price = 13.99m
                    },
                    new Product
                    {
                        Name = "Malibu Rum Coconut",
                        Category = "Rum",
                        Price = 13.99m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

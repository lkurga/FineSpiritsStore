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
                        Name = "Bombay Sapphire London Dry",
                        Category = "Gin",
                        Price = 21.99m,
                        Brand = "Bombay",
                        Country = "England",
                        Size = 750
                      
                        

                    },
                    new Product
                    {
                        Name = "Aviation",                 
                        Category = "Gin",
                        Price = 34.99m,
                        Brand = "Aviation",
                        Country="USA",
                        Size = 750

                    },
                    new Product
                    {
                        Name = "Nikka Coffey",
                        Category = "Gin",
                        Price = 54.99m,
                        Brand = "Nikka",
                        Country = "Japan",
                        Size = 750

                    },
                    new Product
                    {
                        Name = "Crystal Head",
                        Category = "Vodka",
                        Price = 59.99m,
                        Brand= "Canada",
                        Country = "Canada",
                        Size = 750
                    },
                    new Product
                    {
                        Name = "Grey Goose",
                        Category = "Vodka",
                        Price = 19.99m,
                        Brand = "Grey Goose",
                        Country = "France",
                        Size = 375
                    },
                    new Product
                    {
                        Name = "Tito's Handmade",
                        Category = "Vodka",
                        Price = 18.99m,
                        Brand = "Tito's",
                        Country ="USA" ,
                        Size = 750
                    },
                    new Product
                    {
                        Name = "Antigua Porteno 15 Yr",
                        Category = "Rum",
                        Price = 49.99m,
                        Brand = "Antigua",
                        Country="Columbia",
                        Size = 750
                    },
                    new Product
                    {
                        Name = "Kraken Black Spiced",
                        Category = "Rum",
                        Price = 13.99m,
                        Brand = "Kraken",
                        Country="USA",
                        Size = 375
                    },
                    new Product
                    {
                        Name = "Malibu Coconut",
                        Category = "Rum",
                        Price = 13.99m,
                        Brand = "Malibu",
                        Country="Carribean",
                        Size = 750
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using FineSpiritsStore.Models;
namespace UrlsAndRoutes.Areas.Admin.Controllers
{
    [Area("Test")]
    public class HomeController : Controller
    {
        private Product[] data = new Product[] {
 new Product {          Name = "Bombay Sapphire London Dry",
                        Category = "Gin",
                        Price = 21.99m,
                        Brand = "Bombay",
                        Country = "England",
                        Size = 750},

  new Product {          Name = "test",
                        Category = "Gin",
                        Price = 21.99m,
                        Brand = "Bombay",
                        Country = "England",
                        Size = 750}




 };
        public ViewResult Index() => View(data);
    }
}
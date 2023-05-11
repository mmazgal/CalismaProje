using CalismaProje.Models;
using Microsoft.AspNetCore.Mvc;
using CalismaProje.ViewModels;

namespace CalismaProje.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult index()
        {
            var product =new List<Product>()
            {
                new Product
                {
                    Name="Samsung X3",
                    Price=3700,
                    Description="Telefonlar",
                    IsApproved= true
                },
                new Product
                {
                    Name="Samsung X6",
                    Price=5800,
                    Description="Telefonlar"
                }
            };

            var categories = new List<Category>()
            {
                new Category {Name="Telefon", Description="Apple"},
                new Category {Name="Tablet", Description="Samsung"},
                new Category {Name="Bilgisayar", Description="Casper"}
            };

            var ProductViewModel = new ProductViewModel()
            {
                Products = product
            };

            return View(ProductViewModel);
        }
        public IActionResult about()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
    }
}
using CalismaProje.Models;
using Microsoft.AspNetCore.Mvc;
using CalismaProje.ViewModels;

namespace CalismaProje.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult index()
        {
            var product =new Product
            {
                Name="Samsung",
                Price=20000,
                Description="Telefon"
            };

            ViewData["Category"]="Telefon";
            ViewData["Product"]= product;

            ViewBag.Name="Samsung";
            ViewBag.Price=20000;
            ViewBag.Description="Telefon";

            return View();
        }
        public IActionResult list()
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
            var ProductViewModel = new ProductViewModel()
            {
                Products = product
            };

            return View(ProductViewModel);
        }
        public IActionResult details(int id)
        {
            var p=new Product();
            p.Name = "Macbook Pro M2";
            p.Price = 40000;
            p.Description = "Computer";
            return View(p);
        }
    }
}
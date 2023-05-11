
using Microsoft.AspNetCore.Mvc;
using CalismaProje.Models;

namespace CalismaProje.ViewComponents
{
    public class CategoriesViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<Category>()
            {
                new Category {Name="Telefon", Description="Apple"},
                new Category {Name="Tablet", Description="Samsung"},
                new Category {Name="Bilgisayar", Description="Casper"}
            };
            return View(categories);
        }
    }
}
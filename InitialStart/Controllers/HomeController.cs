using InitialStart.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCategories()
        {
            return View();
        }

        public IActionResult GetProducts()
        {
            Product television = new()
            {
                Id = 1,
                Title = "Samsung Oled Tv",
                StockLevel = 520,
                StockStatus = true,
            };

            return View(television);
        }
    }
}

using InitialStart.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class HtmlHelperController : Controller
    {
        public IActionResult Helper()
        {
            ViewBag.JustNumber = 55;

            Product product = new Product()
            {
                Id = 1,
                Title = "Test",
                StockLevel = 1,
                StockStatus = true
            };

            return View(product);
        }
    }
}

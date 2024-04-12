using Microsoft.AspNetCore.Mvc;

namespace NewProject.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var data = TempData["Test"];
            return View();
        }
    }
}

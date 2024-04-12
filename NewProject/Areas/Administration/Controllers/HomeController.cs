using Microsoft.AspNetCore.Mvc;

namespace NewProject.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["Test"] = "I am trying to send a data";
            //return RedirectToAction("Index","Home",new { area = "UserPanel"});
            return View();
        }
    }
}

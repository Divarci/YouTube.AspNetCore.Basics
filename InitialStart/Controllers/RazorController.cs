using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class RazorController : Controller
    {
        public IActionResult RazorLessons()
        {
            return View();
        }
    }
}

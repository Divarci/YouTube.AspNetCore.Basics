using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}

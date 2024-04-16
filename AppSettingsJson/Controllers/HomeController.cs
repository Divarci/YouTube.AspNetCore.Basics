using AppSettingsJson.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppSettingsJson.Controllers
{


    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            if (_webHostEnvironment.IsDevelopment())
            {
                ViewBag.result = "Development";
                ViewBag.result2 = _webHostEnvironment.EnvironmentName;
            }
            else if (_webHostEnvironment.IsStaging())
            {
                ViewBag.result = "Staging";
                ViewBag.result2 = _webHostEnvironment.EnvironmentName;
            }
            else if(_webHostEnvironment.IsProduction())
            {
                ViewBag.result = "Production";
                ViewBag.result2 = _webHostEnvironment.EnvironmentName;
            }
            else
            {
                ViewBag.result = "Customized";
                ViewBag.result2 = _webHostEnvironment.EnvironmentName;
            }
         
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

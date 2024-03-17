using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class AttributeController : Controller
    {
        public IActionResult Index()
        {
            CalculationController c = new CalculationController();
            var newResult = c.Calculation(12);
            var result = Calculation(5);
            return View(result+newResult);
        }

        [NonAction]
        public int Calculation(int number)
        {
            return number + 5;
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    [NonController]
    public class CalculationController : Controller
    {
        public int Calculation(int number)
        {
            return number + 5;
        }
    }
}

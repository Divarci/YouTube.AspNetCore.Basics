using Microsoft.AspNetCore.Mvc;

namespace NewProject.Controllers
{
    public class DIController : Controller
    {
        //private readonly MakeHoliday _holiday;

        //public DIController(MakeHoliday holiday)
        //{
        //    _holiday = holiday;
        //}

        //public IActionResult Index()
        //{
        //    _holiday.LetsGo();
        //    return View();
        //}


        public IActionResult Index([FromServices]MakeHoliday holiday)
        {
            holiday.LetsGo();
            return View();
        }


    }

    public class SelectBus : IVehicle
    {
        public void LetsGo()
        {
            Console.WriteLine("I am going by bus");
        }
    }

    public class SelectBicycle : IVehicle
    {
        public void LetsGo()
        {
            Console.WriteLine("I am going by bicycle");
        }
    }

    public interface IVehicle
    {
        void LetsGo();
    }


    public class MakeHoliday
    {
        private readonly IVehicle _vehicle;

        public MakeHoliday(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void LetsGo()
        {
            _vehicle.LetsGo();

        }

        //public void LetsGo()
        //{
        //    var vehicle = new SelectBicycle();
        //    vehicle.LetsGo();
        //}
    }

    // Inversion Of Control=> Dependancy Injection  to make DEPENDANCY INVERSION
}

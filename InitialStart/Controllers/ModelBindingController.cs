using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class ModelBindingController : Controller
    {
        #region UsingProtocols
        // [HttpGet] - [HttpPost]
        //[HttpGet]
        //public IActionResult CreateProduct()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult ReceiveData(string name)
        //{
        //    return View();
        //}

        #endregion

        #region ModelBinding
        //I can say confidently model binding helps us to MATCH the data comes from user and our parameters in server side
        [HttpGet]
        public IActionResult AddClient()
        {
            Person client = new()
            {
                Name = "hasan",
                Age = "36",
                Job = "Developer"
            };
            return View(client);
        }
        [HttpPost]
        public IActionResult AddClient(Person client)
        {
            return View();
        }


        #endregion


    }

    public class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Job { get; set; }
    }
}



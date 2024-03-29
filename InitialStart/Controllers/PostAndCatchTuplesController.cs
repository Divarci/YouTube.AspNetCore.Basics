using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class PostAndCatchTuplesController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {   
            var tuple = (new TestObjectOne(),new TestObjectTwo());
            return View(tuple);
        }

        [HttpPost]
        public IActionResult Create([Bind(Prefix ="Item1")]TestObjectOne objectOne, [Bind(Prefix = "Item2")] TestObjectTwo objectTwo)
        {
            return View();
        }
    }

    public class TestObjectOne
    {
        public string Name { get; set; }
    }

    public class TestObjectTwo
    {
        public string Address { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using NewProject.Filters;
using NewProject.Models;

namespace NewProject.Controllers
{
    //[ServiceFilter<ActionFilterAdd>]
    public class FilterTestController : Controller
    {
        private readonly IMemoryCache _memoryCache;

        public FilterTestController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        [ServiceFilter<ExceptionFilterAdd>]
        [ServiceFilter<ResultFilterAdd>]
        [ServiceFilter<ResourceFilterAdd>]
        [ServiceFilter<AuthorizationFilterAdd>]
        public IActionResult Index()
        {
            //throw new Exception("Opps error here");

            var bookListFromCache = _memoryCache.Get<List<string>>("Books");
            //bookListFromCache.Add("book4");
            //bookListFromCache.Add("book5");

            Console.WriteLine("--Action is running--");
            return View(bookListFromCache);
        }

        public IActionResult Random(int count)
        {
            return View();
        }

        public IActionResult Test(Product request)
        {
            return View();
        }
    }
}

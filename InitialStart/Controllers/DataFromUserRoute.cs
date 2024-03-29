using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class DataFromUserRoute : Controller
    {
        #region Explanation
        #endregion
        // completely similar with querystring, only difference user value comes from route settings and it keeps hidden property name. it makes routes little more secure system.

        //https://www.sitename.com/DataFromUserRoute/Index/5

        #region UsingByDefaultRoute
        #endregion
        //public IActionResult Index(string id)
        //{
        //    var values = HttpContext.Request.RouteValues;

        //    var controllerName = values.FirstOrDefault(x => x.Key.Contains("controller"));
        //    var actionName = values.FirstOrDefault(x => x.Key == "action");
        //    var idByRoute = values["id"];

        //    return View();
        //}

        #region UsingByCustomRoute
        #endregion
        //public IActionResult Index(string id, string itemOne, string itemTwo)
        //{
        //    var values = HttpContext.Request.RouteValues;

        //    var controllerName = values.FirstOrDefault(x => x.Key.Contains("controller"));
        //    var actionName = values.FirstOrDefault(x => x.Key == "action");
        //    var idByRoute = values["id"];

        //    var items = values.Where(x => x.Key.Contains("item")).Select(x => x.Value).ToList();

        //    return View();
        //}

        //public IActionResult Index(DataRoute route)
        //{
        //    return View();
        //}

        #region UsingTagHelpers
        #endregion
        //public IActionResult Index(string id, string itemOne, string itemTwo)
        //{

        //    return View();
        //}

        public IActionResult Index(string id, string itemOne, string itemTwo, string randomData)
        {

            return View();
        }

        public class DataRoute
        {
            public string Id { get; set; }
            public string ItemOne { get; set; }
            public string ItemTwo { get; set; }
        }
    }
}

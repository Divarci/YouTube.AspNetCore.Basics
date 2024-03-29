using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class DataFromUserQueryString : Controller
    {

        #region Explanation
        #endregion
        //if we have an information that doesnt needs to be secured, we can send this data using URL.
        //https://www.sitename.com/datafromuserquerystring/datareceive?itemOne=5&itemtwo=london

        #region CatchByParameters
        #endregion
        //public IActionResult DataReceive(string itemOne)
        //{
        //    return View();
        //}
        //public IActionResult DataReceive(string itemOne, string itemTwo)
        //{
        //    return View();
        //}
        //public IActionResult DataReceive(DataForQuerry data)
        //{
        //    return View();
        //}


        #region CatchByHttpContext
        #endregion

        public IActionResult DataReceive()
        {
            var resultOne = HttpContext.Request.QueryString;
            var resultTwo = HttpContext.Request.Query;

            var itemOne = resultTwo["itemOne"];
            var itemTwo = resultTwo["itemTwo"];

            return View();
        }
    }

    public class DataForQuerry
    {
        public string ItemOne { get; set; }
        public string ItemTwo { get; set; }
    }
}

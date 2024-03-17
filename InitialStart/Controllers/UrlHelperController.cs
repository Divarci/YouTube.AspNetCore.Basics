using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class UrlHelperController : Controller
    {
        public IActionResult UrlHelperTest()
        {
            #region Manuel

            var allPath = "https://localhost7589/Home/test/index/5";
            var path = "/Home/index/5";

            #endregion
            #region Url.Action
            var action1 = Url.Action("UrlHelperTest");
            //UrlHelper/urlHelpertest

            var action2 = Url.Action("UrlHelperTest", "UrlHelper");
            //UrlHelper/urlHelpertest

            var action3 = Url.Action("UrlHelperTest", "UrlHelper", new { id = 3 });
            //UrlHelper/urlHelpertest/3

            #endregion
            #region Url.ActionLink

            var action4 = Url.ActionLink("UrlHelperTest");

            var action5 = Url.ActionLink("UrlHelperTest", "UrlHelper");

            var action6 = Url.ActionLink("UrlHelperTest", "UrlHelper", new { id = 3 });

            #endregion
            #region Url.RouteUrl

            var action7 = Url.RouteUrl("Temporary");

            var action8 = Url.RouteUrl("Temporary", new { id = 15 }, "https", "localhost:45236");

            #endregion
            #region Url.ActionContext

            var actionContext = Url.ActionContext;

            #endregion



            return View();
        }


        public IActionResult TestAction()
        {
            return View();
        }
    }
}

using InitialStart.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class AuthenticationController : Controller
    {
        #region ViewResult
        //public ViewResult Login()
        //{
        //    return View();
        //}

        //_ViewStart.cshtml is in use
        #endregion
        #region PartialViewResult
        //public PartialViewResult Login()
        //{
        //    return PartialView();
        //}

        //_ViewStart.cshtml is not in use

        #endregion
        #region ViewComponentResult

        //modular component

        #endregion
        #region JsonResult
        //public JsonResult Login()
        //{
        //    Product television = new()
        //    {
        //        Id = 1,
        //        Title = "Samsung Oled Tv",
        //        StockLevel = 520,
        //        StockStatus = true,
        //    };

        //    return Json(television);
        //}
        #endregion
        #region EmptyResult
        //public EmptyResult Login()
        //{
        //    return new EmptyResult();
        //}

        //public void Login()
        //{

        //}
        #endregion
        #region ContentResult
        //public ContentResult Login()
        //{
        //    return Content("Do not forget like the video");
        //}
        #endregion
        #region ActionResult
        //public ActionResult Login(int x)
        //{
        //    if (x == 0)
        //    {
        //        return new EmptyResult();
        //    }
        //    else
        //    {
        //        return View();
        //    }

        //}
        #endregion
        #region IActionResult
        //public IActionResult Login()
        //{
        //    return View();
        //}
        #endregion
    }
}

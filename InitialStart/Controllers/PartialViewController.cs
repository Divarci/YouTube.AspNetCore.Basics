using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class PartialViewController : Controller
    {
        #region EXPLANATION
        #endregion

        //what is partial views and why we are using them? => to make modular
        //why do we need modular systems? => easy to use and easy maintenance
        //examples...

        #region HOW_TO_CREATE_PARTIAL_VIEW
        #endregion

        //tag helper
        //html helper => partial
        //html helper => renderPartial

        #region HOW_TO_DATA_TRANSFER
        #endregion

        //the logic of data send for partial views
        //main controller and view => all data transfer types
        //tag helper => model attribute

        public IActionResult ModularSystem()
        {
            List<string> list = new() { "a","b","c"};
            List<int> listTwo = new() { 1,2,3};
            ViewBag.listTwo = listTwo;
            return View(list);
        }
    }
}

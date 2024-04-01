using InitialStart.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class ValidationController : Controller
    {
        #region CONTENTS
        #endregion

        //what is the validation?
        //why should we use validation?
        //what are the type of validations?
        //how can we add our validation logic?
        //how can we catch the those error?
        //how can we show them to user?

        #region EXAMPLE
        #endregion

        [HttpGet]
        public ActionResult CreateCompany()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCompany(Company request)
        {
            //modelsate

            if(!ModelState.IsValid)
            {
                //log
                //return a meaningfull message to user
                //you can do everything you want here after validation
                return View(request);
            }

            //we can do our algoritms or add-update to our database
            return View();
        }
    }
}

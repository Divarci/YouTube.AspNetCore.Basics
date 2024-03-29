using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class DataFromUserHeaderController : Controller
    {
        #region Explanation
        #endregion
        //all requests have a header and body like an email. previous lessons we send and catch datas from body. Now we will see the HEADER.

        //we use headers to send JWT tokens for authentication but we now i will show you how can we catch them 

        #region Example
        #endregion
        
        public IActionResult Index()
        {
            var request = HttpContext.Request.Headers.ToList();

            var channelname = request.FirstOrDefault(x=>x.Key.Contains("Channel")).Value;

            return View();
        }
    }
}

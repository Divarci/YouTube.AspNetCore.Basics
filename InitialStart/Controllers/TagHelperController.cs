using Microsoft.AspNetCore.Mvc;

namespace InitialStart.Controllers
{
    public class TagHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region TagHelperExplanation
        //it is newest structure to help using html and c# codes
        //more readable
        //easy expandable
        //less cost for developer and server

        //we were using html helpers before. Lets remember how can we create a basic form
        #endregion
        #region TagHelperIntegration
        //@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
        //* means add all classes
        //after coma we define namespace
        #endregion
        #region HowToUseTagHelper
        //form
        //input
        #endregion
        #region CacheTagHelper
        //helps us to cache data
        #endregion
        #region EnvironmentTagHelper
        //helps us to define Envionment
        #endregion
        #region ImageTagHelper
        //asp-append-version
        #endregion
        #region PartialTagHelper
        //we use to create partial views
        #endregion
    }
}

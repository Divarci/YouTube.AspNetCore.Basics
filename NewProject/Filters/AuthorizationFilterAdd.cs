using Microsoft.AspNetCore.Mvc.Filters;

namespace NewProject.Filters
{
    public class AuthorizationFilterAdd : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            Console.WriteLine("I am coming from Authorization Filter");
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                
                if (context.HttpContext.User.IsInRole("Admin"))
                {
                    //do something
                }
            }

            //throw new UnauthorizedAccessException("You do not have permit tou access here");


        }
    }
}

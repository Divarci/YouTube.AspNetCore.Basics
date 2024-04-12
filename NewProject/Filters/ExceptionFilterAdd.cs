using Microsoft.AspNetCore.Mvc.Filters;

namespace NewProject.Filters
{
    public class ExceptionFilterAdd : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            Console.WriteLine("I am coming from Exception Filter");
        }
    }
}

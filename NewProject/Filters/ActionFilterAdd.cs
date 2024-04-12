using Microsoft.AspNetCore.Mvc.Filters;
using NewProject.Models;

namespace NewProject.Filters
{
    public class ActionFilterAdd : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("I am coming from Action Executed Filter");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("I am coming from Action Executing Filter");

            var value = context.ActionArguments.Values.FirstOrDefault();
            var parameterCount = context.ActionDescriptor.Parameters;

            if(value == null && parameterCount.Count!=0)
            {
                throw new Exception("id is not valid");
            }

            var idCheck = int.TryParse(value.ToString(), out _);
            if(idCheck)
            {
                return;
            }

            var product = value as Product;
            var idCheckforProduct= int.TryParse(product.Id.ToString(), out _);
            if (!idCheckforProduct)
            {
                throw new Exception("Product id is not valid");
            }

            if (product.Name!=null)
            {
                return ;
            }
            throw new Exception("Parameter error");


        }
    }
}

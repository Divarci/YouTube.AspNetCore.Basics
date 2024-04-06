
namespace Routing
{
    public class CustomConstraint : IRouteConstraint
    {
        public bool Match(
            HttpContext? httpContext, 
            IRouter? route, 
            string routeKey, 
            RouteValueDictionary values, 
            RouteDirection routeDirection)
        {
            var requiredValue = values[routeKey].ToString();
            var isInteger = int.TryParse(requiredValue, out int result);
            if (isInteger)
            {
                if(result <5 && result >2)
                {
                    return true;
                }

                return false;
            }          

            return false;
        }
    }
}

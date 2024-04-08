namespace Routing
{
    public class CustomRouteHandler
    {
        public RequestDelegate Handler()
        {
            //return async context =>
            //{
            //    await context.Response.WriteAsync("I am still coming from Custom Route Handler");
            //};
            return RandomMethod;
        }

        public async Task RandomMethod(HttpContext context)
        {
            await context.Response.WriteAsync("i am coming from again and again from custpm route handler");
        }

    }
}

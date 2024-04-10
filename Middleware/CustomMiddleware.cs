namespace Middleware
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate next;

        public CustomMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("first method");

            await next.Invoke(context);
            throw new Exception();
            Console.WriteLine("second method");
        }
    }
}

using Microsoft.AspNetCore.Http;

namespace MiddlewareSample
{
    public class AuthenticationMiddleware : MiddlewareDecorator
    {
        public AuthenticationMiddleware(IRequestHandler next) : base(next)
        {
        }

        public override async Task HandleAsync(HttpContext context)
        {
            if (!context.Request.Headers.ContainsKey("Authorization"))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Unathorizde");
                return;
            }
            await base.HandleAsync(context);
        }
    }

    public class LoggingMiddleware : MiddlewareDecorator
    {
        public LoggingMiddleware(IRequestHandler next) : base(next)
        {
        }
        public override async Task HandleAsync(HttpContext context)
        {
            Console.WriteLine($"Request: {context.Request.Path}");
            await base.HandleAsync(context);
            Console.WriteLine("Response sent.");
        }
    }

   

}

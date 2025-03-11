using Microsoft.AspNetCore.Http;

namespace MiddlewareSample
{
    public class ExceptionHandlingMiddleware : MiddlewareDecorator
    {
        public ExceptionHandlingMiddleware(IRequestHandler next) : base(next)
        {
        }
        public override async Task HandleAsync(HttpContext context)
        {
            try
            {
                await base.HandleAsync(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync($"Exception: {ex.Message}");

            }

        }
    }

}

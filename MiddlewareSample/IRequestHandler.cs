using Microsoft.AspNetCore.Http;
using System.Net.Http;

namespace MiddlewareSample
{
    /// <summary>
    /// Main Component
    /// </summary>
    public interface IRequestHandler
    {
        Task HandleAsync(HttpContext context);
    }



    /// <summary>
    /// Concrete component.
    /// </summary>

    public class BaseRequestHandler : IRequestHandler
    {

        public async Task HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsync("Request handled by the base handler \n");
        }
    }

}

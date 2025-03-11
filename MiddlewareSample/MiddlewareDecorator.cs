using Microsoft.AspNetCore.Http;
using System.Linq;

namespace MiddlewareSample
{
    /// <summary>
    /// Abstract Decorator.
    /// </summary>
    public abstract class MiddlewareDecorator : IRequestHandler
    {
        private readonly IRequestHandler _next;

        protected MiddlewareDecorator(IRequestHandler next)
        {
            _next = next;
        }

        public virtual async Task HandleAsync(HttpContext context)
        {
            if (_next != null)
            {
                await _next.HandleAsync(context);
            }
        }
    }

}

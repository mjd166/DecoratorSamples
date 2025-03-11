using Microsoft.AspNetCore.Http;

namespace MiddlewareSample.Adapter
{

    //Adapter DP
    // Adapter to integrate with .NET Middleware
    public class RequestHandlerAdapter
    {
        private readonly IRequestHandler _handler;

        public RequestHandlerAdapter(IRequestHandler handler)
        {
            _handler = handler;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            await _handler.HandleAsync(context);
        }
    }
}

using Microsoft.AspNetCore.Builder;
using MiddlewareSample.Adapter;

namespace MiddlewareSample
{
    public class Startup
    {
        public void Configure(IApplicationBuilder builder)
        {
            IRequestHandler handler = new BaseRequestHandler();

            handler = new AuthenticationMiddleware(handler);
            handler = new ExceptionHandlingMiddleware(handler);
            handler=new LoggingMiddleware(handler);

            builder.UseMiddleware<RequestHandlerAdapter>(handler);
        }
    }

   

}

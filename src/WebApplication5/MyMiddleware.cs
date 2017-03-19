using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication5
{
    public class MyMiddleware
    {
        private readonly RequestDelegate _next;
        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            string path = context.Request.Path.Value.ToLower();
            switch (path) {
                case "/test":
                    await context.Response.WriteAsync("Test Page");
                    break;

                case "/hello":
                    await context.Response.WriteAsync("Hello Page");
                    break;

                default:
                    await context.Response.WriteAsync("Default Page");
                    break;
            }            
        }
    }
}
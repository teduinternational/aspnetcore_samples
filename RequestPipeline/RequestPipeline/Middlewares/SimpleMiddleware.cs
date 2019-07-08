using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RequestPipeline.Middlewares
{
    public class SimpleMiddleware
    {
        private readonly RequestDelegate _next;
        public SimpleMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("<div> Hello from Simple Middleware </div>");
            await _next(context);
            await context.Response.WriteAsync("<div> Bye from Simple Middleware </div>");
        }
    }
}

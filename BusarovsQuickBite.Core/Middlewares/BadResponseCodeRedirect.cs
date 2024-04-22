using Microsoft.AspNetCore.Http;

namespace BusarovsQuickBite.Core.Middlewares
{
    public class BadResponseCodeRedirect
    {
        private readonly RequestDelegate _next;

        public BadResponseCodeRedirect(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next(context);
            if (context.Response.StatusCode == StatusCodes.Status400BadRequest)
            {
                context.Response.Redirect("/Home/BadRequestView");
            }
            else if (context.Response.StatusCode == StatusCodes.Status404NotFound)
            {
                context.Response.Redirect("/Home/NotFoundView");
            }
            else if (context.Response.StatusCode == StatusCodes.Status500InternalServerError)
            {
                context.Response.Redirect("/Home/InternalServerError");
            }
        }
    }
}

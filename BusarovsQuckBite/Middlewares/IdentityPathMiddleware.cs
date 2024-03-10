namespace BusarovsQuckBite.Middlewares
{
    public class IdentityPathMiddleware
    {
        private readonly RequestDelegate _next;

        public IdentityPathMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.StartsWithSegments("/Identity", StringComparison.OrdinalIgnoreCase))
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                return;
            }
            await _next(context);
            if (context.Response.StatusCode == StatusCodes.Status400BadRequest)
            {
                context.Response.Redirect("/Home/BadRequestView");
            }
            else if (context.Response.StatusCode == StatusCodes.Status404NotFound)
            {
                context.Response.Redirect("/Home/NotFoundView");
            }
        }
    }
}

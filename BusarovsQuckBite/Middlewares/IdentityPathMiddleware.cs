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
        }
    }
}

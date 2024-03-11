namespace BusarovsQuckBite.Middlewares
{
    public class ExceptionRedirect
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ExceptionRedirect(RequestDelegate next, ILogger<ExceptionRedirect> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                context.Response.Redirect("/Home/InvalidOperation");
            }
        }
    }
}

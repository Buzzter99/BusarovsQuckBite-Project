namespace BusarovsQuckBite.Middlewares
{
    public class ExceptionLogger
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ExceptionLogger(RequestDelegate next, ILogger<ExceptionLogger> logger)
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

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace BusarovsQuickBite.Core.Middlewares
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
                _logger.LogError(ex, $"Exception occured at path{context.Request.Path} at {DateTime.Now:dd/MM/yyyy HH:m:ss}");
                context.Response.Redirect("/Home/InvalidOperation");
            }
        }
    }
}

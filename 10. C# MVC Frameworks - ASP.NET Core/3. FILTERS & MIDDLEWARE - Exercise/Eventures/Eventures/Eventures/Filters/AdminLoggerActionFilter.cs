using Eventures.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System.Globalization;

namespace Eventures.Filters
{
    public class AdminLoggerActionFilter : IActionFilter
    {
        private readonly ILogger _logger;

        public AdminLoggerActionFilter(ILogger<AdminLoggerActionFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Controller is EventsController controller)
            {
                string message = controller.ViewData["Message"].ToString();

                _logger.LogInformation(message);
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
}

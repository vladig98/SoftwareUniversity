using Eventures.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

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
                if (controller.ViewData.ContainsKey("Message"))
                {
                    string message = controller.ViewData["Message"].ToString();

                    _logger.LogInformation(message);
                }
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
}

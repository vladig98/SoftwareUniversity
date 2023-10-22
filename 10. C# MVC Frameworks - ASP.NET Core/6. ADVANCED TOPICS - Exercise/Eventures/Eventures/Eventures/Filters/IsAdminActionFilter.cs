using Eventures.DbModels.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Eventures.Filters
{
    public class IsAdminActionFilter : Attribute, IActionFilter
    {
        private readonly ILogger _logger;

        public IsAdminActionFilter(ILogger<IsAdminActionFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.User.IsInRole(Role.Admin.ToString()))
            {
                _logger.LogError("User is not an Admin!");
                context.Result = new StatusCodeResult(StatusCodes.Status403Forbidden);
            }
        }
    }
}

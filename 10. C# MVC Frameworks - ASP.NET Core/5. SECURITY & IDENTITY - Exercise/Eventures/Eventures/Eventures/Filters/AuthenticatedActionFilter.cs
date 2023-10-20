using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Eventures.Filters
{
    public class AuthenticatedActionFilter : Attribute, IActionFilter
    {
        private readonly ILogger _logger;

        public AuthenticatedActionFilter(ILogger<AuthenticatedActionFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                _logger.LogError("User is not logged in!");
                context.Result = new UnauthorizedResult();
            }
        }
    }
}

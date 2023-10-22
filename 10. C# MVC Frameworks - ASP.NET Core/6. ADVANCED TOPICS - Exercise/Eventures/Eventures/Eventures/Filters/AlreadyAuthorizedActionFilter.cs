using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Eventures.Filters
{
    public class AlreadyAuthorizedActionFilter : Attribute, IActionFilter
    {
        private readonly ILogger _logger;

        public AlreadyAuthorizedActionFilter(ILogger<AlreadyAuthorizedActionFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                _logger.LogError("User is already authenticated!");
                context.Result = new UnprocessableEntityResult();
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Eventures.Filters
{
    public class ValidModelStateActionFilter : Attribute, IActionFilter
    {
        private readonly ILogger _logger;

        public ValidModelStateActionFilter(ILogger<ValidModelStateActionFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                _logger.LogError("Invalid data!");

                context.Result = new ViewResult
                {
                    ViewName = context.HttpContext.Request.Path.ToString().Split("/").Last(),
                    ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), context.ModelState)
                    {
                        Model = context.ActionArguments.First().Value
                    }
                };
            }
        }
    }
}

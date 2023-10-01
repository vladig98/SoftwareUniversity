using SIS.Framework.ActionResults;
using SIS.Framework.Attributes.Methods;
using SIS.Framework.Controllers;
using SIS.HTTP.Enums;
using SIS.HTTP.Requests;
using SIS.HTTP.Responses;
using SIS.WebServer.Api;
using SIS.WebServer.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SIS.Framework.Routers
{
    public class ControllerRouter : IHttpHandler
    {
        private Controller GetController(string controllerName, IHttpRequest request)
        {
            if (controllerName != null)
            {
                string controllerTypeName = string.Format("{0}.{1}.{2}, {3}", 
                    MvcContext.Get.AssemblyName, MvcContext.Get.ControllersFolder, controllerName, MvcContext.Get.FullAssemblyName);

                var controllerType = Type.GetType(controllerTypeName);
                var controller = (Controller)Activator.CreateInstance(controllerType);

                if (controller != null)
                {
                    controller.Request = request;
                }

                return controller;
            }

            return null;
        }

        private MethodInfo GetMethod(string requestMethod, Controller controller, string actionName)
        {
            MethodInfo method = null;

            foreach (var methodInfo in GetSuitableMethods(controller, actionName))
            {
                var attributes = methodInfo.GetCustomAttributes().Where(x => x is HttpMethodAttribute).Cast<HttpMethodAttribute>();

                if (!attributes.Any() && requestMethod.ToUpper() == "GET")
                {
                    return methodInfo;
                }

                foreach (var attribute in attributes)
                {
                    if (attribute.IsValid(requestMethod))
                    {
                        return methodInfo;
                    }
                }
            }

            return method;
        }

        private IEnumerable<MethodInfo> GetSuitableMethods(Controller controller, string actionName)
        {
            if (controller == null)
            {
                return new MethodInfo[0];
            }

            return controller.GetType().GetMethods().Where(x => x.Name.ToLower() == actionName.ToLower());
        }

        private IHttpResponse PrepareResponse(Controller controller, MethodInfo action)
        {
            IActionResult actionResult = (IActionResult)action.Invoke(controller, null);
            string invocationResult = actionResult.Invoke();

            if (actionResult is IViewable)
            {
                return new HtmlResult(invocationResult, HttpResponseStatusCode.Ok);
            }
            else if (actionResult is IRedirectable)
            {
                return new SIS.WebServer.Results.RedirectResult(invocationResult);
            }
            else
            {
                throw new InvalidOperationException("The view result is not supported.");
            }
        }

        public IHttpResponse Handle(IHttpRequest request)
        {
            var controllerName = string.Empty;
            var actionName = string.Empty;
            var requestMethod = request.RequestMethod.ToString();

            if (request.URL.Split("/", StringSplitOptions.RemoveEmptyEntries).Length == 1)
            {
                return new HtmlResult("", HttpResponseStatusCode.NotFound);
            }

            if (request.URL == "/")
            {
                controllerName = "Home";
                actionName = "Index";
            }
            else
            {
                var requestUrlSplit = request.URL.Split("/", StringSplitOptions.RemoveEmptyEntries);
                controllerName = requestUrlSplit[0];
                actionName = requestUrlSplit[1];
            }

            controllerName += "Controller";

            var controller = GetController(controllerName, request);

            if (controller == null)
            {
                return new HtmlResult("", HttpResponseStatusCode.NotFound);
            }

            var method = GetMethod(requestMethod, controller, actionName);

            if (method == null)
            {
                return new HtmlResult("", HttpResponseStatusCode.NotFound);
            }

            var response = PrepareResponse(controller, method);

            if (response == null)
            {
                return new HtmlResult("", HttpResponseStatusCode.NotFound);
            }

            return response;
        }
    }
}

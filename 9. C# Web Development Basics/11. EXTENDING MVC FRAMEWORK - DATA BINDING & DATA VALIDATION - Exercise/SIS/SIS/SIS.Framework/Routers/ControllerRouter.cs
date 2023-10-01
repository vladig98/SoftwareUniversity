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
using System.ComponentModel.DataAnnotations;
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

        private IHttpResponse PrepareResponse(IActionResult actionResult)
        {
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

            object[] actionParameters = MapActionParameters(method, request, controller);
            IActionResult actionResult = InvokeAction(controller, method, actionParameters);

            var response = PrepareResponse(actionResult);

            if (response == null)
            {
                return new HtmlResult("", HttpResponseStatusCode.NotFound);
            }

            return response;
        }

        private IActionResult InvokeAction(Controller controller, MethodInfo method, object[] actionParameters)
        {
            return (IActionResult)method.Invoke(controller, actionParameters);
        }

        private object[] MapActionParameters(MethodInfo method, IHttpRequest request, Controller controller)
        {
            ParameterInfo[] actionParametersInfo = method.GetParameters();
            object[] mappedActionParameters = new object[actionParametersInfo.Length];

            for (int i = 0; i < actionParametersInfo.Length; i++)
            {
                ParameterInfo parameterInfo = actionParametersInfo[i];

                if (parameterInfo.ParameterType.IsPrimitive || parameterInfo.ParameterType == typeof(string))
                {
                    mappedActionParameters[i] = ProcessPrimitiveParameter(parameterInfo, request);
                }
                else
                {
                    object bindingModel = ProcessBindingModelsParameter(parameterInfo, request);
                    controller.ModelState.IsValid = IsValidModel(bindingModel);
                    mappedActionParameters[i] = bindingModel;
                }
            }

            return mappedActionParameters;
        }

        private bool IsValidModel(object bindingModel)
        {
            foreach (var property in bindingModel.GetType().GetProperties())
            {
                var attributes = property.GetCustomAttributes().Where(x => x is ValidationAttribute).Cast<ValidationAttribute>().ToList();

                foreach (var attribute in attributes)
                {
                    var value = property.GetValue(bindingModel);

                    if (!attribute.IsValid(value))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private object ProcessBindingModelsParameter(ParameterInfo parameterInfo, IHttpRequest request)
        {
            Type bindingModelType = parameterInfo.ParameterType;

            var bindingModelInstance = Activator.CreateInstance(bindingModelType);
            var bindingModelProperties = bindingModelType.GetProperties();

            foreach (var property in bindingModelProperties)
            {
                try
                {
                    object value = GetParameterFromRequestData(request, property.Name);
                    property.SetValue(bindingModelInstance, Convert.ChangeType(value, property.PropertyType));
                }
                catch
                {
                    Console.WriteLine($"The {property.Name} field count not be mapped.");
                }
            }

            return Convert.ChangeType(bindingModelInstance, bindingModelType);
        }

        private object ProcessPrimitiveParameter(ParameterInfo parameterInfo, IHttpRequest request)
        {
            object value = GetParameterFromRequestData(request, parameterInfo.Name);
            return Convert.ChangeType(value, parameterInfo.ParameterType);
        }

        private object GetParameterFromRequestData(IHttpRequest request, string name)
        {
            if (request.QueryData.ContainsKey(name))
            {
                return request.QueryData[name];
            }

            if (request.FormData.ContainsKey(name))
            {
                return request.FormData[name];
            }

            return null;
        }
    }
}

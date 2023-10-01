using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SIS.Framework.Views
{
    public class ViewEngine
    {
        private const string ViewPathPreffix = @"..\..\..";
        private const string DisplayTemplateSuffix = @"DisplayTemplate";
        private const string LayoutViewName = @"_Layout";
        private const string ErrorViewName = @"_Error";
        private const string ViewExtension = @"html";
        private const string ModelCollectionViewParameterPattern = @"\@Model\.Collection\.(\w+)\((.+)\)";
        private string ViewsFolderPath => $@"{ViewPathPreffix}\{MvcContext.Get.ViewsFolder}\";
        private string ViewsSharedFolderPath => $@"{ViewsFolderPath}Shared\";
        private string ViewsDisplayTemplateFolderPath => $@"{ViewsSharedFolderPath}\DisplayTemplates\";

        private string FormatLayoutViewPath()
            => $@"{ViewsFolderPath}{LayoutViewName}.{ViewExtension}";

        private string FormatViewErrorPath()
            => $@"{ViewsFolderPath}{ErrorViewName}.{ViewExtension}";

        private string FormatViewPath(string controllerName, string actionName)
            => $@"{ViewsFolderPath}\{controllerName}\{actionName}.{ViewExtension}";

        private string FormatDisplayTemplatePath(string objectName)
            => $@"{ViewsDisplayTemplateFolderPath}{objectName}{DisplayTemplateSuffix}.{ViewExtension}";

        private string ReadLayoutHtml(string layoutViewPath)
        {
            if (!File.Exists(layoutViewPath))
            {
                throw new FileNotFoundException("Layout view does not exist.");
            }

            return File.ReadAllText(layoutViewPath);
        }

        private string ReadErrorHtml(string errorViewPath)
        {
            if (!File.Exists(errorViewPath))
            {
                throw new FileNotFoundException("Error view does not exist.");
            }

            return File.ReadAllText(errorViewPath);
        }

        private string ReadViewHtml(string viewPath)
        {
            if (!File.Exists(viewPath))
            {
                throw new FileNotFoundException($"View does not exist at {viewPath}");
            }

            return File.ReadAllText(viewPath);
        }

        private string RenderObject(object viewObject, string displayTemplate)
        {
            foreach (var property in viewObject.GetType().GetProperties())
            {
                displayTemplate = RenderViewData(displayTemplate, property.GetValue(viewObject), property.Name);
            }

            return displayTemplate;
        }

        private string RenderViewData(string template, object viewObject, string viewObjectName = null)
        {
            if (viewObject != null && viewObject.GetType() != typeof(string)
                && viewObject is IEnumerable enumerable && Regex.IsMatch(template, ModelCollectionViewParameterPattern))
            {
                Match collectionMatch = Regex.Matches(template, ModelCollectionViewParameterPattern)
                    .First(x => x.Groups[1].Value == viewObjectName);

                string fullMatch = collectionMatch.Groups[0].Value;
                string itemPattern = collectionMatch.Groups[2].Value;

                string result = string.Empty;

                foreach (var subObject in enumerable)
                {
                    result += itemPattern.Replace("@Item", RenderViewData(template, subObject));
                }

                return template.Replace(fullMatch, result);
            }

            if (viewObject != null && !viewObject.GetType().IsPrimitive && viewObject.GetType() != typeof(string))
            {
                if (File.Exists(FormatDisplayTemplatePath(viewObject.GetType().Name)))
                {
                    string renderObject = RenderObject(viewObject, File.ReadAllText(FormatDisplayTemplatePath(viewObject.GetType().Name)));

                    return viewObjectName != null ? template.Replace($"@Model.{viewObjectName}", renderObject) : renderObject;
                }
            }

            return viewObject != null ? template.Replace($"@Model.{viewObjectName}", viewObject?.ToString()) : viewObject?.ToString();
        }

        public string GetErrorContent()
            => ReadLayoutHtml(FormatLayoutViewPath()).Replace("@RenderError()", ReadErrorHtml(FormatViewErrorPath()));

        public string GetViewContent(string controllerName, string actionName)
            => ReadLayoutHtml(FormatLayoutViewPath()).Replace("@RenderBody()", ReadViewHtml(FormatViewPath(controllerName, actionName)));

        public string RenderHtml(string fullHtmlContent, IDictionary<string, object> viewData)
        {
            string renderedHtml = fullHtmlContent;

            if (viewData.Count > 0)
            {
                foreach (var parameter in viewData)
                {
                    renderedHtml = RenderViewData(renderedHtml, parameter.Value, parameter.Key);
                }
            }

            if (viewData.ContainsKey("Error"))
            {
                renderedHtml = renderedHtml.Replace("@Error", viewData["Error"].ToString());
            }

            return renderedHtml;
        }
    }
}

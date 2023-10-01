using SIS.Framework.ActionResults;

namespace SIS.Framework.Views
{
    public class View : IRenderable
    {
        private readonly string fullyQualifiedTemplateName;
        //private readonly IDictionary<string, object> viewData;

        public View(string fullyQualifiedTemplateName)//, IDictionary<string, object> viewData)
        {
            this.fullyQualifiedTemplateName = fullyQualifiedTemplateName;
            //this.viewData = viewData;
        }

        //private string ReadFile(string fullyQualifiedTemplateName)
        //{
        //    if (File.Exists(fullyQualifiedTemplateName))
        //    {
        //        return File.ReadAllText(fullyQualifiedTemplateName);
        //    }
        //    else
        //    {
        //        throw new FileNotFoundException(fullyQualifiedTemplateName);
        //    }
        //}

        public string Render() => fullyQualifiedTemplateName;
        //{
        //    string fullHtml = ReadFile(fullyQualifiedTemplateName);
        //    string renderedHtml = RenderHtml(fullHtml);

        //    return renderedHtml;
        //}

        //private string RenderHtml(string fullHtml)
        //{
        //    string renderedHtml = fullHtml;

        //    if (viewData.Any())
        //    {
        //        foreach (var item in viewData)
        //        {
        //            renderedHtml = renderedHtml.Replace($"{{{{{{{item.Key}}}}}}}", item.Value.ToString());
        //        }
        //    }

        //    return renderedHtml;
        //}
    }
}

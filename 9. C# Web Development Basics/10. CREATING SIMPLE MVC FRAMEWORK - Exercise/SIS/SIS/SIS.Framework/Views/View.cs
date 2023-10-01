using SIS.Framework.ActionResults;
using System.IO;

namespace SIS.Framework.Views
{
    public class View : IRenderable
    {
        private readonly string fullyQualifiedTemplateName;

        public View(string fullyQualifiedTemplateName)
        {
            this.fullyQualifiedTemplateName = fullyQualifiedTemplateName;
        }

        private string ReadFile(string fullyQualifiedTemplateName)
        {
            if (File.Exists(fullyQualifiedTemplateName))
            {
                return File.ReadAllText(fullyQualifiedTemplateName);
            }
            else
            {
                throw new FileNotFoundException(fullyQualifiedTemplateName);
            }
        }

        public string Render()
        {
            string fullHtml = ReadFile(fullyQualifiedTemplateName);

            return fullHtml;
        }
    }
}

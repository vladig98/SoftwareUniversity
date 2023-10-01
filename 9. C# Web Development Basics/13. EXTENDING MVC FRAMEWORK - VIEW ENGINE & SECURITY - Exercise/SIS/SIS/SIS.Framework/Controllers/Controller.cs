using SIS.Framework.ActionResults;
using SIS.Framework.Models;
using SIS.Framework.Security;
using SIS.Framework.Utilities;
using SIS.Framework.Views;
using SIS.HTTP.Requests;
using System.IO;
using System.Runtime.CompilerServices;

namespace SIS.Framework.Controllers
{
    public abstract class Controller
    {
        protected Controller()
        {
            Model = new ViewModel();
        }

        protected ViewModel Model { get; }
        public Model ModelState { get; } = new Model();
        public IIdentity Identity => (IIdentity)Request.Session.GetParameter("auth");
        private ViewEngine ViewEngine { get; } = new ViewEngine();

        public IHttpRequest Request { get; set; }

        protected IViewable View([CallerMemberName] string actionName = "")
        {
            string controllerName = ControllerUtilities.GetControllerName(this);
            //string fullyQualifiedName = ControllerUtilities.GetViewFullQualifiedName(controllerName, actionName);

            string viewContent = null;

            try
            {
                viewContent = ViewEngine.GetViewContent(controllerName, actionName);
            }
            catch (FileNotFoundException e)
            {
                Model.Data["Error"] = e.Message;
                viewContent = ViewEngine.GetErrorContent();
            }

            string renderedContent = ViewEngine.RenderHtml(viewContent, Model.Data);

            //IRenderable view = new View(fullyQualifiedName, Model.Data);

            return new ViewResult(new View(renderedContent));
        }

        protected void SignIn(IIdentity auth)
        {
            Request.Session.AddParameter("auth", auth);
        }

        protected void SignOut()
        {
            Request.Session.ClearParameters();
        }

        protected IRedirectable RedirectToAction(string redirectUrl)
            => new RedirectResult(redirectUrl);
    }
}

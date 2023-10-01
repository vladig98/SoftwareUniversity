using SIS.Framework.ActionResults;
using SIS.Framework.Utilities;
using SIS.Framework.Views;
using SIS.HTTP.Requests;
using System.Runtime.CompilerServices;

namespace SIS.Framework.Controllers
{
    public abstract class Controller
    {
        protected Controller() { }

        public IHttpRequest Request { get; set; }

        protected IViewable View([CallerMemberName] string caller = "")
        {
            string controllerName = ControllerUtilities.GetControllerName(this);
            string fullyQualifiedName = ControllerUtilities.GetViewFullQualifiedName(controllerName, caller);

            IRenderable view = new View(fullyQualifiedName);

            return new ViewResult(view);
        }

        protected IRedirectable RedirectToAction(string redirectUrl)
            => new RedirectResult(redirectUrl);
    }
}

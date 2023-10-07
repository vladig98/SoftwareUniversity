using SIS.Framework.ActionResults;
using SIS.Framework.Controllers;
using System.Runtime.CompilerServices;

namespace IRunes.Controllers
{
    public abstract class BaseController : Controller
    {
        protected override IViewable View([CallerMemberName] string actionName = "")
        {
            if (Identity != null)
            {
                Model.Data["NavUnauth"] = "none";
                Model.Data["NavAuth"] = "flex";
            }
            else
            {
                Model.Data["NavUnauth"] = "flex";
                Model.Data["NavAuth"] = "none";
            }

            return base.View(actionName);
        }
    }
}

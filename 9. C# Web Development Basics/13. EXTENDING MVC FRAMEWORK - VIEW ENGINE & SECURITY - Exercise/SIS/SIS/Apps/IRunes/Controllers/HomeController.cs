using SIS.Framework.ActionResults;
using SIS.Framework.Controllers;

namespace IRunes.Controllers
{
    public class HomeController : BaseController
    { 
        public IActionResult Index()
        {
            if (Identity != null)
            {
                Model["Auth"] = "block";
                Model["Username"] = Identity.Username;
                Model["Unauth"] = "none";
            }
            else
            {
                Model["Auth"] = "none";
                Model["Unauth"] = "block";
            }
            
            return View();
        }
    }
}

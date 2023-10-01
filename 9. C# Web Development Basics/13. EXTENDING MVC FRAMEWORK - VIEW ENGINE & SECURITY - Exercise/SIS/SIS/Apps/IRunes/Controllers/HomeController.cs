using IRunes.Services;
using SIS.Framework.ActionResults;
using SIS.Framework.Controllers;

namespace IRunes.Controllers
{
    public class HomeController : Controller
    {
        private const string PathToViews = "../../../Views/";
        private IEncryptionService encryptionService;

        public HomeController(IEncryptionService encryptionService)
        {
            this.encryptionService = encryptionService;
        }

        public IActionResult Index()
        {
            return View();
            //string content = string.Empty;

            //if (request.Cookies.ContainsCookie(".auth"))
            //{
            //    content = File.ReadAllText(PathToViews + "LoggedInIndex.html");

            //    var username = request.Cookies.GetCookie(".auth").Value;

            //    username = EncryptionService.Decode(username);

            //    content = content.Replace("{{name}}", username);
            //}
            //else
            //{
            //    content = File.ReadAllText(PathToViews + "Index.html");
            //}

            //return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }
    }
}

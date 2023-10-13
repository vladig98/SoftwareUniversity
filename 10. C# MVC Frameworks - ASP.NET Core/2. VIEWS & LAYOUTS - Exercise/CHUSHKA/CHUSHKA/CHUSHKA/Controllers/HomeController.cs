using CHUSHKA.Data;
using CHUSHKA.DbModels.Enums;
using CHUSHKA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CHUSHKA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CHUSHKADbContext _context;

        public HomeController(ILogger<HomeController> logger, CHUSHKADbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                LoggedInViewModel model = new LoggedInViewModel
                {
                    Username = User.Identity.Name,
                    Products = _context.Products.ToList()
                };

                if (User.IsInRole(Role.Admin.ToString()))
                {
                    return View("AdminIndex", model);
                }
                else
                {
                    return View("LoggedInIndex", model);
                }
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
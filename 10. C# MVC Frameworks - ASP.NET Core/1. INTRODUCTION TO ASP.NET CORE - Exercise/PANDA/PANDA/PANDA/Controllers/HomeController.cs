using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PANDA.Data;
using PANDA.DbModels;
using PANDA.DbModels.Enums;
using PANDA.Models;
using System.Diagnostics;

namespace PANDA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PandaDbContext _context;

        public HomeController(ILogger<HomeController> logger, PandaDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            PackagesViewModel model = new PackagesViewModel();

            if (User.Identity.IsAuthenticated)
            {
                if (_context.Packages.Any())
                {
                    var packages = await _context.Packages.Include(x => x.Recipient)
                        .Where(x => x.Recipient.UserName == User.Identity.Name).ToListAsync();

                    var pending = packages.Where(x => x.Status == Status.Pending).ToList();
                    var shipped = packages.Where(x => x.Status == Status.Shipped).ToList();
                    var delivered = packages.Where(x => x.Status == Status.Delivered).ToList();

                    model.PendingPackages = pending;
                    model.ShippedPackages = shipped;
                    model.DeliveredPackages = delivered;
                }
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
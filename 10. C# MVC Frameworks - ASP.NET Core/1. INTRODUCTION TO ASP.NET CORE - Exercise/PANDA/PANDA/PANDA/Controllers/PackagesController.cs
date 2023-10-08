using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PANDA.Data;
using PANDA.DbModels;
using PANDA.DbModels.Enums;
using PANDA.Models;

namespace PANDA.Controllers
{
    public class PackagesController : Controller
    {
        private readonly PandaDbContext _context;

        public PackagesController(PandaDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Acquire(string id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            var package = await _context.Packages.FirstOrDefaultAsync(x => x.Id == id);

            if (package == null)
            {
                return BadRequest();
            }

            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == User.Identity.Name);

            if (package.RecipientId != user.Id)
            {
                return Unauthorized();
            }

            package.Status = Status.Acquired;

            var receipt = new Receipt()
            {
                Id = Guid.NewGuid().ToString(),
                IssuedOn = DateTime.UtcNow,
                PackageId = package.Id,
                RecipientId = package.RecipientId,
                Fee = package.Weight * 2.67M
            };

            _context.Receipts.Add(receipt);

            await _context.SaveChangesAsync();

            return Redirect("/Home/Index");
        }

        public async Task<IActionResult> Deliver(string id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            if (!User.IsInRole(Role.Admin.ToString()))
            {
                return Unauthorized();
            }

            var package = await _context.Packages.FirstOrDefaultAsync(x => x.Id == id);

            if (package == null)
            {
                return BadRequest();
            }

            package.Status = Status.Delivered;

            await _context.SaveChangesAsync();

            return Redirect("/Packages/Delivered");
        }

        public async Task<IActionResult> Ship(string id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            if (!User.IsInRole(Role.Admin.ToString()))
            {
                return Unauthorized();
            }

            var package = await _context.Packages.FirstOrDefaultAsync(x => x.Id == id);

            if (package == null)
            {
                return BadRequest();
            }

            package.Status = Status.Shipped;

            Random rnd = new Random();
            int days = rnd.Next(20, 41);

            package.EstimatedDeliveryDate = DateTime.UtcNow.AddDays(days);

            await _context.SaveChangesAsync();

            return Redirect("/Packages/Shipped");
        }

        public async Task<IActionResult> Pending()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            if (!User.IsInRole(Role.Admin.ToString()))
            {
                return Unauthorized();
            }

            var pending = await _context.Packages.Include(x => x.Recipient).Where(x => x.Status == Status.Pending).ToListAsync();

            return View(pending);
        }

        public async Task<IActionResult> Shipped()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            if (!User.IsInRole(Role.Admin.ToString()))
            {
                return Unauthorized();
            }

            var pending = await _context.Packages.Include(x => x.Recipient).Where(x => x.Status == Status.Shipped).ToListAsync();

            return View(pending);
        }

        public async Task<IActionResult> Delivered()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            if (!User.IsInRole(Role.Admin.ToString()))
            {
                return Unauthorized();
            }

            var pending = await _context.Packages.Include(x => x.Recipient)
                .Where(x => x.Status == Status.Delivered || x.Status == Status.Acquired).ToListAsync();

            return View(pending);
        }

        public async Task<IActionResult> Details(string id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            var package = await _context.Packages.Include(x => x.Recipient).FirstOrDefaultAsync(x => x.Id == id);

            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == User.Identity.Name);

            if (package.RecipientId != user.Id)
            {
                if (!User.IsInRole(Role.Admin.ToString()))
                {
                    return Unauthorized();
                }
            }

            if (package == null)
            {
                return BadRequest();
            }

            return View(package);
        }

        public async Task<IActionResult> Create()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            if (!User.IsInRole(Role.Admin.ToString()))
            {
                return Unauthorized();
            }

            var users = await _context.Users.ToListAsync();

            return View(users);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PackageViewModel model)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            if (!User.IsInRole(Role.Admin.ToString()))
            {
                return Unauthorized();
            }

            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == model.Recipient);

            if (user == null)
            {
                return BadRequest();
            }

            var validWeight = decimal.TryParse(model.Weight, out decimal weight);

            if (!validWeight)
            {
                return BadRequest();
            }

            _context.Packages.Add(new Package
            {
                Id = Guid.NewGuid().ToString(),
                Description = model.Description,
                RecipientId = user.Id,
                ShippingAddress = model.ShippingAddress,
                Weight = weight,
                Status = Status.Pending,
                EstimatedDeliveryDate = null
            });

            await _context.SaveChangesAsync();

            return Redirect("/Home/Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PANDA.Data;

namespace PANDA.Controllers
{
    public class ReceiptsController : Controller
    {
        private readonly PandaDbContext _context;

        public ReceiptsController(PandaDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Details(string id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            var receipt = await _context.Receipts.Include(x => x.Package).Include(x => x.Recipient).FirstOrDefaultAsync(x => x.Id == id);

            if (receipt == null)
            {
                return BadRequest();
            }

            var user = await _context.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefaultAsync();

            if (receipt.RecipientId != user.Id)
            {
                return Unauthorized();
            }

            return View(receipt);
        }

        public async Task<IActionResult> Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            var receipts = await _context.Receipts.Include(x => x.Recipient)
                .Where(x => x.Recipient.UserName == User.Identity.Name).ToListAsync();

            return View(receipts);
        }
    }
}

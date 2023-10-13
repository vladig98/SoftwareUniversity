using CHUSHKA.Data;
using CHUSHKA.DbModels.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CHUSHKA.Controllers
{
    public class OrdersController : Controller
    {
        private readonly CHUSHKADbContext _context;

        public OrdersController(CHUSHKADbContext context)
        {
            _context = context;
        }

        public IActionResult All()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            if (!User.IsInRole(Role.Admin.ToString()))
            {
                return Forbid();
            }

            var orderds = _context.Orders.Include(x => x.Client).Include(x => x.Product).ToList();

            return View(orderds);
        }
    }
}

using CHUSHKA.Data;
using CHUSHKA.DbModels;
using CHUSHKA.DbModels.Enums;
using CHUSHKA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CHUSHKA.Controllers
{
    public class ProductsController : Controller
    {
        private readonly CHUSHKADbContext _context;

        public ProductsController(CHUSHKADbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id, EditProductViewModel model)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            if (!User.IsInRole(Role.Admin.ToString()))
            {
                return Forbid();
            }

            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return BadRequest();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return Redirect("/Home/Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            if (!User.IsInRole(Role.Admin.ToString()))
            {
                return Forbid();
            }

            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return BadRequest();
            }

            EditProductViewModel model = new EditProductViewModel
            {
                Description = product.Description,
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Type = product.Type
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditProductViewModel model, string id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            if (!User.IsInRole(Role.Admin.ToString()))
            {
                return Forbid();
            }

            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return BadRequest();
            }

            product.Description = model.Description;
            product.Price = model.Price;
            product.Name = model.Name;
            product.Type = model.Type;

            await _context.SaveChangesAsync();

            return Redirect("/Home/Index");
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            if (!User.IsInRole(Role.Admin.ToString()))
            {
                return Forbid();
            }

            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return BadRequest();
            }

            EditProductViewModel model = new EditProductViewModel
            {
                Description = product.Description,
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Type = product.Type
            };

            return View(model);
        }

        public async Task<IActionResult> Details(string id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var produt = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

            if (produt == null)
            {
                return Redirect("/Home/Error");
            }

            return View(produt);
        }

        public IActionResult Create()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            if (!User.IsInRole(Role.Admin.ToString()))
            {
                return Forbid();
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            if (!User.IsInRole(Role.Admin.ToString()))
            {
                return Forbid();
            }

            Product product = new Product
            {
                Description = model.Description,
                Id = Guid.NewGuid().ToString(),
                Name = model.Name,
                Price = model.Price,
                Type = model.Type,
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return Redirect("/Home/Index");
        }

        public async Task<IActionResult> Order(string id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return BadRequest();
            }

            var user = await _context.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefaultAsync();

            var order = new Order
            {
                ClientId = user.Id,
                Id = Guid.NewGuid().ToString(),
                ProductId = product.Id,
                OrderedOn = DateTime.UtcNow
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return Redirect("/Home/Index");
        }
    }
}

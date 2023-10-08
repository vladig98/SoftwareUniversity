using FDMC.Data;
using FDMC.Model;
using FDMC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FDMC.Controllers
{
    public class CatsController : Controller
    {
        private readonly FDMCDbContext _context;

        public CatsController(FDMCDbContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {
            return View();
        }

        public async Task<IActionResult> Details(int id)
        {
            var model = await _context.Cats.FirstOrDefaultAsync(x => x.Id == id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CatViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Cats.Add(new Cat
            {
                Age = model.Age,
                Breed = model.Breed,
                ImageURL = model.ImageURL,
                Name = model.Name
            });

            await _context.SaveChangesAsync();

            return Redirect("/Home/Index");
        }
    }
}

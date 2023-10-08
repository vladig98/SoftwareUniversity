using FDMC.Data;
using FDMC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FDMC.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly FDMCDbContext _context;

        public IndexModel(ILogger<IndexModel> logger, FDMCDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IList<Cat>? Cats { get; set; }

        public async Task OnGetAsync()
        {
            Cats = await _context.Cats.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var contact = await _context.Cats.FindAsync(id);

            if (contact != null)
            {
                _context.Cats.Remove(contact);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
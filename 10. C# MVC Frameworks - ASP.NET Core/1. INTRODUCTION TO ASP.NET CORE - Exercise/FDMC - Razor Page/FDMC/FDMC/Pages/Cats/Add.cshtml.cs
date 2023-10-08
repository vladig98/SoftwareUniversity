using FDMC.Data;
using FDMC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDMC.Pages.Cats
{
    public class AddModel : PageModel
    {
        private readonly FDMCDbContext _context;

        public AddModel(FDMCDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cat? Cat { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Cat != null) _context.Cats.Add(Cat);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}

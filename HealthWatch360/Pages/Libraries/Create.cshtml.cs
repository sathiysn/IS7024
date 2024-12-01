using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HealthWatch360.Data;
using HealthWatch360.Models;

namespace HealthWatch360.Pages.Libraries
{
    public class CreateModel : PageModel
    {
        private readonly HealthWatch360.Data.HealthWatch360Context _context;

        public CreateModel(HealthWatch360.Data.HealthWatch360Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Library Library { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Library.Add(Library);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

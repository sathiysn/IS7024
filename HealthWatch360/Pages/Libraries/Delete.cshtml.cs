using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HealthWatch360.Data;
using HealthWatch360.Models;

namespace HealthWatch360.Pages.Libraries
{
    public class DeleteModel : PageModel
    {
        private readonly HealthWatch360.Data.HealthWatch360Context _context;

        public DeleteModel(HealthWatch360.Data.HealthWatch360Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Library Library { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var library = await _context.Library.FirstOrDefaultAsync(m => m.LibraryID == id);

            if (library == null)
            {
                return NotFound();
            }
            else
            {
                Library = library;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var library = await _context.Library.FindAsync(id);
            if (library != null)
            {
                Library = library;
                _context.Library.Remove(Library);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

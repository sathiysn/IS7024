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
    public class DetailsModel : PageModel
    {
        private readonly HealthWatch360.Data.HealthWatch360Context _context;

        public DetailsModel(HealthWatch360.Data.HealthWatch360Context context)
        {
            _context = context;
        }

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
    }
}
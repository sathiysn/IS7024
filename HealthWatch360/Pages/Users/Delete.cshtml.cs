using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HealthWatch360.Data;
using HealthWatch360.Models;

namespace HealthWatch360.Pages.Users
{
    public class DeleteModel : PageModel
    {
        private readonly HealthWatch360.Data.HealthWatch360Context _context;

        public DeleteModel(HealthWatch360.Data.HealthWatch360Context context)
        {
            _context = context;
        }

        [BindProperty]
        public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FirstOrDefaultAsync(m => m.UserID == id);

            if (user == null)
            {
                return NotFound();
            }
            else
            {
                User = user;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user != null)
            {
                User = user;
                _context.User.Remove(User);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

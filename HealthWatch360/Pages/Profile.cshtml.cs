using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HealthWatch360.Data;
using HealthWatch360.Models;

namespace HealthWatch360.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly HealthWatch360.Data.HealthWatch360Context _context;

        public ProfileModel(HealthWatch360.Data.HealthWatch360Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (User.HeightFeet < 0 || User.HeightFeet > 8) // Example range
            {
                ModelState.AddModelError("User.HeightFeet", "Feet must be between 0 and 8.");
            }

            if (User.HeightInches < 0 || User.HeightInches >= 12) // 0-11 inches
            {
                ModelState.AddModelError("User.HeightInches", "Inches must be between 0 and 11.");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

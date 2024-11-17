using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HealthWatch360.Data;
using HealthWatch360.Models;

namespace HealthWatch360.Pages.HealthReports
{
    public class EditModel : PageModel
    {
        private readonly HealthWatch360.Data.HealthWatch360Context _context;

        public EditModel(HealthWatch360.Data.HealthWatch360Context context)
        {
            _context = context;
        }

        [BindProperty]
        public HealthReport HealthReport { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthreport =  await _context.HealthReport.FirstOrDefaultAsync(m => m.HealthReportId == id);
            if (healthreport == null)
            {
                return NotFound();
            }
            HealthReport = healthreport;
           ViewData["UserID"] = new SelectList(_context.User, "UserID", "Email");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HealthReport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HealthReportExists(HealthReport.HealthReportId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HealthReportExists(int id)
        {
            return _context.HealthReport.Any(e => e.HealthReportId == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HealthWatch360.Data;
using HealthWatch360.Models;

namespace HealthWatch360.Pages.HealthReports
{
    public class DeleteModel : PageModel
    {
        private readonly HealthWatch360.Data.HealthWatch360Context _context;

        public DeleteModel(HealthWatch360.Data.HealthWatch360Context context)
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

            var healthreport = await _context.HealthReport.FirstOrDefaultAsync(m => m.HealthReportID == id);

            if (healthreport == null)
            {
                return NotFound();
            }
            else
            {
                HealthReport = healthreport;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthreport = await _context.HealthReport.FindAsync(id);
            if (healthreport != null)
            {
                HealthReport = healthreport;
                _context.HealthReport.Remove(HealthReport);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

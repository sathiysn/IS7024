using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HealthWatch360.Data;
using HealthWatch360.Models;

namespace HealthWatch360.Pages.Reports
{
    public class IndexModel : PageModel
    {
        private readonly HealthWatch360.Data.HealthWatch360Context _context;

        public IndexModel(HealthWatch360.Data.HealthWatch360Context context)
        {
            _context = context;
        }

        public IList<HealthReport> HealthReport { get;set; } = default!;

        public async Task OnGetAsync()
        {
            HealthReport = await _context.HealthReport.ToListAsync();
        }
    }
}

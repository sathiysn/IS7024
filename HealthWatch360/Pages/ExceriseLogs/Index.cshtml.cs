using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HealthWatch360.Data;
using HealthWatch360.Models;

namespace HealthWatch360.Pages.ExceriseLogs
{
    public class IndexModel : PageModel
    {
        private readonly HealthWatch360.Data.HealthWatch360Context _context;

        public IndexModel(HealthWatch360.Data.HealthWatch360Context context)
        {
            _context = context;
        }

        public IList<ExerciseLog> ExerciseLog { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ExerciseLog = await _context.ExerciseLog
                .Include(e => e.User).ToListAsync();
        }
    }
}

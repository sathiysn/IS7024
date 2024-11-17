using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HealthWatch360.Data;
using HealthWatch360.Models;

namespace HealthWatch360.Pages.ExerciseLogs
{
    public class DetailsModel : PageModel
    {
        private readonly HealthWatch360.Data.HealthWatch360Context _context;

        public DetailsModel(HealthWatch360.Data.HealthWatch360Context context)
        {
            _context = context;
        }

        public ExerciseLog ExerciseLog { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exerciselog = await _context.ExerciseLog.FirstOrDefaultAsync(m => m.ExerciseLogId == id);
            if (exerciselog == null)
            {
                return NotFound();
            }
            else
            {
                ExerciseLog = exerciselog;
            }
            return Page();
        }
    }
}

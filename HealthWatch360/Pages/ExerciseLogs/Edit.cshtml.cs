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

namespace HealthWatch360.Pages.ExerciseLogs
{
    public class EditModel : PageModel
    {
        private readonly HealthWatch360.Data.HealthWatch360Context _context;

        public EditModel(HealthWatch360.Data.HealthWatch360Context context)
        {
            _context = context;
        }

        [BindProperty]
        public ExerciseLog ExerciseLog { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exerciselog =  await _context.ExerciseLog.FirstOrDefaultAsync(m => m.ExerciseLogID == id);
            if (exerciselog == null)
            {
                return NotFound();
            }
            ExerciseLog = exerciselog;
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

            _context.Attach(ExerciseLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExerciseLogExists(ExerciseLog.ExerciseLogID))
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

        private bool ExerciseLogExists(int id)
        {
            return _context.ExerciseLog.Any(e => e.ExerciseLogID == id);
        }
    }
}

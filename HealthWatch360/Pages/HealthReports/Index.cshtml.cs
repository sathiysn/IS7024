using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HealthWatch360.Pages.HealthReports
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            HealthReport = await _context.HealthReport
                .Include(h => h.User).ToListAsync();
        }
    }
}

using HealthWatch360.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using static HealthWatch360.Models.NutritionLog;

namespace HealthWatch360.Pages
{
    public class ReportsModel : PageModel
    {
        public NutritionLog.Root Root { get; set; }  // This holds the Root object
        public List<NutritionLog.FoundationFood> FoundationFoods { get; set; }  // List of FoundationFood


        public void OnGet()
        {
            var jsonData = System.IO.File.ReadAllText("NutritionInfo.json");
            Root = JsonConvert.DeserializeObject<NutritionLog.Root>(jsonData);

            // Ensure that FoundationFoods is populated from Root
            FoundationFoods = Root.FoundationFoods ?? new List<NutritionLog.FoundationFood>();

        }
    }
}

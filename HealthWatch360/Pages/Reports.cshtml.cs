using HealthWatch360.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using static HealthWatch360.Models.NutritionLog;

namespace HealthWatch360.Pages
{
    public class ReportsModel : PageModel
    {
        public NutritionLog.Root FoundationFoods { get; set; }
        public Root? Root { get; private set; }

        public void OnGet()
        {
            var jsonData = System.IO.File.ReadAllText("NutritionInfo.json");
            Root = JsonConvert.DeserializeObject<NutritionLog.Root>(jsonData);
        }
    }
}

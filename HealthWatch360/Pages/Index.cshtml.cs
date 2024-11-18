using HealthWatch360.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.DotNet.MSIdentity.Shared;
using Newtonsoft.Json;
using static HealthWatch360.Models.NutritionLog;

namespace HealthWatch360.Pages
{
    public class IndexModel : PageModel
    {
        public NutritionLog.Root FoundationFoods { get; set; }
        public Root? Root { get; private set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var jsonData = System.IO.File.ReadAllText("NutritionInfo.json");
            Root = JsonConvert.DeserializeObject<Root>(jsonData);
        }
    }
}

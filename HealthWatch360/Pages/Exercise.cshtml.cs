using HealthWatch360.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace HealthWatch360.Pages
{
    public class ExerciseModel : PageModel
    {
        public List<string> FacilityTypes { get; set; } = new List<string>();
        public List<ExerciseLog.Item> FilteredFacilities { get; set; } = new List<ExerciseLog.Item>();
        public string SelectedFacilityType { get; set; }

        public void OnGet()
        {
            var jsonData = System.IO.File.ReadAllText("Facilities.json");
            var facilities = JsonConvert.DeserializeObject<ExerciseLog.Root>(jsonData);

            // Extract unique facility types
            if (facilities?.items != null)
            {
                FacilityTypes = facilities.items
                    .Select(item => item.facility_type)
                    .Distinct()
                    .ToList();
            }
        }
        public void OnPost(string facilityType)
        {
            SelectedFacilityType = facilityType;

            // Load JSON data
            var jsonData = System.IO.File.ReadAllText("Facilities.json");
            var facilities = JsonConvert.DeserializeObject<ExerciseLog.Root>(jsonData);

            // Filter facilities by the selected facility type
            if (facilities?.items != null)
            {
                FilteredFacilities = facilities.items
                    .Where(item => item.facility_type == facilityType)
                    .ToList();
            }

            // Reload the facility types for the dropdown
            FacilityTypes = facilities.items
                .Select(item => item.facility_type)
                .Distinct()
                .ToList();
        }
    }
}

using HealthWatch360.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace HealthWatch360.Pages
{
    public class ExerciseModel : PageModel
    {
        public List<string> FacilityTypes { get; set; } = new List<string>();
        public List<FacilityWithProgram> FilteredFacilities { get; set; } = new List<FacilityWithProgram>();
        public string SelectedFacilityType { get; set; }

        public void OnGet()
        {
            LoadFacilityTypes();
        }

        public void OnPost(string facilityType)
        {
            SelectedFacilityType = facilityType;
            LoadFacilitiesWithPrograms(facilityType);
            LoadFacilityTypes();
        }

        private void LoadFacilityTypes()
        {
            var jsonData = System.IO.File.ReadAllText("Facilities.json");
            var facilities = JsonConvert.DeserializeObject<ExerciseLog.Root>(jsonData);
            if (facilities?.items != null)
            {
                FacilityTypes = facilities.items
                    .Select(item => item.facility_type)
                    .Distinct()
                    .ToList();
            }
        }

        private void LoadFacilitiesWithPrograms(string facilityType)
        {
            var facilitiesJson = System.IO.File.ReadAllText("Facilities.json");
            var programsJson = System.IO.File.ReadAllText("Programs.json");

            var facilities = JsonConvert.DeserializeObject<ExerciseLog.Root>(facilitiesJson);
            var programs = JsonConvert.DeserializeObject<HealthWatch360.Models.Program.Root>(programsJson);

            if (facilities?.items != null && programs?.items != null)
            {
                FilteredFacilities = facilities.items
                    .Where(item => item.facility_type == facilityType)
                    .Select(facility =>
                    {
                        var program = programs.items.FirstOrDefault(p => p.zip_code == facility.zip_code);
                        return new FacilityWithProgram
                        {
                            Facility = facility,
                            Program = program
                        };
                    })
                    .ToList();
            }
        }

        public class FacilityWithProgram
        {
            public ExerciseLog.Item Facility { get; set; }
            public Models.Program.Item? Program { get; internal set; }
        }
    }

}

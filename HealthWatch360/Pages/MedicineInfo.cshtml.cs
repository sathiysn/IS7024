using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace HealthWatch360.Pages
{
    public class MedicineInfoModel : PageModel
    {
        private readonly HttpClient _httpClient;

        public MedicineInfoModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public DrugEventData? DrugData { get; set; }

        public async Task OnGetAsync()
        {
            var apiUrl = "https://api.fda.gov/drug/event.json?limit=1";
            try
            {
                DrugData = await _httpClient.GetFromJsonAsync<DrugEventData>(apiUrl);
            }
            catch (HttpRequestException ex)
            {
                
                Console.WriteLine("Error fetching data from API: " + ex.Message);
            }
        }

        public class DrugEventData
        {
            public Meta? meta { get; set; }
            public Results[]? results { get; set; }
        }

        public class Meta
        {
            public string? disclaimer { get; set; }
            public string? terms { get; set; }
            public string? license { get; set; }
            public string? last_updated { get; set; }
        }

        public class Results
        {
            public string? safetyreportid { get; set; }
            public string? receivedate { get; set; }
            public string? patientonsetage { get; set; }
            public string? patientonsetageunit { get; set; }
            public string? patientsex { get; set; }
           
        }
    }
}

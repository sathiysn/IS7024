using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using HealthWatch360.Models;
using Newtonsoft.Json;

namespace HealthWatch360.Services
{
    public class FdaApiService
    {
        private readonly HttpClient _httpClient;

       public FdaApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<MedicalInfo>?> GetProductTypeCountsAsync()
        {
            var apiUrl = "https://api.fda.gov/drug/label.json?count=openfda.product_type.exact";
            try
            {
                // Fetch and deserialize data into a list of MedicalInfo objects
            
              
                //Before deserialising, fetch the response content
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                string jsonResponse = await response.Content.ReadAsStringAsync();


                //var response = await _httpClient.GetFromJsonAsync<List<MedicalInfo>>(apiUrl);  This line does not convert the json into List<MedicalInfo>.

                var parsedJson =  JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);
                var medicalInfoList = parsedJson.Results;
                return medicalInfoList; // Replace this with deserizlised response
            }
            catch (HttpRequestException ex)
            {
                // Handle exceptions, log error messages, etc.
                Console.WriteLine($"Error fetching data: {ex.Message}");
                //return null;
                return new List<MedicalInfo>();
            }
        }
    }
    public class ApiResponse
    {
        public Meta Meta { get; set; }
        public List<MedicalInfo> Results { get; set; }
    }
    public class Meta
    {
        public string Disclaimer { get; set; }
        public string Terms { get; set; }
        public string License { get; set; }
        public string LastUpdated { get; set; }
    }

}

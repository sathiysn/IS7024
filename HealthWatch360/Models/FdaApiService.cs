using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using HealthWatch360.Models;

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
                var response = await _httpClient.GetFromJsonAsync<List<MedicalInfo>>(apiUrl);
                return response;
            }
            catch (HttpRequestException ex)
            {
                // Handle exceptions, log error messages, etc.
                Console.WriteLine($"Error fetching data: {ex.Message}");
                return null;
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HealthWatch360.Models;
using HealthWatch360.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthWatch360.Pages
{
    public class MedicalInfoModel : PageModel
    {
        private readonly FdaApiService _fdaApiService;

        // You are using dependency injection model here. Re-consider the use case of this here. If using this model, 
        public MedicalInfoModel(FdaApiService fdaApiService)
        {
            _fdaApiService = fdaApiService;
        }

        public List<MedicalInfo>? ProductTypeCounts { get; set; }

        public async Task OnGetAsync()
        {
            ProductTypeCounts = await _fdaApiService.GetProductTypeCountsAsync();
        }
    }
}

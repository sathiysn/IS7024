using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HealthWatch360.Models;
using HealthWatch360.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthWatch360.Pages
{
    public class MedicineInfoModel : PageModel
    {
        private readonly FdaApiService _fdaApiService;

        public MedicineInfoModel(FdaApiService fdaApiService)
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

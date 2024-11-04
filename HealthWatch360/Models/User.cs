using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HealthWatch360.Models
{
	public class User
	{
		public string UserID { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Email { get; set; }
		//public DateTime? DOB { get; set; }
		public decimal? Weight { get; set; }
		public decimal? Height { get; set; }
		public string? Gender { get; set; }
	}
}

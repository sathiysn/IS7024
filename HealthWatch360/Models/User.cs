using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HealthWatch360.Models
{
    public class User
    {
        public string UserID { get; set; }

        [DisplayName("First Name")]
        [StringLength(40)]
        public string? FirstName { get; set; }

        [DisplayName("Last Name")]
        [StringLength(40)]
        public string? LastName { get; set; }

        [StringLength(40)]
        public string? Email { get; set; }

        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Height { get; set; }

        public string? Gender { get; set; }
    }
}
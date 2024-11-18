using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

//Purpose: represents an individual user of the app
//Uses: stores user details and maintains personalized settings

namespace HealthWatch360.Models
{
    public class User
    {
        public int UserID { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, ErrorMessage = "First name can't be longer than 50 characters.")]
        public string? FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, ErrorMessage = "Last name can't be longer than 50 characters.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? Email { get; set; }

        [DisplayName("Date of Birth")]
        [Range(typeof(DateTime), "1/1/1900", "12/31/2099", ErrorMessage = "Date of Birth must be between 01/01/1900 and 12/31/2099.")]
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }

        [Range(1, 1000, ErrorMessage = "Weight must be between 1 and 1000 pounds.")]
        public decimal? Weight { get; set; }

        [Range(0, 8, ErrorMessage = "Height (Feet) must be between 0 and 8.")]
        public int? HeightFeet { get; set; }

        [Range(0, 11, ErrorMessage = "Height (Inches) must be between 0 and 11.")]
        public int? HeightInches { get; set; }

        [RegularExpression("^(Male|Female|Other|Prefer not to say)$", ErrorMessage = "Invalid gender option.")]
        public string? Gender { get; set; }

        [DisplayName("Street Address")]
        [Required(ErrorMessage = "Street Address is required.")]
        [StringLength(100, ErrorMessage = "Street Address can't be longer than 100 characters.")]
        public string? StreetAddress { get; set; }

        [DisplayName("Zip Code")]
        [Required(ErrorMessage = "Zip Code is required.")]
        [StringLength(5, ErrorMessage = "Zip Code should be exactly 5 characters.")]
        public string? ZipCode { get; set; }

        [StringLength(2, ErrorMessage = "State should be exactly 2 characters.")]
        [Required(ErrorMessage = "State is required.")]
        public string? State { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [StringLength(50, ErrorMessage = "City can't be longer than 50 characters.")]
        public string? City { get; set; }


        //User <-> ExerciseLog Relationship
        public List<ExerciseLog>? ExerciseLog { get; set; }

        //User <-> NutritionLog Relationship
        public List<NutritionLog>? NutritionLog { get; set; }
    }
}


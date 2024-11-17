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
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "First name can't be longer than 50 characters")]
        public string? FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, ErrorMessage = "Last name can't be longer than 50 characters")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }

        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }

        public decimal? Weight { get; set; }

        public int? HeightFeet { get; set; }

        public int? HeightInches { get; set; }

        public string? Gender { get; set; }

        [DisplayName("Street Address")]
        public string? StreetAddress { get; set; }

        [DisplayName("Zip Code")]
        public string? ZipCode { get; set; }

        public string? State { get; set; }

        public string? City { get; set; }


        //User <-> ExerciseLog Relationship
        public List<ExerciseLog>? ExerciseLog { get; set; }

        //User <-> Goal Relationship
        public List<Goal>? Goal { get; set; }

        //User <-> NutritionLog Relationship
        public List<NutritionLog>? NutritionLog { get; set; }
    }
}


using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

//Purpose: represents an individual user of the app
//Uses: stores user details and maintains personalized settings

namespace HealthWatch360.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [DisplayName("First Name")]
        [StringLength(40, ErrorMessage = "First Name cannot exceed 40 characters.")]
        public string? FirstName { get; set; }

        [DisplayName("Last Name")]
        [StringLength(40, ErrorMessage = "Last Name cannot exceed 40 characters.")]
        public string? LastName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string? Email { get; set; }

        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Height { get; set; }

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


        //User <-> MedicationTracker Relationship
        public List<MedicationTracker>? MedicationTracker { get; set; }

        //User <-> NutritionLog Relationship
        public List<NutritionLog>? NutritionLog { get; set; }

    }
}
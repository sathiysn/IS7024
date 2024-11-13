using System;
using System.Collections.Generic;
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
        [StringLength(40)]
        public string? FirstName { get; set; }

        [DisplayName("Last Name")]
        [StringLength(40)]
        public string? LastName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(40)]
        public string? Email { get; set; }

        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }

        [Range(1, 500)]
        public decimal? Weight { get; set; }

        [Range(1, 300)]
        public decimal? Height { get; set; }

        [StringLength(10)]
        public string? Gender { get; set; }

        [DisplayName("Street Address")]
        [StringLength(100)]
        public string? StreetAddress { get; set; }

        [DisplayName("Zip Code")]
        [StringLength(10)]
        public string? ZipCode { get; set; }

        [StringLength(20)]
        public string? State { get; set; }

        [StringLength(30)]
        public string? City { get; set; }

        // User <-> ExerciseLog Relationship
        public List<ExerciseLog>? ExerciseLog { get; set; }

        // User <-> Goal Relationship
        public List<Goal>? Goal { get; set; }

        // User <-> MedicationTracker Relationship
        public List<MedicationTracker>? MedicationTracker { get; set; }

        // User <-> NutritionLog Relationship
        public List<NutritionLog>? NutritionLog { get; set; }
    }
}

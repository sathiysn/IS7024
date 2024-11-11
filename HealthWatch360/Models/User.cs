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

        [DisplayName("Street Address")]
        public string? StreetAddress { get; set; }

        [DisplayName("Zip Code")]
        public string? ZipCode { get; set; }

        public string? State { get; set; }

        //User <-> ExerciseLog Relationship
        public List<ExerciseLog>? ExerciseLog { get; set; }

        //User <-> MedicationTracker Relationship
        public List<MedicationTracker>? MedicationTracker { get; set; }

        //User <-> NutritionLog Relationship
        public List<NutritionLog>? NutritionLog { get; set; }

        //User <-> RiskAssessment Relationship
        public List<RiskAssessment>? RiskAssessment { get; set; }

        //User <-> HealthGoal Relationship
        public List<HealthGoal>? HealthGoal { get; set; }

        //User <-> HealthRecommendation Relationship
        public List<HealthRecommendation>? HealthRecommendation { get; set; }

        //User <-> HealthReport Relationship
        public List<HealthReport>? HealthReport { get; set; }

        //User <-> Notification Relationship
        public List<Notification>? Notification { get; set; }
    }
}

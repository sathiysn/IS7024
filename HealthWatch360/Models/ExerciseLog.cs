using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

//Purpose: Manages user exercise and activity tracking

namespace HealthWatch360.Models
{
    public class ExerciseLog
    {
        public int ExerciseLogID { get; set; }

        public string? Type { get; set; }

        public decimal? Duration { get; set; }

        [DisplayName("Calories Burned")]
        public int? CaloriesBurned { get; set; }

        [DisplayName("Exercise Date")]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }


        //User <-> ExerciseLog Relationship
        public User? User { get; set; }
        public int? UserID { get; set; }

        //
    }
}

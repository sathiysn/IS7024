using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

//Purpose: manages user exercise activity
//Uses: records exercise sessions and will be used to summarize workout information on the home screen

namespace HealthWatch360.Models
{
    public class ExerciseLog
    {
        public int ExerciseLogID { get; set; }

        public string? Type { get; set; }

        public decimal? Duration { get; set; }

        [DisplayName("Calories Burned")]
        [Range(0, 10000, ErrorMessage = "Calories burned must be a positive value.")]
        public int? CaloriesBurned { get; set; }

        [DisplayName("Exercise Date")]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }


        //User <-> ExerciseLog Relationship
        public User? User { get; set; }
        public int? UserID { get; set; }
    }
}

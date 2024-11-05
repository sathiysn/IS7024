using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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

    }
}

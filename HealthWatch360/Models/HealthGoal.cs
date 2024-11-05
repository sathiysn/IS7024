using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HealthWatch360.Models
{
    public class HealthGoal
    {
        public int HealthGoalID { get; set; }

        public string? Type { get; set; }

        public string? Description { get; set; }

        [DisplayName("Target Value")]
        public int? TargetValue { get; set; }

        [DisplayName("Current Value")]
        public int? CurrentValue { get; set; }

        [DisplayName("Date of Workout")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
    }
}

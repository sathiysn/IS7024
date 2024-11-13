using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

//Purpose: tracks and manages a user's personal health goals
//Uses: allows a user to set health-related goals, track their progress, and provides updates and reminders to motivate a user

namespace HealthWatch360.Models
{
    public class Goal
    {
        public int GoalID { get; set; }

        public string? Type { get; set; }

        public string? Description { get; set; }

        [DisplayName("Target Value")]
        public int? TargetValue { get; set; }

        [DisplayName("Current Value")]
        public int? CurrentValue { get; set; }

        [DisplayName("Date of Workout")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }


        //Goal <-> User Relationship
        public User? User { get; set; }
        public int? UserID { get; set; }
    }
}

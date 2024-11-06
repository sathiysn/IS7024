using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

//Purpose: tracks and manages a user's personal health goals
//Uses: allows a user to set health-related goals, track their progress, and provides updates and reminders to motivate a user

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


        //HealthGoal <-> Notification Relationship
        public List<Notification>? Notification { get; set; }

        //HealthGoal <-> User Relationship
        public User? User { get; set; }
        public int? UserID { get; set; }

        //HealthGoal <-> NutritionLog Relationship
        public List<NutritionLog>? NutritionLog { get; set; }

        //HealthGoal <-> ExerciseLog Relationship
        public List<ExerciseLog>? ExerciseLog { get; set; }
    }
}

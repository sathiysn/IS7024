using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

//Purpose: tracks and stores users' nutrition information for each meal 
//Use: works alongside the USDA FoodData API


namespace HealthWatch360.Models
{
    public class NutritionLog
    {
        public int HealthDataID { get; set; }

        public int? Calories { get; set; }

        public int? Carbohydrates { get; set; }

        public int? Proteins { get; set; }

        public int? Fats { get; set; }

        public int? Fiber { get; set; }

        public int? Sugar { get; set; }

        public int? Sodium { get; set; }


        //NutritionLog <-> User Relationship
        public User? User { get; set; }
        public int? UserID { get; set; }

        //NutritionLog <-> HealthGoal Relationship
        public HealthGoal? HealthGoal { get; set; }
        public int? HealthGoalID { get; set; }
    }
}

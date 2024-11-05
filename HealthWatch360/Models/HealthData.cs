using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HealthWatch360.Models
{
    public class HealthData
    {
        public int HealthDataID { get; set; }

        [DisplayName("Date of Workout")]
        [DataType(DataType.Date)]
        public DateTime? WorkoutDate { get; set; }

        public int? Calories { get; set; }

        public int? Carbohydrates { get; set; }

        public int? Proteins { get; set; }

        public int? Fats { get; set; }

        public int? Fiber { get; set; }

        public int? Sugar { get; set; }

        public int? Sodium { get; set; }
    }
}

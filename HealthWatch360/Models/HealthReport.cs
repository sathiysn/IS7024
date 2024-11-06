using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

//Purpose: manages user exercise activity
//Uses: records exercise sessions and will be used to summarize workout information on the home screen

namespace HealthWatch360.Models
{
    public class HealthReport
    {
        public int HealthReportID { get; set; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [DisplayName("End Date")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [DisplayName("Health Data Summary")]
        public string? HealthDataSummary { get; set; }

        [DisplayName("Goal Summary")]
        public string? GoalSummary { get; set; }

        [DisplayName("Recommendation Summary")]
        public string? RecommmendationSummary { get; set; }


        //HealthReport <-> User Relationship
        public User? User { get; set; }
        public int? UserID { get; set; }
    }
}

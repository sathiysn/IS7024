using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

//Purpose: used to generate personalized health recommendations based on a user's data
//Uses: analyzes user data to provide personalized health recommendations tailored to user's needs/wants

namespace HealthWatch360.Models
{
    public class Recommendation
    {
        public int RecommendationID { get; set; }

        public string? Category { get; set; }

        public string? Notification { get; set; }

        public DateTime? Timestamp { get; set; }


        //Recommendation <-> User Relationship
        public User? User { get; set; }
        public int? UserID { get; set; }

        ////Recommendation <-> RiskAssessment Relationship
        //public RiskAssessment? RiskAssessment { get; set; }
        //public int? RiskAssessmentID { get; set; }
    }
}

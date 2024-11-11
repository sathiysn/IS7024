using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

//Purpose: tracks and stores users' risk factors based off of their lifestyle 
//Use: works alongside the CDC API and Notification to provide tailored health recommendations


namespace HealthWatch360.Models
{
    public class RiskAssessment
    {
        public int RiskAssessmentID { get; set; }
        public string? RiskFactorName { get; set; }
        public int? RiskLevel { get; set; }


        //RiskAssessment <-> User Relationship
        public User? User { get; set; }
        public int? UserID { get; set; }

        ////RiskAssessment <-> Recommendation Relationship
        //public Recommendation? Recommendation { get; set; }
        //public int? RecommendationID { get; set; }
    }
}

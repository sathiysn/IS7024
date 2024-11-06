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

        //Risk Assessment <-> HealthRecommendation Relationship
        public HealthRecommendation? HealthRecommendation { get; set; }
        public int? HealthRecommendationID { get; set; }
    }
}

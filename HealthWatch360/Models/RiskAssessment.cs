namespace HealthWatch360.Models
{
    public class RiskAssessment
    {
        public int RiskAssessmentID { get; set; }
        public string? RiskFactorName { get; set; }
        public int? RiskLevel { get; set; }


        //RiskAssessment <-> User Relationship
        public User? User { get; set; }

    }
}

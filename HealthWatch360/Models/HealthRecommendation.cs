using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HealthWatch360.Models
{
    public class HealthRecommendation
    {
        public int HealthRecommendationID { get; set; }

        public string? Category { get; set; }

        public string? Notification { get; set; }

        public DateTime? Timestamp { get; set; }
    }
}

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HealthWatch360.Models
{
    public class Notification
    {
        public int NotificationID { get; set; }

        public string? Message { get; set; }

        public string? Type { get; set; }

        [DataType(DataType.Time)]
        public DateTime? Timestamp { get; set; }
    }
}

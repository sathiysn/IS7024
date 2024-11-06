using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

//Purpose: sends notifications and reminders to users
//Uses: sends reminders for medications, health goals, and other time-sensitive alerts to encourage users to stay on track with their health plan

namespace HealthWatch360.Models
{
    public class Notification
    {
        public int NotificationID { get; set; }

        public string? Message { get; set; }

        public string? Type { get; set; }

        [DataType(DataType.Time)]
        public DateTime? Timestamp { get; set; }


        //Notification <-> User Relationship
        public User? User { get; set; }

        //Notification <-> MedicationTracker Relationship
        public MedicationTracker? MedicationTracker { get; set; }

        //Notification <-> HealthGoal Relationship
        public HealthGoal? HealthGoal { get; set; }

    }
}

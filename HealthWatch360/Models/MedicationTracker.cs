using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

//Purpose: helps users log and manage medication schedules
//Uses: works with Notification to alert user of when a medication needs to be taken and tracks when medication taken

namespace HealthWatch360.Models
{
    public class MedicationTracker
    {
        public int MedicationTrackerID { get; set; }

        [DisplayName("Medication Name")]
        public string? MedicationName { get; set; }

        public decimal? Dosage { get; set; }

        public string? Type { get; set; }

        public string? Frequency { get; set; }

        [DisplayName("Scheduled Time")]
        [DataType(DataType.Time)]
        public DateTime? Time { get; set; }

        public bool? TakenStatus { get; set; }

        [DisplayName("Reminder Time")]
        [DataType(DataType.Time)]
        public DateTime? ReminderTime { get; set; }


        //MedicationTracker <-> User Relationship
        public User? User { get; set; }
        public int? UserID { get; set; }

        //MedicationTracker <-> Notification Relationship
        public List<Notification>? Notification { get; set; }
    }
}

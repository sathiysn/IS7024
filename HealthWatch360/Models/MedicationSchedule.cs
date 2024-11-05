using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HealthWatch360.Models
{
    public class MedicationSchedule
    {
        public int MedicationScheduleID { get; set; }

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
    }
}

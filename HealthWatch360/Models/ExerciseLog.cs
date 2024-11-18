using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

//Purpose: manages user exercise activity
//Uses: records exercise sessions and will be used to summarize workout information on the home screen

namespace HealthWatch360.Models
{
    public class ExerciseLog
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        [Key]
        public int ExerciseLogId { get; set; }

        public class Item
        {
            public string facility_type { get; set; }
            public string name { get; set; }
            public string zip_code { get; set; }
            public string phone { get; set; }
            public Location location { get; set; }
        }

        public class Location
        {
            public string human_address { get; set; }
        }

        public class Root
        {
            public List<Item> items { get; set; }
        }

        //User <-> ExerciseLog Relationship
        public User? User { get; set; }
        public int? UserID { get; set; }

    }
}

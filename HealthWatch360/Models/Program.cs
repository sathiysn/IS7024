using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace HealthWatch360.Models
{
    public class Program
    {
        [Key]
        public int HealthReportId { get; set; }

        public class Item
        {
            public string category { get; set; }
            public string topics { get; set; }
            public string intervention { get; set; }
            public string description { get; set; }
            public string status { get; set; }
            public string outcome { get; set; }
            public DateTime implementation_date { get; set; }
            public string location { get; set; }
            public string address { get; set; }
            public string zip_code { get; set; }
            public string zipcode_pop_2016 { get; set; }
            public string partners { get; set; }
            public string longitude { get; set; }
            public string latitude { get; set; }
            public string neighborhood { get; set; }
            public string zipcode_pop_2010 { get; set; }
            public string notes { get; set; }
        }

        public class Root
        {
            public List<Item> items { get; set; }
        }

        public User? User { get; set; }
        public int? UserID { get; set; }

    }
}

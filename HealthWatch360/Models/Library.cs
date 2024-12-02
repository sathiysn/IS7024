using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace HealthWatch360.Models
{
    public partial class Library
    {
        public class Book
        {
            [JsonProperty("bookTitle")]
            public string BookTitle { get; set; }

            [JsonProperty("comment")]
            public string BookReview { get; set; }

            [JsonProperty("authorName")]
            public string AuthorName { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Seng300Scholarship.Models
{
    public class Scholarship
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
       
        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("org")]
        public string Organization { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        [JsonPropertyName("deadline")]
        public string Deadline { get; set; }

        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        [JsonPropertyName("major")]
        public string Major { get; set; }

        [JsonPropertyName("GPA")]
        public float GPA { get; set; }

        [JsonPropertyName("candidates")]
        public string [] Candidates { get; set; }

        [JsonPropertyName("student-status")]
        public string StudentStatus { get; set; }

        [JsonPropertyName("other-restrictions")]
        public string [] Other { get; set; }

        [JsonPropertyName("supplement")]
        public bool Supplement { get; set; }

        [JsonPropertyName("supp-descr")]
        public string SupplementDescription { get; set; }
    }
}

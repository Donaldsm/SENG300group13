using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Seng300Scholarship.Models
{
    public class Scholarship
    {
      
        [JsonPropertyName("title")]
        public String awardTitle { get; set; }
        public string awardAmount { get; set; }
        public string numberOfAwards { get; set; }
        public String companyTitle { get; set; }
        public String Duration { get; set; }
        public String Deadline { get; set; }
        public String Scope { get; set; }
        public String GPAreq { get; set; }
        public String courseRestriction {get; set;}
        public String candidateRestriction { get; set; }
        public String fulltimeStatus { get; set;  }
        public String supplementary { get; set; }

       
        public override string ToString() => JsonSerializer.Serialize<Scholarship>(this);

    }


}

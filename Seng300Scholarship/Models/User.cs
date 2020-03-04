using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seng300Scholarship.Models
{
    public class User
    {
        public string id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
    }
}

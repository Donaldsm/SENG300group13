using Microsoft.AspNetCore.Hosting;
using Seng300Scholarship.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Seng300Scholarship.Services
{
    public class JsonFileService
    {
        public JsonFileService(IWebHostEnvironment webHostEnvironment) { WebHostEnvironment = webHostEnvironment; }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonScholarshipFile => Path.Combine(WebHostEnvironment.WebRootPath, "data", "scholarships.json");

        public IEnumerable<Scholarship> GetScholarships()
        {
            using (var jsonContents = File.OpenText(JsonScholarshipFile))
            {
                return JsonSerializer.Deserialize<Scholarship[]>(jsonContents.ReadToEnd());
            }
        }
    }
}

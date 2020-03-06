using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Seng300Scholarship.Models;
using Seng300Scholarship.Services;

namespace Seng300Scholarship.Pages
{
    public class Index1Model : PageModel
    {
        public JsonFileService JsonService;


        public IEnumerable<Scholarship> Scholarships { get; set; }

        public Index1Model(JsonFileService jsonService) { JsonService = jsonService; }

        public void OnGet()
        {
            Scholarships = JsonService.GetScholarships();
        }
    }
}

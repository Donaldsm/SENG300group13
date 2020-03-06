using System;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Seng300Scholarship.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

    }
    public class Scholarship
    {
        public Scholarship(string title, string amount, string numberofawards, string company, string duration, string deadline, string scope, string GPA, string courseRes, string candidate, string fulltime, string supplementarythings)
        {
            awardTitle = title;
            awardAmount = amount;
            numberOfAwards = numberofawards;
            companyTitle = company;
            Duration = duration;
            Deadline = deadline;
            Scope = scope;
            GPAreq = GPA;
            courseRestriction = courseRes;
            candidateRestriction = candidate;
            fulltimeStatus = fulltime;
            supplementary = supplementarythings;



        }

        public String awardTitle { get; set; }

        public String awardAmount { get; set; }

        public String numberOfAwards { get; set; }

        public String companyTitle { get; set; }

        public String Duration { get; set; }
        public String Deadline { get; set; }
        public String Scope { get; set; }
        public String GPAreq { get; set; }
        public String courseRestriction { get; set; }
        public String candidateRestriction { get; set; }
        public String fulltimeStatus { get; set; }
        public String supplementary { get; set; }


    }


}


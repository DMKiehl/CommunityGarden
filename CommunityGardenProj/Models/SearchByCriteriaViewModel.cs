using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace CommunityGardenProj.Models
{
    public class SearchByCriteriaViewModel
    {



        [Display(Name = "Zip Code")]
        public int? ZipCode { get; set; }

        public int? Cost { get; set; }
        [Display(Name = "Volunteer Opportunities")]
        public bool VolunteerOpportunities { get; set; }

        public bool Organic { get; set; }
        [Display(Name = "Plot Size")]
        public string? PlotSize { get; set; }
        [Display(Name = "Search By Cost")]

        public bool SearchByCost { get; set; }
        [Display(Name = "Search By Zip Code")]
        public bool SearchByZipCode { get; set; }
        [Display(Name = "Gardens with Volunteer Opportunities")]
        public bool SearchByVolunteerOpportunities { get; set; }
        [Display(Name = "Show Only Organic Gardens")]
        public bool SearchByOrganic { get; set; }
        [Display(Name = "Search Gardens By Plot Size")]
        public bool SearchByPlotSize { get; set; }

    }
}

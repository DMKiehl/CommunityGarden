using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityGardenProj.Models
{
    public class SearchByCriteriaViewModel
    {
        public int? ZipCode { get; set; }

        public int? Cost { get; set; }

        public bool VolunteerOpportunities { get; set; }

        public bool Organic { get; set; }

        public string? PlotSize { get; set; }

        public bool SearchByCost { get; set; }

        public bool SearchByZipCode { get; set; }

        public bool SearchByVolunteerOpportunities { get; set; }

        public bool SearchByOrganic { get; set; }

        public bool SearchByPlotSize { get; set; }

        // bool property for each of the above possible search criteria
        // (these bool properties represent whether or not the user wants to include that propert in their search)
        // add a checkbox for each of these bool properties to your view
    }
}

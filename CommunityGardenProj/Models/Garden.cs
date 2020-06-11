using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityGardenProj.Models
{

    public class Garden
    {
        [Display(Name = "Garden ID")]
        public int gardenId { get; set; }

        [Display(Name = "Garden Name")]
        public string name { get; set; }
        [Display(Name = "Garden Type")]
        public string gardenType { get; set; }
        [Display(Name = "Street Address")]
        public string streetAddress { get; set; }
        [Display(Name = "City")]
        public string city { get; set; }
        [Display(Name = "State")]
        public string state { get; set; }
        [Display(Name = "Zip Code")]
        public int zip { get; set; }
        [Display(Name = "Latitude")]
        public float latitude { get; set; }
        [Display(Name = "Longitude")]
        public float longitude { get; set; }
        [Display(Name = "Volunteer Opportunities")]
        public bool volunteerOpportunities { get; set; }
        [Display(Name = "Organic")]
        public bool organic { get; set; }
        [Display(Name = "Cost")]
        public int cost { get; set; }
        [Display(Name = "Plot Size")]
        public string plotSize { get; set; }
    }

}

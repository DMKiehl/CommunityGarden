using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityGardenProj.Models
{

    public class Garden
    {
        public int gardenId { get; set; }
        public string name { get; set; }
        public string gardenType { get; set; }
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public bool volunteerOpportunities { get; set; }
        public bool organic { get; set; }
        public int cost { get; set; }
        public string plotSize { get; set; }
    }

}

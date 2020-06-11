using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityGardenProj.Models
{
    public class GardenerViewModel
    {    
       public Gardener Gardener { get; set; }

        public Address Address { get; set; }

        //public string StreetAddress { get; set; }
        //public string City { get; set; }

        //public string State { get; set; }

        //public double Zip { get; set; }

        //public double Latitude { get; set; }

        //public double Longitude { get; set; }


    }
}

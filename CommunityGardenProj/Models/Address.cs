using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityGardenProj.Models
{
    public class Address
    {
        [Key]
        public int addressId { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public int latitude { get; set; }

        public double longitude { get; set; }
    }
}

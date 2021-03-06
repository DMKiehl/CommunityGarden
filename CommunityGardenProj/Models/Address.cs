﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityGardenProj.Models
{
    public class Address
    {
        [Key]
        //public int Id { get; set; }
        public int AddressId { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }

        public string State { get; set; }

        public double Zip { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}

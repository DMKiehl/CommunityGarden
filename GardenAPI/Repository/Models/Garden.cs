using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Garden
    {
        [Key]
        public int GardenId { get; set; }

        public string Name { get; set; }

        public string GardenType { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public double Zip { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public bool VolunteerOpportunities { get; set; }

        public bool Organic { get; set; }

        public double Cost { get; set; }

        public string PlotSize { get; set; }

    }
}

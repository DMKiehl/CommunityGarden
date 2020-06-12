using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
       public DbSet<Garden> Garden { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Garden>()
                    .HasData(
                    new Garden
                    {
                        GardenId = 1,
                        Name = "Alice's Garden Urban Farm",
                        GardenType = "Urban Farm",
                        StreetAddress = "2136 N. 21st St.",
                        City = "Milwaukee",
                        State = "WI",
                        Zip = 53205,
                        Latitude = 43.058630,
                        Longitude = -87.938800,
                        VolunteerOpportunities = true,
                        Organic = false,
                        Cost = 0,
                        PlotSize = "Cooperative",
                        Website = "https://www.alicesgardenmke.com"
                    }
                    );

            builder.Entity<Garden>()
                   .HasData(
                   new Garden
                   {
                       GardenId = 2,
                       Name = "Community Church Garden",
                       GardenType = "Vegetable",
                       StreetAddress = "2005 S. Main St.",
                       City = "West Bend",
                       State = "WI",
                       Zip = 53095,
                       Latitude = 43.396120,
                       Longitude = -88.180240,
                       VolunteerOpportunities = false,
                       Organic = false,
                       Cost = 15,
                       PlotSize = "10 X 20",
                       Website = ""
                   }
                   );


            builder.Entity<Garden>()
                   .HasData(
                   new Garden
                   {
                       GardenId = 3,
                       Name = "Urban Ecology Center- Riverside Park",
                       GardenType = "Vegetable",
                       StreetAddress = "1500 E Park Place",
                       City = "Milwaukee",
                       State = "WI",
                       Zip = 53211,
                       Latitude = 43.067730,
                       Longitude = -87.890790,
                       VolunteerOpportunities = false,
                       Organic = true,
                       Cost = 45,
                       PlotSize = "10 X 15",
                       Website = "https://urbanecologycenter.org/"
                   }
                   );


            builder.Entity<Garden>()
                   .HasData(
                   new Garden
                   {
                       GardenId = 4,
                       Name = "Our Common Home Community Garden",
                       GardenType = "Vegetable",
                       StreetAddress = "3722 S. 58th St.",
                       City = "Milwaukee",
                       State = "WI",
                       Zip = 53220,
                       Latitude = 42.976730,
                       Longitude = -87.986170,
                       VolunteerOpportunities = true,
                       Organic = false,
                       Cost = 20,
                       PlotSize = "4 X 10",
                       Website = "https://www.ololmke.org/community-garden/"
                   }
                   );
             }
        }
    }

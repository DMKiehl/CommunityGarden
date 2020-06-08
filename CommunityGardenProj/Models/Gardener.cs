using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityGardenProj.Models
{
    public class Gardener
    {
        [Key]
        public int gardenerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string email { get; set; }
        public string gardenInterest { get; set; }

        [ForeignKey("addressId")]
        public Address address { get; set; }
        public double addressId { get; set; }


        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}

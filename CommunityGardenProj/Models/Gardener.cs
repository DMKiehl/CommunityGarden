using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityGardenProj.Models
{
    [Authorize(Roles ="Gardener")]
    public class Gardener
    {
        [Key]
        public int GardenerId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }

        [Display(Name = "Gardening Interest")]
        public string GardenInterest { get; set; }

        [ForeignKey("AddressId")]
        public Address Address { get; set; }
        
        public int AddressId { get; set; }

        


        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}

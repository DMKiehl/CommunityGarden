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
    }
}

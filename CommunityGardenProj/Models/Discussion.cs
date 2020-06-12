using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityGardenProj.Models
{
    public class Discussion
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string AskQuestion { get; set; }

       
    }
}
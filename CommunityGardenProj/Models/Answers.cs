using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityGardenProj.Models
{
    public class Answers
    {
        [Key]
        public int AnswerId { get; set; }

        public string QuestionAnswer { get; set; }

    }
}

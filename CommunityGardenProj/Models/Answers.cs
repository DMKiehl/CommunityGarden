using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityGardenProj.Models
{
    public class Answers
    {
        [Key]
        public int AnswerId { get; set; }
        [Display(Name = "Answer A Question")]
        public string QuestionAnswer { get; set; }

        [ForeignKey("Discussion")]

        public int QuestionId { get; set; }

        public Discussion Discussion { get; set; }

    }
}

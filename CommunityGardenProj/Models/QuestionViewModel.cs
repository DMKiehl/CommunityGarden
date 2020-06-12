using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityGardenProj.Models
{
    public class QuestionViewModel
    {
        public Discussion Discussion { get; set; }

        public List<Answers> Answers { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizGame.Models
{
    public class APIQuestion
    {
        public string category { get; set;}

        public string type { get; set; }
        public string difficulty { get; set; }

        public string question { get; set; }

        public string correct_answer { get; set; }
        public string[] incorrect_answers { get; set; }
    }
}

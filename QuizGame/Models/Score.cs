
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizGame.Models
{
    public class Score
    {
        public int score { get; set; }
        public int questionNumber { get; set; }


        public Score()
        {
            score = 0;
            questionNumber = 0;
        }
    }
}

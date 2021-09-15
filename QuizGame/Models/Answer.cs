using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizGame.Models
{
    public class Answer
    {
        public string theirAnswer { get; set; }
        public Question question { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace QuizGame.Models
{
    public class Question
    {
        public APIQuestion question { get; set; }
        public int questionNumber { get; set; }

        public string getDecodedQuestion()
        {
            return HttpUtility.HtmlDecode(question.question);
        }

        public string[] getAnswers()
        {
            string[] answers = new string[4];
            for (int i = 0; i < question.incorrect_answers.Length; i++)
            {
                answers[i] = question.incorrect_answers[i];
            }
            answers[3] = question.correct_answer;
            return answers;
        }
    }
}

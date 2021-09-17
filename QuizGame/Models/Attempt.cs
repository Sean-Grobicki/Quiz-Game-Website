using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web;
using System.Net.Http;

namespace QuizGame.Models
{
    public class Attempt
    {
        public Score score { get; set; }
        public Question currentQuestion { get; set; }


        public async Task<Question> getNewQuestion()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Environment.GetEnvironmentVariable("SERVER_ADDRESS"));
            string serialisedJson = await client.GetStringAsync($"?amount=1&type=multiple");
            APIResponse response = JsonConvert.DeserializeObject<APIResponse>(serialisedJson);
            Question question = new Question();
            question.question = response.results[0];
            return question;
        }

        public void increaseQuestionNumber()
        {
            score.questionNumber = score.questionNumber + 1;
        }
        public void increaseScore()
        {
            if (currentQuestion.question.difficulty == "easy")
            {
                score.score = score.score + 2;
            }
            else if (currentQuestion.question.difficulty == "medium")
            {
                score.score = score.score + 5;
            }
            else
            {
                score.score = score.score + 10;
            }
        }


    }
}

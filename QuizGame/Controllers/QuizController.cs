using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using QuizGame.Models;
using Newtonsoft.Json;
using System.Web;

namespace QuizGame.Controllers
{
    public class QuizController : Controller
    {

        private HttpClient _client = new HttpClient();

        public IActionResult Index(User user)
        {
            return View();
        }

        public IActionResult StartQuiz()
        {
            return RedirectToAction("Question","Quiz");
        }

        public IActionResult YourScores()
        {
            return View();
        }

        public IActionResult HighScores()
        {
            return View();
        }

        public async Task<IActionResult> Question()
        {
            // Request API to get question
            _client.BaseAddress = new Uri(Environment.GetEnvironmentVariable("SERVER_ADDRESS"));
            string serialisedJson = await _client.GetStringAsync($"?amount=1&type=multiple");
            APIResponse response = JsonConvert.DeserializeObject<APIResponse>(serialisedJson);
            Question question = new Question();
            question.questionNumber = 1;
            question.question = response.results[0];
            return View("Question",question);
        }


        [HttpPost]
        public IActionResult AnswerQuestion(Answer ans)
        {
            if (ans.theirAnswer == )
            {
                return View("Correct");
            }
            return View("Incorrect");
        }

    }
}

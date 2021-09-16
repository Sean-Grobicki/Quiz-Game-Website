using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using QuizGame.Models;
using Newtonsoft.Json;
using System.Web;

namespace QuizGame.Controllers
{
    public class QuizController : Controller
    {

        public IActionResult Index(User user)
        {
            return View();
        }

        public IActionResult StartQuiz()
        {
            // Maybe create Attempt here and then pass that to current question.
            Attempt attempt = new Attempt();
            return RedirectToAction("Question","Quiz",attempt);
        }

        public IActionResult YourScores()
        {
            return View();
        }

        public IActionResult HighScores()
        {
            return View();
        }

        public async Task<IActionResult> Question(Attempt attempt)
        {
            // Request API to get question
            attempt.increaseQuestionNumber();
            attempt.currentQuestion = await attempt.getNewQuestion();
            return View("Question",attempt);
        }


        [HttpPost]
        public IActionResult AnswerQuestion(Attempt attempt)
        {
            if (attempt.currentQuestion.theirAnswer == attempt.currentQuestion.question.correct_answer)
            {
                attempt.increaseScore();
                return View("Correct",attempt);
            }
            return View("Incorrect",attempt);
        }

    }
}

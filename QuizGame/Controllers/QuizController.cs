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
            attempt.score = new Score();
            TempData["Attempt"] = JsonConvert.SerializeObject(attempt);
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

        [HttpPost]
        public IActionResult NextQuestion(Attempt attempt)
        {
            TempData["Attempt"] = JsonConvert.SerializeObject(attempt);
            return RedirectToAction("Question", "Quiz");
        }

        public async Task<IActionResult> Question()
        {
            if (TempData["Attempt"] != null)
            {
                Attempt attempt = JsonConvert.DeserializeObject<Attempt>(TempData["Attempt"].ToString());
                attempt.increaseQuestionNumber();
                attempt.currentQuestion = await attempt.getNewQuestion();
                return View("Question", attempt);
            }
            //Change this to an error view.
            return View("Index");
        }


        [HttpPost]
        public IActionResult AnswerQuestion(Attempt attempt)
        {
            if (attempt.currentQuestion.theirAnswer == attempt.currentQuestion.question.correct_answer)
            {
                attempt.increaseScore();
                ModelState.Clear();
                return View("Correct",attempt);
            }
            return View("Incorrect",attempt);
        }

        [HttpPost]

        public IActionResult SaveScore(Attempt attempt)
        {
            return RedirectToAction("Index", "Quiz");
        }
    }
}

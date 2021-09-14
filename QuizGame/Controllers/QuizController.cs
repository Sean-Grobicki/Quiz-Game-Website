using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizGame.Models;

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

        public IActionResult Question()
        {
            // Request API to get question
            Question question = new Question();
            question.questionNumber = 1;
            return View("Question",question);
        }

    }
}

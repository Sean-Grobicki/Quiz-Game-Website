using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizGame.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StartQuiz()
        {
            return View();
        }

        public IActionResult ViewScores()
        {
            return View();
        }

        public IActionResult ViewHighScores()
        {
            return View();
        }

        public async Task<IActionResult> GetQuestion()
        {
            // Request API to get question

            return View();
        }

    }
}

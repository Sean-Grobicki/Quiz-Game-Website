using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuizGame.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QuizGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            // Search the database for username and password that match
            // Retrive their attempts data
            // Return login data with that.
            return RedirectToAction("Index", "Quiz" ,user);
        }

        [HttpPost]
        public IActionResult CreateAccount(User user)
        {
            // Search the database for username and password that match
            // Retrive their attempts data
            // Return login data with that.
            return RedirectToAction("Index", "Quiz", user);
        }

        public IActionResult CreateAccount()
        {
            return View();
        }

    }
}

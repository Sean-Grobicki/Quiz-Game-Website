﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizGame.Models
{
    public class Question
    {
        public APIQuestion question { get; set; }
        public int questionNumber { get; set; }
    }
}
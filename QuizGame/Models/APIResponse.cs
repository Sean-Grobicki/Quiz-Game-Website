using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizGame.Models
{
    public class APIResponse
    {
        public int response_code { get; set; }

        public List<APIQuestion> results { get; set; }

    }
}

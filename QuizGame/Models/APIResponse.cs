using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizGame.Models
{
    public class APIResponse
    {
        int response_code { get; set; }

        List<APIQuestion> results { get; set; }
    }
}

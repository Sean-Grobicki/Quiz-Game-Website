using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QuizGame.Models
{
    public class User
    {
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(10,MinimumLength =3, ErrorMessage = "Username should be minimum 3 characters and a maximum of 50 characters")]
        public string username { get; set; }
       
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50,MinimumLength = 6, ErrorMessage = "Password should be minimum 6 characters and a maximum of 50 characters.")]
        public string password { get; set; }

        public List<Attempt> attempts { get; set; }

    }
}

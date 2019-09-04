using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracWebApp.Models
{
    public class PracModel
    {
        // just a dummy model

        // DataAnnotations gives us a built in form of validation. 
        // Range means values can only be between thos values
        [Range(1, 999)]
        public int IdNumber { get; set; }

        // required just means it has to be entered for model state to be valid
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        

        [Range(5, 50)]
        public int Age { get; set; }

        [Required]
        string EmailAddress;



    }
}
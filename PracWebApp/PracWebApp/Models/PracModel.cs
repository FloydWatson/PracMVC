using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracWebApp.Models
{
    public class PracModel
    {

        [Range(1, 999)]
        public int IdNumber { get; set; }

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
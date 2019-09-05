using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracWebApp.Models
{
    public class BookModel
    {
        [Required]
        public string BookTitle { get; set; }

        [Required]
        public string Author { get; set; }

        public int PageCount { get; set; }

        public bool IsEdible { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PracWebApp.Models
{
    public class AnimeModel
    {
        [Required]
        public string AnimeName { get; set; }

        [Required]
        public string Genre1 { get; set; }

        public string Genre2 { get; set; }

        [Required]
        public int SeasonCount { get; set; }

        [Range(1,9999)]
        public int EpisodeCount { get; set; }
    }
}
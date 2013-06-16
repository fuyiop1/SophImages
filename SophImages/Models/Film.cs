using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SophImages.Models
{
    public class Film
    {
        public int Id { get; set; }

        public bool IsPublished { get; set; }

        public int Status { get; set; }

        [Required(ErrorMessage="Please enter the name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the uri")]
        public string Uri { get; set; }

        [Required(ErrorMessage = "Please enter the introduction")]
        public string Introduction { get; set; }

        public string Director { get; set; }
        public string Cast { get; set; }
        public int Year { get; set; }

        public DateTime InsertDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }

        public string FilmPrizeDescription { get; set; }

        public List<FilmPartner> FilmPartners { get; set; }
        public List<FilmPrize> FilmPrizes { get; set; }
        public List<FilmPress> FilmPresses { get; set; }
        public List<FilmScreenshot> FilmScreenshots { get; set; }

    }

    public enum FilmStatus
    {
        [Description("Recent")]
        Recent,

        [Description("In Production")]
        InProduction
    }
}
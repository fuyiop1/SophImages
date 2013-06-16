using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SophImages.Models
{
    public class FilmPartner
    {
        public int Id { get; set; }

        public List<Film> Films { get; set; }

        [Required(ErrorMessage = "Please enter the description")]
        public string Description { get; set; }

        public byte[] Image { get; set; }

        public string Url { get; set; }
    }
}
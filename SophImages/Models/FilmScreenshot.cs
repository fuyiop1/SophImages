using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace SophImages.Models
{
    public class FilmScreenshot
    {
        public int Id { get; set; }

        [Required]
        public Film Film { get; set; }

        public string Description { get; set; }

        public byte[] Image { get; set; }
    }
}
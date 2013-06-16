﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SophImages.Models
{
    public class FilmPrize
    {
        public int Id { get; set; }

        public List<Film> Films { get; set; }

        public string Description { get; set; }

        public byte[] Image { get; set; }

    }
}
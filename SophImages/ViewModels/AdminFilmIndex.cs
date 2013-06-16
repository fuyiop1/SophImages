using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SophImages.Models;

namespace SophImages.ViewModels
{
    public class AdminFilmIndex : PagerBase
    {
        public List<Film> Films { get; set; }
    }
}
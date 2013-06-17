using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SophImages.Models;
using SophImages.Helpers;

namespace SophImages.ViewModels
{
    public class AdminFilmCreate
    {
        public AdminFilmCreate()
        {
            FilmStatusDictionary = EnumHelper.ConvertEnumToDictionary(typeof(FilmStatus));
        }

        public bool IsForUpdate { get; set; }
        public Film Film { get; set; }

        public int PageIndex { get; set; }

        public Dictionary<int, string> FilmStatusDictionary { get; set; }
    }
}
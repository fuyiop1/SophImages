using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Configuration;
using SophImages.Models;

namespace SophImages.DatabaseContext
{
    public class SophImagesDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmPartner> FilmPartners { get; set; }
        public DbSet<FilmPress> FilmPresses { get; set; }
        public DbSet<FilmPrize> FilmPrizes { get; set; }
        public DbSet<FilmScreenshot> FilmScreenshots { get; set; }
    }
}
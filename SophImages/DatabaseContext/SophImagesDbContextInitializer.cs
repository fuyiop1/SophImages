using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Configuration;
using SophImages.Models;

namespace SophImages.DatabaseContext
{
    public static class SophImagesDbContextInitializer
    {
        public static void InitDatabaseSetup(){
            var isAutoUpdateDatabase = ConfigurationManager.AppSettings["IsAutoUpdateDatabase"];
            if (isAutoUpdateDatabase == "true")
            {
                Database.SetInitializer(new SophImagesDropCreateDatabaseIfModelChanges());
            }
            else
            {
                Database.SetInitializer(new CreateDatabaseIfNotExists<SophImagesDbContext>());
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SophImages.Models;

namespace SophImages.DatabaseContext
{
    public class SophImagesDropCreateDatabaseIfModelChanges : DropCreateDatabaseIfModelChanges<SophImagesDbContext>
    {
        protected override void Seed(SophImagesDbContext context)
        {
            base.Seed(context);
            context.Admins.Add(new Admin()
            {
                UserName = "admin",
                Password = "123qwe"
            });
            context.SaveChanges();
        }
    }
}
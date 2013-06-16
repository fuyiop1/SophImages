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

            for (int i = 0; i < 20; i++)
            {
                var now = DateTime.Now;
                context.Films.Add(new Film()
                {
                    Name = "Iron Man " + i,
                    Uri = "www.baidu.com/" + i,
                    Introduction = "Introduction " + i,
                    Director = "David " + i,
                    Status = i % 2,
                    Year = now.Year - (i % 5),
                    InsertDateTime = now,
                    UpdateDateTime = now
                });
            }

            context.SaveChanges();
        }
    }
}
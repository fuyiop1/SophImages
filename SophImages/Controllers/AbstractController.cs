using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SophImages.DatabaseContext;

namespace SophImages.Controllers
{
    public abstract class AbstractController : Controller
    {
        protected SophImagesDbContext DbContext = new SophImagesDbContext();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SophImages.ViewModels;
using SophImages.Models;
using SophImages.Helpers;

namespace SophImages.Controllers
{
    public class AdminFilmController : AdminAbstractController
    {

        public ActionResult Index()
        {
            var viewModel = new AdminFilmIndex()
            {
                PageIndex = PageIndex,
                PageSize = PageSize,
                TotalCount = DbContext.Films.Count(),
                Films = DbContext.Films.OrderBy(x => x.Id).Skip(PageSkipCount()).Take(PageSize).ToList(),
                Controller = "AdminFilm",
                Action = "Index"
            };
            viewModel.ProcessQueryString(Request.Url.Query);
            return View(viewModel);
        }

        public ActionResult Create()
        {
            var viewModel = new AdminFilmCreate()
            {
                Film = new Film()
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(AdminFilmCreate viewModel)
        {
            if (ModelState.IsValid)
            {
                var now = DateTime.Now.ToDefaultTargetGmtTime();
                viewModel.Film.InsertDateTime = now;
                viewModel.Film.UpdateDateTime = now;
                DbContext.Films.Add(viewModel.Film);
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(viewModel);
            }
        }

    }
}

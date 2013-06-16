using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSiteMapProvider;
using SophImages.Helpers;

namespace SophImages.Controllers
{
    public abstract class AdminAbstractController : AbstractController
    {
        private int pageSize;

        protected int PageSize
        {
            get
            {
                if (this.pageSize == 0)
                {
                    ProcessPageSize();
                }
                return this.pageSize;
            }
        }

        private int pageIndex;
        protected int PageIndex
        {
            get
            {
                if (this.pageIndex == 0)
                {
                    this.pageIndex = ProtoTypeHelper.TryToParseInt(Request["pageIndex"], 1);
                }
                if (this.pageIndex < 1)
                {
                    this.pageIndex = 1;
                }
                return this.pageIndex;
            }
        }

        protected int PageSkipCount(int pageIndex = 0)
        {
            var result = 0;
            if (pageIndex < 1)
            {
                pageIndex = PageIndex;
            }
            if (pageIndex > 1)
            {
                result = (pageIndex - 1) * PageSize;
            }
            return result;
        }

        protected void RefreshSiteMap()
        {
            var siteMapProvider = SiteMap.Provider as DefaultSiteMapProvider;
            if (siteMapProvider != null)
            {
                siteMapProvider.Refresh();
            }
        }

        private void ProcessPageSize()
        {

            var cookieName = string.Empty;
            var defaultPageSize = 10;
            var finalPageSize = defaultPageSize;

            if (this is AdminFilmController)
            {
                cookieName = ConstHelper.PageSizeFilmCookie;
            }

            var pageSizeFromRequest = ProtoTypeHelper.TryToParseInt(Request["pageSize"]);

            var pageSizeFromCookie = 0;
            var pageSizeCookie = Request.Cookies[cookieName];
            if (pageSizeCookie != null)
            {
                pageSizeFromCookie = ProtoTypeHelper.TryToParseInt(Request.Cookies[cookieName].Value);
            }

            if (pageSizeFromRequest != 0)
            {
                finalPageSize = pageSizeFromRequest;
            }
            else
            {
                if (pageSizeFromCookie != 0)
                {
                    finalPageSize = pageSizeFromCookie;
                }
            }

            if (pageSizeFromCookie != finalPageSize && !string.IsNullOrEmpty(cookieName))
            {
                Response.Cookies.Add(new HttpCookie(cookieName, finalPageSize.ToString()));
            }

            this.pageSize = finalPageSize;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace SophImages.Helpers
{
    public static class ConstHelper
    {
        public static readonly string RememerAccountCookieName = "SophImagesAdminRemeberedAccount";
        public static readonly int PageIndexOffset;
        public const int PageDefaultSize = 10;
        public static readonly string PageSizeFilmCookie = "PageSizeFilmCookie";

        static ConstHelper()
        {
            var pageIndexOffset = 0;
            int.TryParse(ConfigurationManager.AppSettings["PageIndexOffset"], out pageIndexOffset);
            if (pageIndexOffset == 0)
            {
                pageIndexOffset = 3;
            }
            PageIndexOffset = pageIndexOffset;
        }
    }
}
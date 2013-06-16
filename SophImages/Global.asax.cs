using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace SophImages
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            SophImages.Helpers.LogHelper.LogFilePath = Server.MapPath("~/log.txt");
            SophImages.DatabaseContext.SophImagesDbContextInitializer.InitDatabaseSetup();
        }

        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
            var segments = Request.Url.Segments;
            if (segments == null || segments.Length == 1)
            {
                var indexUrl = UrlHelper.GenerateContentUrl("~/index.htm", this.Request.RequestContext.HttpContext);
                Response.Redirect(indexUrl);
            }
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            if (System.Configuration.ConfigurationManager.AppSettings["IsRawExceptionHidden"] == "true")
            {
                Exception exception = Server.GetLastError();

                SophImages.Helpers.LogHelper.WriteLog(exception.ToString());

                Response.Clear();

                var routeData = new RouteData();
                routeData.Values.Add("controller", "Error");
                routeData.Values.Add("action", "Error");
                Server.ClearError();

                IController errorController = new SophImages.Controllers.ErrorController();
                errorController.Execute(new RequestContext(new HttpContextWrapper(this.Context), routeData));
            }
        }

    }
}
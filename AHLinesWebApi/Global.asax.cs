using System;
using System.Threading;
using System.Web;
using System.Web.Http;

namespace AHLinesWebApi
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                try
                {
                    HttpContext.Current.Response.AddHeader("Cache-Control", "no-cache");
                    HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "POST, GET, OPTIONS, PUT, DELETE");
                    HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept, Authorization");
                    HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");
                    HttpContext.Current.ApplicationInstance.CompleteRequest();
                }
                catch (ThreadAbortException)
                {

                }
            }
        }
    }
}
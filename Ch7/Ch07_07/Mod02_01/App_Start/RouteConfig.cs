using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mod02_01
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {            
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Lab06_02
            routes.MapMvcAttributeRoutes();

            //Lab06_01
            //routes.MapRoute(
            //    name: "OperaTitleRoute",
            //    url: "opera/title/{title}",
            //    defaults: new { controller = "opera", action = "DetailsByTitle", title = UrlParameter.Optional }
            //);            

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

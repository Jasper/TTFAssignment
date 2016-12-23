using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace TTFAssignment
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapHttpRoute(
                name: "Base",
                routeTemplate: "base",
                defaults: new { controller = "Base", action = "Index"}
            );

            routes.MapHttpRoute(
                name: "SpecializedOne",
                routeTemplate: "specialized/one",
                defaults: new { controller = "Specialized", action = "One" }
            );
            routes.MapHttpRoute(
                name: "SpecializedTwo",
                routeTemplate: "specialized/two",
                defaults: new { controller = "Specialized", action = "Two" }
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PruebaTecnica_SaonGroup
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

            //routes.MapRoute(
            //    name: "NuevoRegistro",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "NuevoRegistro", action = "NuevoRegistro", id = UrlParameter.Optional }
            //);
        }
    }
}

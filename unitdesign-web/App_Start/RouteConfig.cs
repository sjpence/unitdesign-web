using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace unitdesign_web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            // Legacy Routes for old unitdesign.com site
            routes.MapRoute(
                name: "LegacyCleaning",
                url: "cleaning/{path}",
                defaults: new { controller = "Redirect", action = "Cleaning", path="" }
            );
            routes.MapRoute(
                name: "LegacySoldering",
                url: "soldering/{path}",
                defaults: new { controller = "Redirect", action = "Soldering", path = "" }
            );
            routes.MapRoute(
                name: "LegacyTinning",
                url: "tinning/{path}",
                defaults: new { controller = "Redirect", action = "Tinning", path = "" }
            );
            routes.MapRoute(
                name: "LegacyAbout",
                url: "about-us",
                defaults: new { controller = "Redirect", action = "About" }
            );
            routes.MapRoute(
                name: "LegacyContact",
                url: "contact",
                defaults: new { controller = "Redirect", action = "Contact" }
            );

            // Main Rout for new site
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

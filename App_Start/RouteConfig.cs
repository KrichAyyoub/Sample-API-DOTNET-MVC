﻿using System.Web.Mvc;
using System.Web.Routing;

namespace testdotnetcore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                "MoviesByReleaseDate",
                "Movies/realeased/{year}/{month}",
                new { controller = "Movies", action = "ByReleaseDate" },
                new {year = @"\d{4}", month = @"\d{2}"});
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

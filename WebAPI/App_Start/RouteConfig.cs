﻿using System.Web.Mvc;
using System.Web.Routing;

/// <summary />
public class RouteConfig
{
    public static void RegisterRoutes()
    {
        RegisterRoutes(new RouteCollection());
    }
    public static void RegisterRoutes(RouteCollection routes)
    {
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

        // By default route the user to the Help area if accessing the base URI.
        routes.MapRoute(
            "Help Area",
            "",
            new { controller = "Help", action = "Index" }
        ).DataTokens = new RouteValueDictionary(new { area = "HelpPage" });
    }
}
﻿using System.Web.Optimization;

public class BundleConfig
{
    public static void RegisterBundles(BundleCollection bundles)
    {
        bundles.Add(new StyleBundle("~/Content").Include(
          "~/Content/HelpPage.css"
        ));
    }
}
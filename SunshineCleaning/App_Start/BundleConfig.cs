﻿using System.Web;
using System.Web.Optimization;

namespace SunshineCleaning
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                       "~/Scripts/jquery-{version}.js",
                       "~/Scripts/bootstrap.js",
                       "~/Scripts/bootbox.js",
                       "~/Scripts/respond.js",

                       //IMPLEMENTED TO SHOW DIFFERENT LOOK OF TABLE
                       "~/scripts/datatables/jquery.datatables.js",
                       "~/scripts/datatables/datatables.bootstrap.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          ));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap-spacelabe.css",
            //          "~/Content/datatables/css/datatables.bootstrap.css",
            //          "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap-spacelabe.css",
                     "~/Content/datatables/css/datatables.bootstrap.css",
                     "~/Content/site.css"));
        }
    }
}

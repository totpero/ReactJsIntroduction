﻿using System.Web;
using System.Web.Optimization;

namespace SimpleReactExamples
{
    public class BundleConfig
    {
        // Weitere Informationen zu Bundling finden Sie unter "http://go.microsoft.com/fwlink/?LinkId=301862"
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/libraries").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/node_modules/react/dist/react-with-addons.js",
                        "~/node_modules/react-dom/dist/react-dom.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                       "~/ScriptsApp/helloWorldTypeScript.js",
                       "~/ScriptsApp/HelloWorldJavaScript.js"
                       ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}

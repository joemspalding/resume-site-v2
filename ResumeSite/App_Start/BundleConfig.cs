using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ResumeSite.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;


            //this bundle will be for custom CSS
            bundles.Add(new StyleBundle("~/bundles/sitestyles").Include(
                "~/Content/Site.css",
                "~/Content/Error.css"
                ));
            bundles.Add(new ScriptBundle("bundlepath").Include(
                "realpath"
                ));
        }
    }
}
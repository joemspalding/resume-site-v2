using System.Web;
using System.Web.Optimization;

namespace JoeResumeSite
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/bundles/bootstrap").Include(
                        "~/Content/bootstrap-4.css",
                        "~/Content/bootstrap-4-overrides"
                        ));

            bundles.Add(new StyleBundle("~/bundles/font-awesome.css").Include(
                         "~/Content/fontawesome-free-5.3.1-web/css/all.css",
                         "~/Content/fontawesome-free-5.3.1-web/css/brands.css",
                         "~/Content/fontawesome-free-5.3.1-web/css/solid.css"
                         ));
            //bundles.Add(new StyleBundle("~/bundles/font-awesome.css", @"https://use.fontawesome.com/releases/v5.3.1/css/all.css"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = false;

        }
    }
}

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
                        "~/Content/bootstrap-4.css"));

            bundles.Add(new StyleBundle("~/budles/font-awesome").Include(
                        "~/Content/font-awesome"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = false;

        }
    }
}

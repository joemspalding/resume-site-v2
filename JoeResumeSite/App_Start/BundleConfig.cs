using System.Web;
using System.Web.Optimization;

namespace JoeResumeSite
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;


            bundles.Add(new ScriptBundle("~/bundles/jquery", "https://code.jquery.com/jquery-3.3.1.js")
            .Include(
                    "~/Scripts/jquery-{version}.js"
                    ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval")
                .Include(
                        "~/Scripts/jquery.validate*"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs", "https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js")
            .Include(
                    "~/Scripts/bootstrap.min.js"
                    ));

            bundles.Add(new ScriptBundle("~/bundles/popperjs")
            .Include(
                    "~/Scripts/esm/popper.js"
                    ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include(
                        "~/Scripts/modernizr-*"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/sitejs")
                .Include(
                        "~/Scripts/SiteScripts/resumeHelper.js",
                        "~/Scripts/SiteScripts/errorHelper.js"
                        ));


            bundles.Add(new StyleBundle("~/bundles/bootstrap", "https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css")
                .Include(
                        "~/Content/bootstrap.css"
                        ));

            bundles.Add(new StyleBundle("~/bundles/font-awesome", @"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css")
                .Include(
                         "~/Content/font-awesome.min.css", new CssRewriteUrlTransform()
                         ));

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include(
                      "~/Content/Site/site.css",
                      "~/Content/Site/about.css",
                      "~/Content/Site/resume.css",
                      "~/Content/Site/contact.css",
                      "~/Content/Site/error.css",
                      "~/Content/bootstrap-4-overrides.css"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/fonts", @"https://www.googletagmanager.com/gtag/js?id=UA-126098967-1"));

            BundleTable.EnableOptimizations = false;

        }
    }
}

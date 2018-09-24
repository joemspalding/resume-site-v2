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

            bundles.Add(new ScriptBundle("~/bundles/homejs")
                .Include(
                        "~/Scripts/SiteScripts/resumeHelper.js",
                        "~/Scripts/SiteScripts/errorHelper.js"
                        ));


            bundles.Add(new StyleBundle("~/bundles/bootstrap", "https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css")
                .Include(
                        "~/Content/bootstrap.css"
                        ));

            // please work for daddy..........
            bundles.Add(new StyleBundle("~/bundles/font-awesome.css", @"https://use.fontawesome.com/releases/v5.3.1/css/brands.css")
                .Include(
                         "~/Content/fontawesome.min.css",
                         new CssRewriteUrlTransform()
                         ));

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include(
                      "~/Content/site.css",
                      "~/Content/error.css"
                      ));

            BundleTable.EnableOptimizations = !true;

        }
    }
}

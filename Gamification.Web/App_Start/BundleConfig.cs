using System.Web;
using System.Web.Optimization;

namespace Gamification.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/resources/js").Include(
                      "~/resources/js/sb-admin-2.js"));
            bundles.Add(new StyleBundle("~/vendor/jquery/").Include(
                      "~/vendor/jquery/jquery.min.js"));
            bundles.Add(new StyleBundle("~/vendor/bootstrap/js/").Include(
                      "~/vendor/bootstrap/js/bootstrap.min.js"));
            bundles.Add(new StyleBundle("~/vendor/metisMenu/").Include(
                        "~/vendor/metisMenu/metisMenu.min.js"));
            bundles.Add(new StyleBundle("~/vendor/raphael/").Include(
                        "~/vendor/raphael/raphael.min.js"));
            bundles.Add(new StyleBundle("~/vendor/morrisjs/").Include(
                        "~/vendor/morrisjs/morris.min.js"));
            bundles.Add(new StyleBundle("~/data/morris-data.js").Include(
                        "~/data/morris-data.js"));
            bundles.Add(new StyleBundle("~//dist/js/").Include(
                        "~/dist/js/sb-admin-2.js"));
        }
    }
}

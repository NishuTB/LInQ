using System.Web;
using System.Web.Optimization;

namespace scLInq.WebUI
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


            // Scripts only for FAQ page
            bundles.Add(new ScriptBundle("~/jsFAQjqGridBundle").Include(
                                     "~/Scripts/JQGrid/jquery.jqGrid.js",
                                    "~/Scripts/JQGrid/i18n/grid.locale-en.js",
                                   "~/Scripts/Custom/FAQ/FAQDocScript.js"
                                  ));

            bundles.Add(new ScriptBundle("~/jsManageFAQjqGridBundle").Include(
                                     "~/Scripts/JQGrid/jquery.jqGrid.js",
                                    "~/Scripts/JQGrid/i18n/grid.locale-en.js",
                                   "~/Scripts/Custom/FAQ/ManageFAQScript.js"
                                  ));


            bundles.Add(new StyleBundle("~/cssBundle").Include(
                                       "~/Content/lib/css/bootstrap.min.css",
                                       "~/Content/lib/css/font-awesome.min.css",
                                       "~/Content/lib/css/animate.min.css",
                                       "~/Content/lib/css/bootstrap-switch.min.css",
                                       "~/Content/lib/css/checkbox3.min.css",
                                       "~/Content/lib/css/jquery.dataTables.min.css",
                                       "~/Content/lib/css/dataTables.bootstrap.css",
                                       "~/Content/lib/css/select2.min.css",
                                       "~/Content/css/style.css",
                                       "~/Content/css/themes/flat-blue.css"
                                     ));


        }
    }
}

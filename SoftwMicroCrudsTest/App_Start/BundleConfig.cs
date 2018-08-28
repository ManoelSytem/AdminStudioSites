using System.Web;
using System.Web.Optimization;

namespace SoftwMicroCrudsTest
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            //Style
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/plugins/bootstrap/css/bootstrap.css",
                      "~/plugins/node-waves/waves.css",
                      "~/plugins/animate-css/animate.css",
                     "~/plugins/morrisjs/morris.css",
                     "~/css/style.css",
                     "~/css/themes/all-themes.css"));

            //script
            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                     "~/plugins/jquery/jquery.min.js",
                     "~/plugins/bootstrap/js/bootstrap.js",
                     "~/plugins/bootstrap-select/js/bootstrap-select.js",
                     "~/plugins/jquery-slimscroll/jquery.slimscroll.js",
                     "~/plugins/node-waves/waves.js",
                     "~/plugins/jquery-countto/jquery.countTo.js",
                     "~/plugins/raphael/raphael.min.js",
                     "~/plugins/morrisjs/morris.js",
                     "~/plugins/chartjs/Chart.bundle.js",
                     "~/plugins/flot-charts/jquery.flot.js",
                     "~/plugins/flot-charts/jquery.flot.resize.js",
                     "~/plugins/flot-charts/jquery.flot.pie.js",
                     "~/plugins/flot-charts/jquery.flot.categories.js",
                     "~/plugins/flot-charts/jquery.flot.time.js",
                     "~/plugins/jquery-sparkline/jquery.sparkline.js"));


            //script js
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/js/admin.js",
                        "~/js/pages/index.js",
                        "~/js/demo.js"));
        }
    }
}

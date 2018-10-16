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

            bundles.Add(new StyleBundle("~/login/css").Include(
                   "~/css/login/vendor/bootstrap/css/bootstrap.min.css",
                   "~/css/login/vendor/animate/animate.css",
                   "~/css/login/vendor/css-hamburgers/hamburgers.min.css",
                   "~/css/login/vendor/animsition/css/animsition.min.css",
                   "~/css/login/vendor/select2/select2.min.css",
                   "~/css/login/vendor/daterangepicker/daterangepicker.css",
                   "~/css/login/main.css",
                   "~/css/login/util.css"));
            
            bundles.Add(new ScriptBundle("~/login/script").Include(
                  "~/css/login/vendor/jquery/jquery-3.2.1.min.js",
                  "~/css/login/vendor/animsition/js/animsition.min.js",
                  "~/css/login/vendor/bootstrap/js/popper.js",
                  "~/css/login/vendor/bootstrap/js/bootstrap.min.js",
                  "~/css/login/vendor/select2/select2.min.js",
                  "~/css/login/vendor/daterangepicker/moment.min.js",
                  "~/css/login/vendor/daterangepicker/daterangepicker.js",
                  "~/css/login/vendor/countdowntime/countdowntime.js",
                  "~/js/login/main.js"
                   ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/plugins/bootstrap/css/bootstrap.css",
                     "~/plugins/node-waves/waves.css",
                     "~/plugins/animate-css/animate.css",
                     "~/plugins/morrisjs/morris.css",
                     "~/css/style.css",
                     "~/css/themes/all-themes.css"
                     ));

           


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
                        "~/js/demo.js"
                        ));

            BundleTable.EnableOptimizations = true;

        }


    }
}

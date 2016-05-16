using System.Web;
using System.Web.Optimization;

namespace SincolPDV.Aplicacao
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
                      "~/Scripts/app.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/Plugins/js/toast").Include(
                      "~/Plugins/js/toast/jquery.toast.js"));

            bundles.Add(new ScriptBundle("~/Plugins/js/uteis").Include(
                      "~/Plugins/_uteis.js"));

            bundles.Add(new ScriptBundle("~/Plugins/js/compartilhado").Include(
                      "~/Plugins/_Compartilhado.js"));

            bundles.Add(new StyleBundle("~/Plugins/css/toast").Include(
                      "~/Plugins/css/toast/jquery.toast.css"));

            bundles.Add(new ScriptBundle("~/Plugins/js").Include(
                      "~/Plugins/js/select2.full.min.js",
                      "~/Plugins/js/jquery.inputmask.js",
                      "~/Plugins/js/jquery.inputmask.date.extensions.js",
                      "~/Plugins/js/jquery.inputmask.extensions.js",
                      "~/Plugins/js/daterangepicker.js",
                      "~/Plugins/js/bootstrap - colorpicker.min.js",
                      "~/Plugins/js/bootstrap - timepicker.min.js",
                      "~/Plugins/js/jquery.slimscroll.min.js",
                      "~/Plugins/js/icheck.min.js",
                      "~/Plugins/js/fastclick.min.js"));

            bundles.Add(new ScriptBundle("~/Plugins/js/datatables").Include(
                      "~/Plugins/js/datatables/jquery.dataTables.min.js",
                      "~/Plugins/js/datatables/dataTables.bootstrap.min.js"));

            //bundles.Add(new StyleBundle("~/Plugins/css").Include(
            //          "~/Plugins/css/all.css",
            //          "~/Plugins/css/select2.min.css"));

            bundles.Add(new StyleBundle("~/Plugins/css/datatables").Include(
                      "~/Plugins/css/datatables/dataTables.bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Plugins/css/all.css",
                      "~/Plugins/css/select2.min.css",
                      "~/Content/AdminLTE.min.css",
                      "~/Content/_all-skins.min.css"));
        }
    }
}

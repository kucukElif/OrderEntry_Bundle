using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
namespace OrderEntry_Bundle.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundle/css").Include(
               "~/Content/plugins/fontawesome-free/css/all.min.css",
               "~/Content/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
               "~/Content/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
               "~/Content/plugins/jqvmap/jqvmap.min.css",
               "~/Content/dist/css/adminlte.min.css",
               "~/Content/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
               "~/Content/plugins/daterangepicker/daterangepicker.css",
               "~/Content/plugins/summernote/summernote-bs4.css"
                ));
            bundles.Add(new ScriptBundle("~/bundle/js").Include(
                "~/Content/plugins/jquery/jquery.min.js",
                "~/Content/plugins/jquery-ui/jquery-ui.min.js",
                "~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js",
                "~/Content/plugins/chart.js/Chart.min.js",
                "~/Content/plugins/sparklines/sparkline.js",
                "~/Content/plugins/jqvmap/jquery.vmap.min.js",
                "~/Content/plugins/jqvmap/maps/jquery.vmap.usa.js",
                "~/Content/plugins/jquery-knob/jquery.knob.min.js",
                "~/Content/plugins/moment/moment.min.js",
                "~/Content/plugins/daterangepicker/daterangepicker.js",
                "~/Content/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
                "~/Content/plugins/summernote/summernote-bs4.min.js",
                "~/Content/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
                "~/Content/dist/js/adminlte.js",
                "~/Content/dist/js/pages/dashboard.js",
                "~/Content/dist/js/demo.js"
                ));
        }
    }
}
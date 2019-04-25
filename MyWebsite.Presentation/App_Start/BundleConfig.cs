using System.Web;
using System.Web.Optimization;

namespace MyWebsite.Presentation
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //Theme
            bundles.Add(new StyleBundle("~/Content/style").Include(
                 "~/Content/Theme/css/themify-icons.css",
                  "~/Content/Theme/css/font-awesome.css",
                     "~/Content/Theme/css/bootstrap.css",
                     "~/Content/Theme/css/flaticon.css",
                     "~/Content/Theme/css/style.css",
                     "~/Content/Theme/css/bootstrap.css",
                      "~/Content/Theme/vendors/owl-carousel/owl.carousel.min.css",
                      "~/Content/Theme/vendors/nice-select/css/nice-select.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/js").Include(
                    "~/Content/Theme/js/jquery-3.2.1.min.js",
                    "~/Content/Theme/js/popper.js",
                    "~/Content/Theme/js/bootstrap.min.js",
                    "~/Content/Theme/vendors/nice-select/js/jquery.nice-select.min.js",
                    "~/Content/Theme/vendors/owl-carousel/owl.carousel.min.js",
                     "~/Content/Theme/js/owl-carousel-thumb.min.js",
                     "~/Content/Theme/js/jquery.ajaxchimp.min.js",
                     "~/Content/Theme/js/mail-script.js",
                     "~/Content/Theme/js/theme.js"
                     ));
            //Admin theme
            bundles.Add(new ScriptBundle("~/Content/Admin/js").Include(
                     "~/Content/ThemeAdmin/vendor/jquery/jquery.min.js",
                     "~/Content/ThemeAdmin/vendor/bootstrap/js/bootstrap.bundle.min.js",
                     "~/Content/ThemeAdmin/vendor/jquery-easing/jquery.easing.min.js",
                     "~/Content/ThemeAdmin/js/sb-admin-2.min.js",
                      "~/Content/ThemeAdmin/vendor/datatables/jquery.dataTables.min.js",
                       "~/Content/ThemeAdmin/vendor/datatables/dataTables.bootstrap4.min.js",
                       "~/Content/ThemeAdmin/js/demo/datatables-demo.js"
                     ));

            bundles.Add(new StyleBundle("~/Content/Admin/css").Include(
                      "~/Content/ThemeAdmin/css/sb-admin-2.min.css",
                      "~/Content/ThemeAdmin/vendor/fontawesome-free/css/all.min.css",
                      "~/Content/ThemeAdmin/vendor/datatables/dataTables.bootstrap4.min.css"
                      ));
        }
    }
}

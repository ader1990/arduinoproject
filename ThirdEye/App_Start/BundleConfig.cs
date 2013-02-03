using System.Web;
using System.Web.Optimization;

namespace ThirdEye
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/lib/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/lib/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/lib/jquery.unobtrusive*",
                        "~/Scripts/lib/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/oltonMetroUI/css/modern-responsive.css",
                        "~/Content/oltonMetroUI/css/modern.css",
                        "~/Content/oltonMetroUI/javascript/accordion.js",
                        "~/Content/oltonMetroUI/javascript/buttonset.js",
                        "~/Content/oltonMetroUI/javascript/carousel.js",
                        "~/Content/oltonMetroUI/javascript/dialog.js",
                        "~/Content/oltonMetroUI/javascript/dropdown.js",
                        "~/Content/oltonMetroUI/javascript/input-control.js",
                        "~/Content/oltonMetroUI/javascript/pagecontrol.js",
                        "~/Content/oltonMetroUI/javascript/rating.js",
                        "~/Content/oltonMetroUI/javascript/slider.js",
                        "~/Content/oltonMetroUI/javascript/start-menu.js",
                        "~/Content/oltonMetroUI/javascript/tile-drag.js",
                        "~/Content/oltonMetroUI/javascript/tile-slider.js"
                        ));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}
using System.Web;
using System.Web.Optimization;

namespace GHeatMVC
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.*"));

            bundles.Add(new ScriptBundle("~/bundles/pages")
                        .Include("~/Scripts/pages/Master.js")
                        .Include("~/Scripts/pages/SiteSelection.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                        .Include("~/Content/bootstrap/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/bundles/bootstrap_css")
                        .Include("~/Content/bootstrap_extensions.css"));

            bundles.Add(new StyleBundle("~/Content/css")
                        .Include("~/Content/v1_*"));

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
using System.Web;
using System.Web.Optimization;

namespace ReciclaMaisBrasil
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui.min.js",
                        "~/Scripts/jquery-ui.js",
                        "~/Scripts/mascaracpf.js",
                        "~/Scripts/jquery.mask.min.js",
                        "~/Scripts/Autenticacao.js",
                        "~/Scripts/dhtmlxCalendar_v51_std/codebase/dhtmlxcalendar.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/jquery-ui.min.css",
                      "~/Content/ReciclaStyle.css",
                      "~/Scripts/dhtmlxscheduler/dhtmlxsheduler_classic.css,",
                      "~/Scripts/dhtmlxCalendar_v51_std/codebase/fonts/font_roboto/roboto.css,",
                       "~/Scripts/dhtmlxCalendar_v51_std/codebase/dhtmlxcalendar.css"));
        }
    }
}

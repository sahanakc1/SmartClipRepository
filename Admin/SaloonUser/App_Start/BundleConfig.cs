using System.Web;
using System.Web.Optimization;

namespace SaloonUser
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
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            #region Scripts           

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                            "~/assets/js/jquery.min.js",
                            "~/assets/js/popper.min.js",
                            "~/assets/js/bootstrap.min.js",
                            "~/assets/js/modernizr.min.js",
                            "~/assets/js/detect.js",
                            "~/assets/js/fastclick.js",
                            "~/assets/js/jquery.slimscroll.js",
                            "~/assets/js/jquery.blockUI.js",
                            "~/assets/js/waves.js",
                            "~/assets/js/jquery.nicescroll.js",
                            "~/assets/js/jquery.scrollTo.min.js"));

            #endregion



            #region CSS

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/assets/css/bootstrap.min.css",
                      "~/assets/css/icons.css",
                      "~/assets/css/style.css"));
            #endregion            
        }
    }
}

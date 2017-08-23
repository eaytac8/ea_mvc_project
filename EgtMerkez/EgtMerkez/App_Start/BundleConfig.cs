using System.Web;
using System.Web.Optimization;

namespace EgtMerkez
{
    public class BundleConfig
    {
         public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.min.js","~/Scripts/plugings.js","~/Scripts/custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/jquery-1.10.2.min.js", "~/Scripts/jquery-migrate-1.2.1.min.js", "~/Scripts/modernizr.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/font.awesome.min.css", "~/Content/css/animate.css", "~/Content/css/style.css"));
        }
    }
}

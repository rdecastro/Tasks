using System.Web;
using System.Web.Optimization;

namespace Tasks
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Content/tasks-scripts").Include(
                    "~/Scripts/jquery-{version}.min.js", 
                    "~/Scripts/bootstrap.min.js", 
                    "~/Scripts/Tasks.js"));

            bundles.Add(new StyleBundle("~/Content/tasks-styles").Include(
                    "~/Content/bootstrap.min.css", 
                    "~/Content/bootstrap-responsive.min.css"));

        }
    }

}
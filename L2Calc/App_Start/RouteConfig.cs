using System;
using System.Web.Routing;

// namespace GameStore.App_Start
namespace L2Calc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(null, "list/{category}/{page}",
                                        "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list/{page}", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list", "~/Pages/Listing.aspx");
            routes.MapPageRoute("D-S80", "D-S80", "~/Pages/D-S80.aspx");
            routes.MapPageRoute("faq", "faq", "~/Pages/FAQ.aspx");

            
        }
    }
}
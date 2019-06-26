using System.Web.Mvc;
using System.Web.Routing;

namespace Qwe
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.IgnoreRoute("Home/Index/100");

            routes.MapRoute(
                name: "Default2",
                url: "Ru/{controller}/{action}/{id}",
                defaults: new { id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default3", 
                url: "Shop/AddShort", 
                defaults: new { controller = "Home", action = "Add" }
            );

            routes.MapRoute(
                name: "Default4",
                url: "Shop/AddPens",
                defaults: new { controller = "Pens", action = "Addp" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { controller = "^H.*" }
            );

            routes.MapRoute(
                name: "Default5",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Pens", action = "Pen", id = UrlParameter.Optional },
                constraints: new { controller = "^P.*" }
            );

        }
    }
}

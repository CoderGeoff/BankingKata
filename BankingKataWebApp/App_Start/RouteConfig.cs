using System.Web.Mvc;
using System.Web.Routing;

namespace BankingKataWebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            const string entryName = "Default";
            const string fromUrl = "{controller}/{action}/{id}";
            object toUrlHandler = new { controller = "Home", action = "Index", id = UrlParameter.Optional };
            string[] urlHandlerNamespaces = { "BankingKataWebApp.Controllers" };

            routes.MapRoute(entryName, fromUrl, toUrlHandler, urlHandlerNamespaces);
        }
    }
}

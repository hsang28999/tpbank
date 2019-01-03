using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TPBankASM
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Login",
                url: "login",
                defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Menu",
                url: "menu",
                defaults: new { controller = "Home", action = "menu", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Details",
                url: "account-detail/{id}",
                defaults: new { controller = "Home", action = "Details", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "History",
                url: "history",
                defaults: new { controller = "Home", action = "History", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Deposit",
                url: "Deposit",
                defaults: new { controller = "Home", action = "Deposit", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookStore.Routes
{
    public class BooksRouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

           
            routes.MapRoute(
                name: "EditItem",
                url: "{Books}/{EditItem}/{id}/{t}",
                defaults: new { controller = "Books", action = "EditItem" }
            );

            routes.MapRoute(
                name: "BooksDefault",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Books", action = "GetBooks", id = UrlParameter.Optional }
            );


        }
    }
}
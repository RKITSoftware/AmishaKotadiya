using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RestWebAPIDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Enable attribute routing

            config.MapHttpAttributeRoutes();

            // WebAPI route
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/WebAPI/{id}",
                defaults: new { controller = "WebAPI", id = RouteParameter.Optional }
            );

            // Add default route using convention-based routing
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

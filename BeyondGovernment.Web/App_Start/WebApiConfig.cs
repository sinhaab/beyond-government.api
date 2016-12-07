using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using BeyondGovernment.Web.ActionFilter;
using BeyondGovernment.Web.App_Start;

namespace BeyondGovernment.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Filters.Add(new GlobalExceptionAttribute());
        }
    }
}

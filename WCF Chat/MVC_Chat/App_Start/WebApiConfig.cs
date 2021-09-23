using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MVC_Chat
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            configuration.Routes.MapHttpRoute("API Default", "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
        }
    }
}

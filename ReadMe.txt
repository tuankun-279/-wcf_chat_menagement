chuyển project mvc sang api
thêm đoạn code sau 

public static void Register(HttpConfiguration configuration)
    {
        configuration.Routes.MapHttpRoute("API Default", "api/{controller}/{id}",
            new { id = RouteParameter.Optional });
    }

vào file App_Start\WebApiConfig.cs

và đoạn code sau 

AreaRegistration.RegisterAllAreas();

    RegisterGlobalFilters(GlobalFilters.Filters);
    WebApiConfig.Register(GlobalConfiguration.Configuration);
    RegisterRoutes(RouteTable.Routes);
    BundleConfig.RegisterBundles(BundleTable.Bundles);

vào file Global.asax.cs bên trong hàm Application_Start()
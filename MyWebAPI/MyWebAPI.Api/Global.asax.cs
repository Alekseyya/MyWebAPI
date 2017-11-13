using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MyWebAPI.Api.App_Start;
using MyWebAPI.DI;
using Ninject;
using Ninject.Modules;
using Ninject.Web.WebApi;


namespace MyWebAPI.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapperApiConfiguration.Configure();

            //NinjectModule registrations = new NinjectRegistrations();
            //var kernel = new StandardKernel(registrations);
            //GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);
        }
    }
}

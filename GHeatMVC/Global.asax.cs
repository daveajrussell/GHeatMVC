using GHeatMVCDomainModel.DomainRepositories;
using GHeatMVCDomainModel.Interfaces.Repositories;
using GHeatMVCDomainModel.Interfaces.Services;
using GHeatMVCDomainModel.Services;
using Ninject;
using Ninject.Web.Mvc;
using SqlRepositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace GHeatMVC
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            SetupDependencyInjection(); 
        }


        private void SetupDependencyInjection()
        {
            IKernel kernel = new StandardKernel();

            var baseDirectory = HttpRuntime.AppDomainAppPath;
            baseDirectory = baseDirectory + "Content\\etc\\";

            var _connectionString = ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;

            kernel.Bind<ISettingsRepository>().To<SettingsRepository>().WithConstructorArgument("baseDirectory", baseDirectory);

            kernel.Bind<IGHeatService>().To<GHeatService>();
            kernel.Bind<IPointService>().To<PointService>();

            kernel.Bind<IGHeatRepository>().To<GHeatRepository>();
            kernel.Bind<IPointRepository>().To<SqlPointRepository>().WithConstructorArgument("connectionString", _connectionString);

            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
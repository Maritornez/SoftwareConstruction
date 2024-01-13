using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Business_Logic_Layer;
using Business_Logic_Layer.Util;
using Lab2EF.Util;
using Ninject;
using Ninject.Web.Mvc;

namespace Lab5AspNetMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // внедрение зависимостей
            var kernel = new StandardKernel(new NinjectRegistrations(), new ServiceModule("TaskContext"));
            DependencyResolver.SetResolver(new NinjectDependencyResolver((Ninject.Syntax.IResolutionRoot)kernel));
        }
    }
}

using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using V4mvc.Presentation.helpers;
[assembly: OwinStartup(typeof(V4mvc.Presentation.Startup))]

namespace V4mvc.Presentation
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ControllerBuilder.Current.SetControllerFactory(new DefaultControllerFactory(new MultiLanguageControllerActivator()));
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            UnityConfig.RegisterComponents();
            BundleTable.EnableOptimizations = true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace V4mvc.Presentation.helpers
{
    public class MultiLanguageControllerActivator : IControllerActivator
    {
        private string FallBackLanguage = "en-US";
        public IController Create(RequestContext requestContext, Type controllerType)
        {
            //if (HttpContext.Current.Session["Language"] != null) {
            //    FallBackLanguage = HttpContext.Current.Session["Language"].ToString();
            //}

            if (requestContext.HttpContext.Request.UserLanguages != null)
            {
                string primary_lan = requestContext.HttpContext.Request.UserLanguages[0];
                string closest_lan = V4mvc.Entities.Utils.getClosestCulture(primary_lan);
                FallBackLanguage =  closest_lan ?? FallBackLanguage;
            }

            Thread.CurrentThread.CurrentCulture = new CultureInfo(FallBackLanguage);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(FallBackLanguage);

            return DependencyResolver.Current.GetService(controllerType) as IController;
        }
    }
}

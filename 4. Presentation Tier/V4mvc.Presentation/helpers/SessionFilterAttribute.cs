using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using static V4mvc.Presentation.Areas.Contratista.Controllers.DashBoardController;

namespace V4mvc.Presentation.helpers
{
    public class SessionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            if (HttpContext.Current.Session["TIPOUSUARIO"] == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                {
                    controller = "Login",
                    action = "RedirectToLogin",
                    Area = ""
                }));
            }
        }
    }
}
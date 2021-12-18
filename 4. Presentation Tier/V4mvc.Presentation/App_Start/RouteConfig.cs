using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace V4mvc.Presentation
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional },
                namespaces: new string[] { "V4mvc.Presentation.Controllers"}
            );

            //routes.MapRoute(
            //    name: "PersonalDefault",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Aprobacion_SubContrato", action = "Index", id = UrlParameter.Optional },
            //    namespaces: new string[] { "V4mvc.Presentation.Controllers" }
            //);

            //routes.MapRoute(
            //    name: "Contratista",
            //    url: "{controller}/{action}/{id}"
            //).DataTokens = new RouteValueDictionary(new { area = "Contratista"});

            //routes.MapRoute(
            //    name: "Home",
            //    url: "{controller}/{action}/{DIVCOD}/{ID_DOC_OPCION}",
            //    new { controller = "Home", action = "Modal_DetalleAcreditacion", DIVCOD = UrlParameter.Optional, ID_DOC_OPCION = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "Formatos",
            //    url: "{controller}/{action}/{Codigo}/{RUT}",
            //    new { controller = "Covid19", action = "Formato00", Codigo = UrlParameter.Optional, RUT = UrlParameter.Optional }
            //);
            //routes.MapRoute(
            //    name: "Formatos300",
            //    url: "{controller}/{action}/{Codigo}/{RUT}/{Fecha}",
            //    new { controller = "Cuarentena", action = "Formato300", Codigo = UrlParameter.Optional, RUT = UrlParameter.Optional, Fecha = UrlParameter.Optional }
            //);
        }
    }
}

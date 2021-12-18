using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Reflection;

namespace V4mvc.Presentation
{
    public static class Helpers
    {
        public static MvcHtmlString NoEncodeActionLink(this HtmlHelper htmlHelper,
                                            string text, string title, string action = null,
                                            string controller = null,
                                            object routeValues = null,
                                            object htmlAttributes = null)
        {
            UrlHelper urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext);

            TagBuilder builder = new TagBuilder("a");
            builder.InnerHtml = text;
            builder.Attributes["title"] = title;
            builder.Attributes["href"] = urlHelper.Action(action, controller, routeValues);
            builder.MergeAttributes(new RouteValueDictionary(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes)));
            return MvcHtmlString.Create(builder.ToString());
        }

        public static MvcHtmlString NoEncodeActionLink(this HtmlHelper htmlHelper,
                                             string text, string title,
                                             object htmlAttributes = null)
        {
            UrlHelper urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext);

            TagBuilder builder = new TagBuilder("a");
            builder.InnerHtml = text;
            builder.Attributes["title"] = title;
            builder.MergeAttributes(new RouteValueDictionary(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes)));

            return MvcHtmlString.Create(builder.ToString());
        }

        public static HtmlString HtmlConvertToJson(this HtmlHelper htmlHelper, object model)
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented
            };

            return new HtmlString(JsonConvert.SerializeObject(model, settings));
        }
        //public static string Encrypt(string message)
        //{
        //    try
        //    {
        //        ICryptoManager objCM = new CryptoManager();
        //        ICryptoContext objContext = objCM.OpenContext("", true, Missing.Value);
        //        ICryptoKey objKey = objContext.GenerateKeyFromPassword("webcontrol");
        //        ICryptoBlob objBlob = objKey.EncryptText(message);
        //        return objBlob.Hex;
        //    }
        //    catch (Exception ex)
        //    { throw ex; }
        //}

        //public static string Decrypt(string message)
        //{
        //    try
        //    {
        //        ICryptoManager objCM = new CryptoManager();
        //        ICryptoContext objContext = objCM.OpenContext("", true, Missing.Value);
        //        ICryptoKey objKey = objContext.GenerateKeyFromPassword("webcontrol");
        //        ICryptoBlob objBlob = objCM.CreateBlob();
        //        objBlob.Hex = message;
        //        return objKey.DecryptText(objBlob);
        //    }
        //    catch (Exception ex)
        //    { throw ex; }
        //}
        public static string ResolveServerUrl(string serverUrl, bool forceHttps)
        {
            if (serverUrl.IndexOf("://") > -1)
                return serverUrl;

            string newUrl = serverUrl;
            Uri originalUri = System.Web.HttpContext.Current.Request.Url;
            newUrl = (forceHttps ? "https" : originalUri.Scheme) +
                "://" + originalUri.Authority + newUrl;
            return newUrl;
        }

        public static void custom_debug(object obj)
        {
            System.Diagnostics.Debug.WriteLine("===============>>>>" + Newtonsoft.Json.JsonConvert.SerializeObject(obj));
        }

        public static HtmlString HtmlConvertEnumToInt32(this HtmlHelper htmlHelper, object obj)
        {
            return new HtmlString(Convert.ToInt32(obj).ToString());
        }

        public static int diferenciaDias(string FECHA_INI, string FECHA_FIN)
        {
            DateTime dtFECHA_INI = DateTime.ParseExact(FECHA_INI, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime dtFECHA_FIN = DateTime.ParseExact(FECHA_FIN, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            return (dtFECHA_FIN - dtFECHA_INI).Days;
        }
        public static string IsSelected(this HtmlHelper html, string url = null, string submenu = null, string cssClass = null)
        {
            var area = "";
            var controller = "";
            var action = "";
            if (url != null) {
                var array = url.Split('/');
                area = array[1];
                controller = array[2];
                action = array[3];
            }

            if (String.IsNullOrEmpty(cssClass))
                cssClass = "active";

            string currentAction = HttpContext.Current.Session["ActionName"] == null ? "" : HttpContext.Current.Session["ActionName"].ToString();
            string currentController = HttpContext.Current.Session["ControllerName"] == null ? "" : HttpContext.Current.Session["ControllerName"].ToString();
            string currentSubMenu = HttpContext.Current.Session["SubMenu"] == null ? "" : HttpContext.Current.Session["SubMenu"].ToString();

            if (String.IsNullOrEmpty(controller))
                controller = currentController;

            if (String.IsNullOrEmpty(action))
                action = currentAction;

            if (!String.IsNullOrEmpty(submenu))
                return submenu == currentSubMenu ? cssClass : String.Empty;

            return controller == currentController && action == currentAction ? cssClass : String.Empty;
        }

        public static string PageClass(this HtmlHelper html)
        {
            string currentAction = (string)html.ViewContext.RouteData.Values["action"];
            return currentAction;
        }
    }

    public class HtmlCuerpoCorreoArgs
    {
        public string HTML_RECEPTOR { get; set; }
        public string HTML_CUERPO { get; set; }
        public string HTML_DESPEDIDA { get; set; }
        public string HTML_TABLA_TITULO { get; set; }
        public string HTML_PIEPAGINA { get; set; }
        public List<KeyValuePair<string, string>> HTML_TABLA_PARAMETROS { get; set; }
    }

    public static class RazorViewToString
    {
        public static string RenderRazorViewToString(this Controller controller, string viewName, object model)
        {
            controller.ViewData.Model = model;
            using (var sw = new System.IO.StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(controller.ControllerContext, viewName);
                var viewContext = new ViewContext(controller.ControllerContext, viewResult.View, controller.ViewData, controller.TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(controller.ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }
    }
}